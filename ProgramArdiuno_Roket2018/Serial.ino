void serial() 
{    
 // Untuk Jarak 
 const double EIFFEL_TOWER_LAT = -7.644020;
 const double EIFFEL_TOWER_LNG =  107.685874;
 distanceM = gps.distanceBetween(gps.location.lat(),gps.location.lng(),EIFFEL_TOWER_LAT,EIFFEL_TOWER_LNG);
 //
 
 Serial.print("115"); // Header
 Serial.print(" ");
 Serial.print(mode); // Mode Plant (8=Launch/9=Separasi)
 Serial.print(" ");
 Serial.print(kalAngleX,0); // Roll 3D
 Serial.print(" ");
 Serial.print(kalAngleY,0); // Pitch 3D
 Serial.print(" ");
 Serial.print(fixedHeadingDegrees-71); // Yaw 3D/Heading/Kompas
 Serial.print(" ");
 printFloat(gps.location.lat(), gps.location.isValid(), 9, 6); // Lat
 Serial.print(" ");
 printFloat(gps.location.lng(), gps.location.isValid(), 10, 6); // Lon
 Serial.print(" ");
 Serial.print(ReAl,0); // Altitude dari aktif program dimulai (realAltW,0)
 Serial.print(" "); 
 Serial.print(RePr,0); // Tekanan Udara (Pressure,0)
 Serial.print(" "); 
 Serial.print(ReTe,0); // Suhu (Temperature,0)
 Serial.print(" "); 
 printFloat(gps.speed.kmph(), gps.speed.isValid(),2,0);
 Serial.print(" "); 
 Serial.print(distanceM,0); // Jarak
 
 Serial.println();
 delay(50);
}
