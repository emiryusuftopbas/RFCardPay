#include <ArduinoJson.h>
#include <EEPROM.h>
#include <SoftwareSerial.h>
#define HC06 Serial3

#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN     5 
#define SS_PIN      53 
MFRC522 mfrc522(SS_PIN, RST_PIN); 

#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

#define SCREEN_WIDTH 128 
#define SCREEN_HEIGHT 32 

#define OLED_RESET    -1 // Reset pin # (or -1 if sharing Arduino reset pin)
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);

#include <PinButton.h>
typedef struct{
  byte id;
  char name[10];
  float price;
  char control_bit;
}Product;


String toStr(char * d){
  return String(d);
}
void EEPROMAddData(int, Product);

int EEPROMDataCount(){
    int count = 0;
    for(int i=0;i<EEPROM.length();i++){
     Product temp_product;
     EEPROM.get(i*sizeof(Product),temp_product);
     if(temp_product.control_bit == 'o'){
        count++;
     }else{
        break;
     }
  }
  return count;
}


void EEPROMAddData(int position, Product data){
  EEPROM.put(sizeof(Product)*position, data);
}

void ParseData(String json){
  const size_t capacity = JSON_ARRAY_SIZE(10) + JSON_OBJECT_SIZE(1) + 10*JSON_OBJECT_SIZE(3) + 120;
  DynamicJsonDocument doc(capacity);
  deserializeJson(doc, json);
  
  for(int i = 0; i<sizeof(doc["products"]);i++){
    JsonObject product = doc["products"][i];
    char product_name[10];

    String str_product_name = toStr(product["Name"]);
    str_product_name.toCharArray(product_name,10);

      Product product_to_be_added;
      product_to_be_added.id = (byte) product["Id"];
      strcpy(product_to_be_added.name , product_name);
      product_to_be_added.price = product["Price"];
      product_to_be_added.control_bit = 'o';
      EEPROMAddData(i, product_to_be_added);
  }
}

void ScreenInitial(){
    display.clearDisplay();
    display.setTextSize(2);
    display.setTextColor(SSD1306_WHITE);
    display.setCursor(16,0);
    display.cp437(true);
    display.println("BOZOKPAY");
    display.display();
}

void setup() {
  Serial.begin(9600);

  /* BUTTONS */ 
  pinMode(23,INPUT_PULLUP);
  pinMode(25,INPUT_PULLUP);
  pinMode(39,INPUT_PULLUP);
  /* BUTTONS */ 

 

  /* BLUETOOTH  */
  HC06.begin(9600);
  /* BLUETOOTH  */


  /* RFID SETTINGS */
  while (!Serial);
  SPI.begin();     
  mfrc522.PCD_Init();   
  delay(4);     
  mfrc522.PCD_DumpVersionToSerial();
  /* RFID SETTINGS */
  
  /* OLED SCREEN */ 
    if(!display.begin(SSD1306_SWITCHCAPVCC, 0x3C)) { 
      Serial.println(F("SSD1306 ERR"));
      for(;;); 
    }
    ScreenInitial();
  
  /* OLED SCREEN */ 
  
  int data_count = EEPROMDataCount();

  Product products[data_count];
  for(int i=0;i<data_count;i++){
    Product temp_product;
    EEPROM.get(i*sizeof(Product),temp_product);
    if(temp_product.control_bit = 'o'){
      products[i] = temp_product;
    }
  }

}

int oi = -1;
Product selectedProduct;
void ButtonClickHandler(int volt){

  int data_count = EEPROMDataCount();
  Product products[data_count];
  for(int i=0;i<data_count;i++){
    Product temp_product;
    EEPROM.get(i*sizeof(Product), temp_product);
    if(temp_product.control_bit = 'o'){
      products[i] = temp_product;
    }
  }
  
    if(oi < data_count ){
      if(volt == 1 ){
         oi++;
      }     
    }
    if(oi >= 1){
       if(volt == 0){
         oi--;
      }
    }
   if(oi >=0){
      selectedProduct = products[oi];
      Serial.println(products[oi].id);
      display.clearDisplay();
      display.setTextSize(2);
      display.setTextColor(SSD1306_WHITE);
      display.setCursor(0,0);
      display.println(products[oi].name);
      display.println("F: "+String( products[oi].price)+"TL");
      display.display(); 
   }
   
}



