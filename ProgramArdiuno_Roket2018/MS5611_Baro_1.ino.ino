void checkSettings()
{
  Serial.print("Oversampling: ");
  Serial.println(ms5611.getOversampling());
}

void MS5611_1()
{
 uint32_t rawTemp = ms5611.readRawTemperature(); // Raw Temperatur
 uint32_t rawPressure = ms5611.readRawPressure(); // Raw Tekanan
 double realTemperature = ms5611.readTemperature(); // Real Temperatur
 long realPressure = ms5611.readPressure(); // Real Tekanan
 float absoluteAltitude = ms5611.getAltitude(realPressure); // Ketinggian dari permukaan laut
 float relativeAltitude = ms5611.getAltitude(realPressure, referencePressure); // Ketinggian dari sistem aktif
 
 AbAl = absoluteAltitude/10; // Ketinggian dari permukaan laut
 ReAl = relativeAltitude; // Ketinggian dari sistem aktif
 ReTe = realTemperature; // Real Temperatur
 RePr = realPressure; // Real Tekanan
  /*
  Serial.println("--");

  Serial.print(" rawTemp = ");
  Serial.print(rawTemp);
  Serial.print(", realTemp = ");
  Serial.print(realTemperature);
  Serial.println(" *C");

  Serial.print(" rawPressure = ");
  Serial.print(rawPressure);
  Serial.print(", realPressure = ");
  Serial.print(realPressure);
  Serial.println(" Pa");

  Serial.print(" absoluteAltitude = ");
  Serial.print(absoluteAltitude);
  Serial.print(" m, relativeAltitude = ");
  Serial.print(relativeAltitude);    
  Serial.println(" m");

  delay(1000);
  */
}
