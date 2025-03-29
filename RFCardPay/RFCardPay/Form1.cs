using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Management;
using Microsoft.Win32;

namespace RFCardPay
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


            serialPort1.DtrEnable = true;
            serialPort1.RtsEnable = true;
            
            try
            {
                if (!serialPort1.IsOpen){
                    serialPort1.Open();
                }
             }catch (Exception ex) {
                  MessageBox.Show(ex.Message);
            }
            
            if (serialPort1.IsOpen)
            {
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
            }
        }
        string ReadedRfidCardNumber = "";
        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try{
                SerialPort sp1 = (SerialPort)sender;
                sp1.DtrEnable = true;  
                sp1.RtsEnable = true;

                string readed = sp1.ReadLine().Trim();
                Console.WriteLine("Data : "+ readed);
                if (CheckRfidCardNumberFormat(readed))
                {
                    ReadedRfidCardNumber = readed;
                }
                else
                {
                    if (CheckJsonFormat(readed))
                    {
                        Payment payment = JsonConvert.DeserializeObject<Payment>(readed);
                        ProcessPayment(payment);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadCardsTableData()
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            DataTable Cards = rfCardPayDal.GetCards();
            CardsDataGridView.DataSource = Cards;
            ProductsDataGridView.Refresh();
        }
        public void LoadProductsTableData()
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            DataTable Products = rfCardPayDal.GetProducts();
            ProductsDataGridView.DataSource = Products;
            ProductsDataGridView.Refresh();
        }
        public void LoadOperationsTableData()
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            DataTable operations = rfCardPayDal.GetOperations();
            OperationsDataGridView.DataSource = operations;
            OperationsDataGridView.Refresh();

            DataTable addFundsOperations = rfCardPayDal.GetAddFundsOperations();
            OperationsBkyDataGridView.DataSource = addFundsOperations;
            OperationsBkyDataGridView.Refresh();
         
        }
        

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            string NameSurname = txtNameSurname.Text;
            string PhoneNumber = txtPhoneNumber.Text;

            string RfidCardNo = txtRfidNumber.Text;

            if (NameSurname.Length > 0 && PhoneNumber.Length > 0 && RfidCardNo.Length > 0 && double.TryParse(txtBalance.Text, out _))
            {
                double Balance = Convert.ToDouble(txtBalance.Text);
                bool AddCard = rfCardPayDal.AddCard(NameSurname, PhoneNumber, Balance, RfidCardNo);
                if (AddCard)
                {
                    LoadCardsTableData();
                    MessageBox.Show("Successful");
                }
            }
            else
            {
                MessageBox.Show("Fill the required fields");
            }

        }

        public bool CheckRfidCardNumberFormat(string RfidCardNo)
        {
            string[] parts = RfidCardNo.Split(' ');
            if (parts.Length == 4)
            {
                int total = 0;
                foreach(string part in parts)
                {
                    total += part.Length;
                }
                if (total == 8)
                {
                    return true;
                }else{
                    return false;
                }
            }
            return false;
        }

        public bool CheckJsonFormat(string json)
        {
            JsonSchema schema = JsonSchema.Parse(json);
            JObject obj = JObject.Parse(json);
            return obj.IsValid(schema);
        }

        private void btnAcrdReadCard_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            MessageBox.Show("Bring the Card Closer to Read");
            txtRfidNumber.Text = ReadedRfidCardNumber;
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            string ProductName = txtProductName.Text;
            
            if(ProductName.Length > 0 && double.TryParse(txtProductPrice.Text, out _))
            {
                if(ProductName.Length < 10)
                {
                    double ProductPrice = Convert.ToDouble(txtProductPrice.Text);
                    bool AddProduct = rfCardPayDal.AddProduct(ProductName, ProductPrice);
                    if (AddProduct)
                    {
                        LoadProductsTableData();
                        MessageBox.Show("Successful");
                    }
                }
                else
                {
                    MessageBox.Show("Product Name must be 10 characters");
                }
            }
            else
            {
                MessageBox.Show("Fill the required fields");
            }
           
        }

        int SelectedProductId;
        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ProductId = Convert.ToInt32(ProductsDataGridView.SelectedRows[0].Cells[0].Value);
            txtUpProductName.Text = ProductsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtUpProductPrice.Text = ProductsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            SelectedProductId = ProductId;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            string ProductName = txtUpProductName.Text;
           
           
            if (ProductName.Length>0 && double.TryParse(txtUpProductPrice.Text, out _))
            {
               if (ProductName.Length < 10)
                {
                    double ProductPrice = Convert.ToDouble(txtUpProductPrice.Text);
                    bool UpdateProduct = rfCardPayDal.UpdateProduct(SelectedProductId, ProductName, ProductPrice);
                    if (UpdateProduct)
                    {
                        LoadProductsTableData();
                        MessageBox.Show("The Product Has Been Updated Successfully ");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill the required fields");
            }
           
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            bool DeleteProduct = rfCardPayDal.DeleteProduct(SelectedProductId);
            if (DeleteProduct)
            {
                MessageBox.Show("Product Deleted ");
                LoadProductsTableData();
            }
        }

        private void btnSendProductsToDevice_Click(object sender, EventArgs e)
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            string ProductsJson = rfCardPayDal.ProductsJson();
            Console.WriteLine(ProductsJson);
            serialPort1.WriteLine(ProductsJson);
        }


        private void ProcessPayment(Payment payment)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            bool IsEligibleForPayment = rfCardPayDal.IsEligibleForPayment(payment);
            bool IsCardRegistered = rfCardPayDal.IsCardRegistered(payment.rfid);
            if (IsCardRegistered)
            {
                if (IsEligibleForPayment)
                {
                    bool IsPaymentSuccessful = rfCardPayDal.BuyProduct(payment);
                    if (IsPaymentSuccessful)
                    {
                        serialPort1.WriteLine("m_transaction_successful");
                        MessageBox.Show("Transaction Successful");
                        LoadOperationsTableData();          
                    }
                }
                else
                {
                    serialPort1.WriteLine("m_insufficient_balance");
                    MessageBox.Show("Your balance is not enough for Payment");
                   
                }
            }
            else
            {
                serialPort1.WriteLine("m_card_unregistered");
                MessageBox.Show("Card Unregistered");
            }
           
        }

        private void btnFndQryReadCard_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            MessageBox.Show("Bring the Card Closer to Read");
            txtCheckBalanceRFID.Text = ReadedRfidCardNumber;
        }
        private void btnAddFndReadCard_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            MessageBox.Show("Bring the Card Closer to Read");
            txtAddFundsRFID.Text = ReadedRfidCardNumber;
        }

        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            string RfidCardNumber = txtAddFundsRFID.Text;
            double Amount = Convert.ToInt32(txtAmountToAdd.Text);

            bool IsCardRegistered = rfCardPayDal.IsCardRegistered(RfidCardNumber);
            if (IsCardRegistered)
            {
                bool IsBalanceAdditionSuccessful =  rfCardPayDal.AddFunds(RfidCardNumber, Amount);
                if (IsBalanceAdditionSuccessful)
                {
                    LoadOperationsTableData();
                    MessageBox.Show("Successfully Added Balance to Card");
                }
            }
            else
            {
                MessageBox.Show("This Card Is Not Registered");
            }
        }

        private void btnCheckCardBalance_Click(object sender, EventArgs e)
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            string RfidCardNumber = txtCheckBalanceRFID.Text;

            bool IsCardRegistered = rfCardPayDal.IsCardRegistered(RfidCardNumber);
            if (IsCardRegistered)
            {
                DataTable dr = rfCardPayDal.GetCard(RfidCardNumber);
                txtShowBalance.Text =  dr.Rows[0].Field<double>(3).ToString();
                OperationsBkyDataGridView.DataSource = rfCardPayDal.GetCardBalanceTransactions(RfidCardNumber);
            }
            else
            {
                MessageBox.Show("This Card Is Not Registered");

            }
        }

        int SelectedCardId;
        private void CardsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCardId = Convert.ToInt32(CardsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            txtUpdNameSurname.Text = CardsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txUpdPhoneNumber.Text = CardsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtUpdBalance.Text = CardsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnUpdateCard_Click(object sender, EventArgs e)
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            string NameSurname = txtUpdNameSurname.Text;
            string PhoneNumber = txUpdPhoneNumber.Text;
         

            if (NameSurname.Length > 0 && PhoneNumber.Length > 0  && double.TryParse(txtUpdBalance.Text, out _))
            {
                double Bakiye = Convert.ToDouble(txtUpdBalance.Text);
                bool KartGuncelle = rfCardPayDal.UpdateCard(SelectedCardId, NameSurname, PhoneNumber, Bakiye);
                if (KartGuncelle)
                {
                    LoadCardsTableData();
                    MessageBox.Show("Successful");
                }
            }
            else
            {
                MessageBox.Show("Fill the required fields");
            }
        
        }

        private void btnDeleteCard_Click(object sender, EventArgs e)
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            bool deleteCard = rfCardPayDal.DeleteCard(SelectedCardId);
            if (deleteCard)
            {
                LoadCardsTableData();
                MessageBox.Show("Successful");
            }
        }

        private void btnListOperations_Click(object sender, EventArgs e)
        {
            string RfidCardNo = txtLoCardNo.Text;
            bool IsAddFundsChecked = chcAddFuns.Checked;
            bool IsPurchaseChecked = chcPurchase.Checked;
            string OperationType = "";
            if (IsAddFundsChecked && IsPurchaseChecked)
            {
            }
            else if (IsAddFundsChecked)
            {
                OperationType = "add-funds";
            }else if (IsPurchaseChecked)
            {
                OperationType = "purchase";
            }
            if (!(!IsAddFundsChecked && !IsPurchaseChecked || RfidCardNo.Length == 0))
            {
                RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
                DataTable dt = rfCardPayDal.GetCardOperations(RfidCardNo, OperationType);
                OperationsDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fill the required fields");
            }
          
        }

        private void btnFilterOperations_Click(object sender, EventArgs e)
        {
            string RfidCardNo = txtLoCardNo.Text;
            bool IsAddFundsChecked = chcAddFuns.Checked;
            bool IsPurchaseChecked = chcPurchase.Checked;

            string StartDate = dtpStartDate.Text.ToString();
            string EndDate = dtpEndDate.Text.ToString();
            string OperationType = "";
            if(IsAddFundsChecked && IsPurchaseChecked)
            {

            }
            else if (IsAddFundsChecked)
            {
                OperationType = "add-funds";
            }
            else if (IsPurchaseChecked)
            {
                OperationType = "purchase";
            }

            if (!(StartDate.Length == 0 || EndDate.Length == 0 || RfidCardNo.Length ==0))
            {
                RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
                DataTable dt = rfCardPayDal.GetCardOperations(RfidCardNo, OperationType, true, StartDate, EndDate);
                OperationsDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fill the required fields");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BluetoothCon bl = new BluetoothCon();
            string[] ports = bl.GetBluetoothPorts();
            foreach(string port in ports)
            {
                cmbBluetoothSec.Items.Add(port);
            }

            LoadCardsTableData();
            LoadProductsTableData();
            LoadOperationsTableData();
        }
        private void btnLoReadCard_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            MessageBox.Show("Bring the Card Closer to Read");
            txtLoCardNo.Text = ReadedRfidCardNumber;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            string selectedText = cmbBluetoothSec.Text;
            string[] parts = selectedText.Split('(');
            string port = parts[1].Split(')')[0];

            serialPort1.PortName = port;
            serialPort1.BaudRate = 9600;
            serialPort1.DtrEnable = true;
            serialPort1.RtsEnable = true;
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void btnResetApplication_Click(object sender, EventArgs e)
        {
            RFCardPayDAL rfCardPayDal = new RFCardPayDAL();
            bool result = rfCardPayDal.CleanTables();
            if (result)
            {
                MessageBox.Show("Reset Successful");
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

  
    }
}
