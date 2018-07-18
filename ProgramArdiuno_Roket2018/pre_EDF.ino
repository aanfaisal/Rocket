void prepareEDF()
{
  
 for (preEDF = 900; preEDF <= 1960; preEDF += 1) 
 {
//  Serial.println(preEDF);
  byPass_4();
  EDFthr.writeMicroseconds(preEDF);
  delay(7);
  char cmd = Serial.read();
   
  if (cmd == 'x') //Stop
  {
   mode = 0;
   EDFthr.writeMicroseconds(900); 
   break;
   delay(10);
  } // if x

  if ((ch4 > 1400) && (ch4 <= 1500)) // Failsafe Mode (EDF mati + Parasut terbuka)
  {
   Para.write(180); // Sudut tergantung posisi servo parasut nanti (Open Parachute)
   EDFthr.writeMicroseconds(972); // PWM tergantung titik terendah EDF (EDF off)
   mode = 9; 
   break;
  } // if ch4 2 cetek
    
  if ((ch4 <= 1700) && (ch4 >= 1600)) // Back to Manual
  {
   mode = 0; 
   EDFthr.writeMicroseconds(972);
   Serial.println("First Level");
   return;
   delay(500);
  } // if ch4 1 cetek
 
 }
}

