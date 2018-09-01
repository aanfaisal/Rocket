#include <TinyGPS++.h>
#include <SoftwareSerial.h>

//SoftwareSerial gpsSerial(3,4);//rx,tx 
SoftwareSerial serial_gps(3, 4); // RX = pin 3, TX = pin 4
TinyGPSPlus gps;
double latitude, longitude;
void setup() {
  Serial.begin(9600);
  serial_gps.begin(9600);
  Serial.println("GPS Mulai");
}

void loop() {
  while(serial_gps.available()) {
    gps.encode(serial_gps.read());
  }
  if(gps.location.isUpdated()) {
    latitude = gps.location.lat();
    longitude = gps.location.lng();
    String link = "http://www.google.com/maps/place/" + String(latitude) + "," + String(longitude) ;
    Serial.print("Link Google Maps : ");
    Serial.println(link);
    Serial.print("Satellite Count : ");
    Serial.println(gps.satellites.value());
    Serial.print("Latitude : ");
    Serial.println(latitude, 6);
    Serial.print("Longitude : ");
    Serial.println(longitude, 6);
    Serial.print("Speed MPH : ");
    Serial.println(gps.speed.mph());
    Serial.print("Altitude Feet : ");
    Serial.println(gps.altitude.feet());
    Serial.println("");
  }
}
