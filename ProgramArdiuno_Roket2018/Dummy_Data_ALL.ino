int dummy = 0; 
float a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u;

void dummydata() 
{
 for (dummy = 0; dummy <= 50; dummy += 1) 
 { 
  a = (dummy/dummy)+7; // mode
  b = dummy+1; // Roll
  c = dummy+2; // Pitch
  d = dummy+3; // Yaw
  e = dummy+4; // aX
  f = dummy+5; // aY
  g = dummy+6; // aZ
  h = dummy+7; // gX
  i = dummy+8; // gY
  j = dummy+9; // gZ
  k = dummy+10; // mX
  l = dummy+11; // mY
  m = dummy+12; // mZ
  n = -6.976943; // Lat
  o = 107.632000; // Lon
  p = dummy+1234; // Alt
  q = dummy+1.5; // Alt
  r = dummy+19090; // Pre
  s = dummy+1.2; // Suhu
  t = dummy+50; // Airspeed
  u = dummy+1200; // Thr
  Serial.print("115"); // Header
  Serial.print(" ");
  Serial.print(a,0); // Mode Plant (8=Launch/9=Separasi)
  Serial.print(" ");
  Serial.print(b,0); // Roll 3D
  Serial.print(" ");
  Serial.print(c,0); // Pitch 3D
  Serial.print(" ");
  Serial.print(d,0); // Yaw 3D/Heading/Kompas
  Serial.print(" ");
  Serial.print(e,0); // Acc X
  Serial.print(" ");
  Serial.print(f,0); // Acc Y
  Serial.print(" ");
  Serial.print(g,0); // Acc Z
  Serial.print(" ");
  Serial.print(h,0); // Gyr X
  Serial.print(" ");
  Serial.print(i,0); // Gyr Y
  Serial.print(" ");
  Serial.print(j,0); // Gyr Z
  Serial.print(" ");
  Serial.print(k,0); // Mag X
  Serial.print(" ");
  Serial.print(l,0); // Mag Y
  Serial.print(" ");
  Serial.print(m,0); // Mag Z
  Serial.print(" ");
  Serial.print(n,6); // Lat
  Serial.print(" ");
  Serial.print(o,6); // Long
  Serial.print(" ");
  Serial.print(p,0); // Altitude dari permukaan laut (realAlt1,0)
  Serial.print(" ");  
  Serial.print(q,0); // Altitude dari aktif program dimulai (realAltW,0)
  Serial.print(" "); 
  Serial.print(r,0); // Tekanan Udara (Pressure,0)
  Serial.print(" ");  
  Serial.print(s,0); // Suhu (Temperature,0)
  Serial.print(" "); 
  Serial.print(t,0); // Airspeed
  Serial.print(" "); 
  Serial.print(u,0); // Throttle
 
  Serial.println();                
 }
 
 for (dummy = 50; dummy >= 0; dummy -= 1) 
 { 
  a = (dummy/dummy)+8; // mode
  b = dummy+1; // Roll
  c = dummy+2; // Pitch
  d = dummy+3; // Yaw
  e = dummy+4; // aX
  f = dummy+5; // aY
  g = dummy+6; // aZ
  h = dummy+7; // gX
  i = dummy+8; // gY
  j = dummy+9; // gZ
  k = dummy+10; // mX
  l = dummy+11; // mY
  m = dummy+12; // mZ
  n = -6.976943; // Lat
  o = 107.632000; // Lon
  p = dummy+1234; // Alt
  q = dummy+1.5; // Alt
  r = dummy+19090; // Pre
  s = dummy+1.2; // Suhu
  t = dummy+50; // Airspeed
  u = dummy+1200; // Thr
  Serial.print("115"); // Header
  Serial.print(" ");
  Serial.print(a,0); // Mode Plant (8=Launch/9=Separasi)
  Serial.print(" ");
  Serial.print(b,0); // Roll 3D
  Serial.print(" ");
  Serial.print(c,0); // Pitch 3D
  Serial.print(" ");
  Serial.print(d,0); // Yaw 3D/Heading/Kompas
  Serial.print(" ");
  Serial.print(e,0); // Acc X
  Serial.print(" ");
  Serial.print(f,0); // Acc Y
  Serial.print(" ");
  Serial.print(g,0); // Acc Z
  Serial.print(" ");
  Serial.print(h,0); // Gyr X
  Serial.print(" ");
  Serial.print(i,0); // Gyr Y
  Serial.print(" ");
  Serial.print(j,0); // Gyr Z
  Serial.print(" ");
  Serial.print(k,0); // Mag X
  Serial.print(" ");
  Serial.print(l,0); // Mag Y
  Serial.print(" ");
  Serial.print(m,0); // Mag Z
  Serial.print(" ");
  Serial.print(n,6); // Lat
  Serial.print(" ");
  Serial.print(o,6); // Long
  Serial.print(" ");
  Serial.print(p,0); // Altitude dari permukaan laut (realAlt1,0)
  Serial.print(" ");  
  Serial.print(q,0); // Altitude dari aktif program dimulai (realAltW,0)
  Serial.print(" "); 
  Serial.print(r,0); // Tekanan Udara (Pressure,0)
  Serial.print(" ");  
  Serial.print(s,0); // Suhu (Temperature,0)
  Serial.print(" "); 
  Serial.print(t,0); // Airspeed
  Serial.print(" "); 
  Serial.print(u,0); // Throttle
 
  Serial.println();    
 }


}