String ReadRfidCard(){
  String card_id= "";
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



PinButton btn_right(23);
PinButton btn_left(25);
PinButton btn_ok(39);
int lc = 0;
int response_state = 0;
void loop() {
  start:
  /*  BUTTONS */
  btn_right.update();
  btn_left.update();
  btn_ok.update();
  
  if(btn_right.isSingleClick()){
    Serial.println("btn1");
    ButtonClickHandler(0);
  }
  if(btn_left.isSingleClick()){
        Serial.println("btn2");
    ButtonClickHandler(1);
  }
  
 if (btn_ok.isLongClick()) {
      lc++;
     if(response_state == 0){
     if(lc >1){
        if(oi >= 0){
          display.clearDisplay();
          display.setTextSize(2);
          display.setTextColor(SSD1306_WHITE);
          display.setCursor(0,0);
          display.print("Put Your Card");
          display.display();
          delay(2500);
          String rfid_card_id = ReadRfidCard();
          if(rfid_card_id.length() >0 ){
             String json= "{\"id\": "+String(selectedProduct.id)+", \"price\": "+String(selectedProduct.price)+", \"rfid\":\""+rfid_card_id+"\"}";
             Serial.println(json);
             HC06.println(json);    
          }else{
            oi = -1;
            display.clearDisplay();
            display.setTextSize(2);
            display.setTextColor(SSD1306_WHITE);
            display.setCursor(0,0);
            display.print("Card Failed to Read");
            display.display();
          }       
        }
     }
     }else{
      response_state = 0;
      ScreenInitial();
     }
}
 
 if (btn_ok.isDoubleClick()) {
    display.clearDisplay();
    display.setTextSize(2);
    display.setTextColor(SSD1306_WHITE);
    display.setCursor(0,0);
    display.print("Card Being Read");
    display.display();
    delay(2800);
    String rfid_card_id = ReadRfidCard();
      if(rfid_card_id.length() >0 ){
        HC06.println(rfid_card_id);
        Serial.println(rfid_card_id);
        ScreenInitial();
      }else{
        display.clearDisplay();
        display.setTextSize(2);
        display.setTextColor(SSD1306_WHITE);
        display.setCursor(0,0);
        display.print("Card Failed to Read");
        display.display();
      }
 }
 
  /*  BUTTONS */

     

  /* BLUETOOTH */
  if(HC06.available()){
     String bluetooth_data = HC06.readStringUntil('\n');
     Serial.println(bluetooth_data);
     if(bluetooth_data == "m_transaction_successful"){
      display.clearDisplay();
      display.setTextSize(2);
      display.setTextColor(SSD1306_WHITE);
      display.setCursor(0,0);
      display.print("Successful");
      display.display();
      response_state = 1;
      oi = -1;
     }else if(bluetooth_data == "m_insufficient_balance"){
      display.clearDisplay();
      display.setTextSize(2);
      display.setTextColor(SSD1306_WHITE);
      display.setCursor(0,0);
      display.print("Insufficient Balance");
      display.display();
      response_state = 2;
      oi = -1;
     }else if(bluetooth_data == "m_card_unregistered"){
      display.clearDisplay();
      display.setTextSize(2);
      display.setTextColor(SSD1306_WHITE);
      display.setCursor(0,0);
      display.print("Card Unregistered");
      display.display();
      response_state = 3;
      oi = -1;
     }else{
         ParseData(bluetooth_data);
     }  
  }  
  /* BLUETOOTH */

  
}
