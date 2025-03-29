using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace RFCardPay
{
    class BluetoothCon
    {
        public string[] GetBluetoothPorts()
        {
            System.Management.ManagementObjectSearcher serialSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_SerialPort");
            List<string> ports = new List<string>();
            var query = from ManagementObject s in serialSearcher.Get()
                        select new { Name = s["Name"], DeviceID = s["DeviceID"], PNPDeviceID = s["PNPDeviceID"] }; // DeviceID -- > PNPDeviceID

            foreach (var port in query)
            {
                var pnpDeviceId = port.PNPDeviceID.ToString();

                if (pnpDeviceId.Contains("BTHENUM"))
                {
                    var bluetoothDeviceAddress = pnpDeviceId.Split('&')[4].Split('_')[0];
                    if (bluetoothDeviceAddress.Length == 12 && bluetoothDeviceAddress != "000000000000")
                    {
                        string portName = port.Name.ToString().Substring(36, port.Name.ToString().Length - 36);
                        string deviceNameRaw = GetBluetoothRegistryName(bluetoothDeviceAddress);
                        string deviceName = deviceNameRaw.Remove(deviceNameRaw.Length - 1);
                        string portToAdd = deviceName + " " + portName;
                        ports.Add(portToAdd);
                    }
                }
            }
            return ports.ToArray();
        }
        private static string GetBluetoothRegistryName(string address)
        {
            string deviceName = "";
            string registryPath = @"SYSTEM\CurrentControlSet\Services\BTHPORT\Parameters\Devices";
            string devicePath = String.Format(@"{0}\{1}", registryPath, address);
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(devicePath))
            {
                if (key != null)
                {
                    Object o = key.GetValue("Name");
                    byte[] raw = o as byte[];
                    if (raw != null)
                    {
                        deviceName = Encoding.ASCII.GetString(raw);
                    }
                }
            }
            return deviceName;
        }
    }
}
