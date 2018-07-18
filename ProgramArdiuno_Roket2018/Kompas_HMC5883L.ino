void kompas()
{
 Vector norm = compass.readNormalize();

 // http://magnetic-declination.com/
 // Formula: (deg + (min / 60.0)) / (180 / M_PI);
 magX = norm.XAxis;
 magY = norm.YAxis;
 magZ = norm.ZAxis;
 float declinationAngle = (-93 + (43.0 / 60.0)) / (180 / M_PI); // Hitung sudut deklanasi kompas (setiap daerah berbeda)
 float heading = atan2(norm.YAxis, norm.XAxis); // Hitung Yaw/Heading
 heading += declinationAngle;

 if (heading < 0) // mapping jika sudut heading < 0 atau heading > 360
 {
  heading += 2 * PI;
 }
 
 if (heading > 2 * PI)
 {
  heading -= 2 * PI;
 }
 
 float headingDegrees = heading * 180/M_PI; // konversi heading ke sudut heading
 
 if (headingDegrees >= 1 && headingDegrees < 240) // Fix kompas (kadang slide di sudut 240++)
 {
  fixedHeadingDegrees = map(headingDegrees, 0, 239, 0, 179);
 } 
 else if (headingDegrees >= 240)
 {
  fixedHeadingDegrees = map(headingDegrees, 240, 360, 180, 360);
 }


 /*int smoothHeadingDegrees = round(fixedHeadingDegrees); // agar lebih smooth di GUI (tingkat presisi +-3 derajat)

 if (smoothHeadingDegrees < (previousDegree + 3) && smoothHeadingDegrees > (previousDegree - 3))
 {
  smoothHeadingDegrees = previousDegree;
 }
 previousDegree = smoothHeadingDegrees;*/

// Serial.print(fixedHeadingDegrees);  
// Serial.print(smoothHeadingDegrees);  
// delay(30);
}

