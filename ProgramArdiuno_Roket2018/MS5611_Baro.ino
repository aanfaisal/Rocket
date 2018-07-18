void MS5611()
{
 D1 = getVal(ADDRESS, 0x48); // Pressure raw
 D2 = getVal(ADDRESS, 0x58);// Temperature raw
 dT   = D2 - ((uint64_t)C[5] << 8); // Bisa uint32_t
 OFF  = ((int64_t)C[2] << 16) + ((dT * C[4]) >> 7);
 SENS = ((int32_t)C[1] << 15) + ((dT * C[3]) >> 8);
 TEMP = (int64_t)dT * (int64_t)C[6] / 8388608 + 2000;

 if(TEMP < 2000) // if temperature lower than 20 Celsius 
 {
  int32_t T1    = 0;
  int64_t OFF1  = 0;
  int64_t SENS1 = 0;

  T1    = pow(dT, 2) / 2147483648;
  OFF1  = 5 * pow((TEMP - 2000), 2) / 2;
  SENS1 = 5 * pow((TEMP - 2000), 2) / 4;
   
  if(TEMP < -1500) // if temperature lower than -15 Celsius 
  {
   OFF1  = OFF1 + 7 * pow((TEMP + 1500), 2); 
   SENS1 = SENS1 + 11 * pow((TEMP + 1500), 2) / 2;
  }
   
  TEMP -= T1;
  OFF -= OFF1; 
  SENS -= SENS1;
 }
 
 Temperature = (float)TEMP / 100; 
 P  = ((int64_t)D1 * SENS / 2097152 - OFF) / 32768;
 Pressure = (float)P / 100; // + Pressure_Correction
 realAlt1 = getAltitude(Pressure, Temperature);
// realAlt2 = ( 1 - pow((Pressure/1013.25),0.190284)) * 145366.45 * 0.3048; // Rumus bang ridho
 realAlt2 = 44330*(1 - pow((Pressure/1013.25),0.1903));
 realAltW = realAlt1 - TempAltW; // Untuk Altitude dari aktif program dimulai
 
 /* Serial print Aslinya
 Serial.print("     Actual TEMP= ");
 Serial.print(Temperature);
 Serial.print("      Actual PRESSURE= ");
 Serial.print(Pressure);
 Serial.println();
 Serial.println();
 Serial.print("     Actual ALTITUDE= ");
 Serial.print(getAltitude(Pressure, Temperature));
 Serial.println("m");
 Serial.println();  
 Serial.print(" RAW Temp D2=  ");
 Serial.print(D2);
 Serial.print(" RAW Pressure D1=  ");
 Serial.println(D1);
 Serial.println();

//  Serial.print(" dT=  ");
//  Serial.println(dT); can't print int64_t size values
 Serial.println();
 Serial.print(" C1 = ");
 Serial.println(C[1]);
 Serial.print(" C2 = ");
 Serial.println(C[2]); 
 Serial.print(" C3 = ");
 Serial.println(C[3]); 
 Serial.print(" C4 = ");
 Serial.println(C[4]); 
 Serial.print(" C5 = ");
 Serial.println(C[5]); 
 Serial.print(" C6 = ");
 Serial.println(C[6]); 
//  Serial.print(" C7 = ");
//  Serial.println(C[7]);
 Serial.println();
 
 delay(1000);
 */
}

float getAltitude(float Pressure, float Temperature) 
{
 return ((pow((sea_press / Pressure), 1/5.257) - 1.0) * (Temperature + 273.15)) / 0.0065; // Dari rumus Hypsometric
}

long getVal(int address, byte code)
{
 unsigned long ret = 0;
 Wire.beginTransmission(address);
 Wire.write(code);
 Wire.endTransmission();
 delay(10);
 // start read sequence
 Wire.beginTransmission(address);
 Wire.write((byte) 0x00);
 Wire.endTransmission();
 Wire.beginTransmission(address);
 Wire.requestFrom(address, (int)3);
 
 if (Wire.available() >= 3)
 {
  ret = Wire.read() * (unsigned long)65536 + Wire.read() * (unsigned long)256 + Wire.read();
 }
 else 
 {
  ret = -1;
 }
 
 Wire.endTransmission();
 return ret;
}

void initial(uint8_t address)
{
 Serial.println();
 Serial.println("** Barometer MS5611 on Duty **");
 Serial.println("PROM COEFFICIENTS ivan");
 Wire.beginTransmission(address);
 Wire.write(0x1E); // reset
 Wire.endTransmission();
 delay(10);

 for (int i=0; i<6  ; i++) 
 {
  Wire.beginTransmission(address);
  Wire.write(0xA2 + (i * 2));
  Wire.endTransmission();
  Wire.beginTransmission(address);
  Wire.requestFrom(address, (uint8_t) 6);
  delay(1);

  if(Wire.available())
  {
   C[i+1] = Wire.read() << 8 | Wire.read();
  }
  else 
  {
   Serial.println("Error reading PROM 1"); // error reading the PROM or communicating with the device
  }
  Serial.println(C[i+1]);
 }
 Serial.print("** Barometer MS5611 Done **");
 Serial.println();
}

/*
  if(filtered != 0){
    filtered = filtered + 0.1*(pressure-filtered);
  }
  else {
    filtered = pressure;          // first reading so set filtered to reading
  } 
*/
