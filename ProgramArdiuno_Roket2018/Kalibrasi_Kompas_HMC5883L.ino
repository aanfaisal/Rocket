void kalib_kompas()
{
 Vector mag = compass.readRaw();
 if (mag.XAxis < minX) minX = mag.XAxis;
 if (mag.XAxis > maxX) maxX = mag.XAxis;
 if (mag.YAxis < minY) minY = mag.YAxis;
 if (mag.YAxis > maxY) maxY = mag.YAxis;
 offX = (maxX + minX)/2;
 offY = (maxY + minY)/2;

// Serial.print(mag.XAxis);
// Serial.print(":");
// Serial.print(mag.YAxis);
// Serial.print(":");
// Serial.print(minX);
// Serial.print(":");
// Serial.print(maxX);
// Serial.print(":");
// Serial.print(minY);
// Serial.print(":");
// Serial.print(maxY);
// Serial.print(":");
 Serial.print(offX);
 Serial.print(" ");
 Serial.print(offY);
 Serial.println();
}
