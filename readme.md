# RfCardPay

RFCardPay is a RFID card payment system developed using Arduino. I developed it for a data communication course I took during my undergraduate studies. 
RFCardPay exchanges data via Bluetooth through a computer interface. The interface, written in C#, includes areas where cards can be registered, balances can be loaded onto cards, and transaction history can be viewed.

Using the interface, products are defined and written into RFCardPay's permanent memory. Methods for writing and reading products from the EEPROM memory on the Arduino have been developed. The products are listed on an OLED display, and there are left and right buttons to navigate through the product list. A touch button in the center initiates the payment process, during which the card is scanned. If the card has sufficient balance, this is displayed on the screen. If the balance is enough, the transaction is communicated to the computer interface, recorded, and the product price is deducted from the card's balance.

All messages during every step of the process, including card registration and payment, are displayed on the OLED screen of the device.


## Used Hardware & Software

### Used Hardware Components

- Arduino Mega 2560
- RFID-RC522
- HC-06 Bluetooth Sensor
- 128x32 I2C OLED Display 
- 2 Buttons
- Touch Button

### Used Software Components

- Desktop application written in C#
- Microsoft SQL Server


## Connections of parts

![Schematic!](/Schematic/RFCardPay_bb.png "Schematic")

Fritzing program was used for circuit design, the fritzing file and pdf output of this design are in the Schematic folder.

[Fritzing File of the Design](/Schematic/RFCardPay.fzz)
[PDF Output of the Design](/Schematic/RFCardPay_bb.pdf)

### RFID-RC522 Module

| Pin on Module | Pin on Arduino |
|---------------|----------------|
| SDA           | 53             |
| SCK           | 52             |
| MOSİ          | 51             |
| MİSO          | 50             |
| IRQ           | (Empty)        |
| GND           | GND            |
| RST           | 5              |
| 3.3V          | 5V             |


### HC-06 Bluetooth Module


| Pin on Module | Pin on Arduino |
|---------------|----------------|
| Rx            | Tx3            |
| Tx            | Rx3            |
| GND           | GND            |
| VCC           | 5V             |

### 128x32 I2C OLED Display 

| Pin on Module | Pin on Arduino |
|---------------|----------------|
| SDA           | SDA (20)       |
| SCK           | SCL (21)       |
| VCC           | 5V             |
| GND           | GND            |

### Button 1

| Pin on Module | Pin on Arduino |
|---------------|----------------|
| Pin 1         | 22 (LOW)       |
| Pin 2         | 23 (Read)      |

### Button 2

| Pin on Module | Pin on Arduino |
|---------------|----------------|
| Pin 1         | 24 (LOW)       |
| Pin 2         | 25 (Read)      |

### Touch Button

| Pin on Module | Pin on Arduino |
|---------------|----------------|
| GND           | 37 (LOW)       |
| VCC           | 36 (HIGH)      |
| SIG           | 39             |


## Pictures of the Device
<img src="/Images/1.jpg" width="40%">      <img src="/Images/2.jpg" width="40%">
<img src="/Images/3.jpg" width="40%">      <img src="/Images/4.jpg" width="40%">

## Some Explations of the Arduino Code

## EEPROM Operations

### Structure Definition (`Product`):
This code defines a structure for storing product information and contains functions related to reading from and writing to EEPROM memory on an Arduino.

```cpp
typedef struct{
  byte id;            // Product ID, stored as a byte
  char name[10];      // Product name, a string with a maximum length of 10 characters
  float price;        // Product price, stored as a float
  char control_bit;   // Control bit, a character used to track the product's status (e.g., 'o' for valid products)
} Product;
```

### Function Definitions:

### String toStr(char * d)
*Purpose:* Converts a C-style string (char*) into an Arduino String object.

```cpp
String toStr(char * d){
  return String(d);
}
```
### int EEPROMDataCount()
*Purpose:* This function counts how many valid products are stored in the EEPROM.

```cpp
int EEPROMDataCount(){
    int count = 0;
    for(int i=0; i<EEPROM.length(); i++){
     Product temp_product;
     EEPROM.get(i*sizeof(Product), temp_product);
     if(temp_product.control_bit == 'o'){
        count++;
     } else {
        break;
     }
  }
  return count;
}
```

### void EEPROMAddData(int position, Product data)

*Purpose:* This function writes a Product object to a specific position in EEPROM.

Explanation:

* Takes position (the EEPROM address) and data (the product to store).
* Uses EEPROM.put() to store the Product at the calculated memory address.
* The address is calculated by multiplying the position by the size of the Product structure (sizeof(Product)), ensuring proper placement in EEPROM.

```cpp
void EEPROMAddData(int position, Product data){
  EEPROM.put(sizeof(Product)*position, data);
}
```

### void ParseData(String json)

The `ParseData` function is used to parse a JSON string containing product information and store that data in EEPROM memory. It uses the Arduino JSON library to deserialize the JSON string, extract relevant product details, and then write those details to EEPROM.

```cpp
void ParseData(String json){
  const size_t capacity = JSON_ARRAY_SIZE(10) + JSON_OBJECT_SIZE(1) + 10*JSON_OBJECT_SIZE(3) + 120;
  DynamicJsonDocument doc(capacity);
  deserializeJson(doc, json);
  
  for(int i = 0; i<sizeof(doc["products"]);i++){
    JsonObject product = doc["products"][i];
    char product_name[10];

    String str_product_name = toStr(product["Name"]);
    str_product_name.toCharArray(product_name, 10);

    Product product_to_be_added;
    product_to_be_added.id = (byte) product["Id"];
    strcpy(product_to_be_added.name, product_name);
    product_to_be_added.price = product["Price"];
    product_to_be_added.control_bit = 'o';
    EEPROMAddData(i, product_to_be_added);
  }
}
```

### String ReadRfidCard()
The `ReadRfidCard` function is used to read the unique identifier (UID) of an RFID card using the MFRC522 RFID module. The UID is then returned as a string in a human-readable hexadecimal format.

```cpp
String ReadRfidCard(){
  String card_id = "";
  if( mfrc522.PICC_IsNewCardPresent() && mfrc522.PICC_ReadCardSerial()){
    for (byte i = 0; i < mfrc522.uid.size; i++) 
    {
        card_id.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " "));
        card_id.concat(String(mfrc522.uid.uidByte[i], HEX));
    }
    card_id.toUpperCase();
  }
  card_id.trim();
  return card_id;
}
```
## Note
I tried to make the codes of both arduino and desktop applications very clean and modular. You can contact me for the parts you cannot understand.

## Images of the Computer Interface
<img src="/Images/Interface/HomePage.png" width="40%">      <img src="/Images/Interface/OperationsPage.png" width="40%">
<img src="/Images/Interface/AddCardPage.png" width="40%">      <img src="/Images/Interface/AddProductsPage.png" width="40%">
<img src="/Images/Interface/AddFundsPage.png" width="40%">


## Database Structure
 
![Database!](/Images/database_schema.png "Database")

## Contributors
 - Emir Yusuf Topbaş <emiryusuftopbas@gmail.com>
## License & Copyright
Licensed under the [MIT License](LICENSE)


