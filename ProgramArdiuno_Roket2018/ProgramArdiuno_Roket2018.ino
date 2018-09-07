#include <Adafruit_CircuitPlayground.h>
#include <Adafruit_Circuit_Playground.h>

// Copyright UNWAHAS
// Author @AANFAISAL

// 1 (Ambil Data Sensor)
//    -> 8 Launch (Data + Servo Launcher + EDF 0 - 100%)
//    -> 9 Failsafe (Separasi Parasut + EDF 0%)
// d (Dummy Data)
// k (Kalibrasi Kompas)
// t (TES EDF)
//    -> Dimulai dari ` - akhir 0 (0% - 100%)


/*-------------------------------------Referensi------------------------------*/
// Barometer  :
//    http://www.mapcoordinates.net/en
//    http://keisan.casio.com/exec/system/1224585971
// Kompas :
//    http://magnetic-declination.com/
/*=====================================Referensi==============================*/

int ubahmode = 0;
unsigned long currentMillis = 0;
long previousMillis = 0;        // will store last time LED was updated
long interval = 11000;

#include <Wire.h>

/*----------------------------------GPS--------------------------*/
#include <TinyGPS++.h>
TinyGPSPlus gps;
double distanceM;
/*==================================GPS==========================*/

/*----------------------------------MPU DATA--------------------------*/
#include <MPU6050.h>
MPU6050 mpu;
#include "Kalman.h"
#define RESTRICT_PITCH
Kalman kalmanX;
Kalman kalmanY;

double accX, accY, accZ;
double gyroX, gyroY, gyroZ;
int16_t tempRaw;
double gyroXangle, gyroYangle;
double compAngleX, compAngleY;
double kalAngleX, kalAngleY;
uint32_t timer;
uint8_t i2cData[14];
/*==================================MPU DATA==========================*/

/*----------------------------------ByPass Remote--------------------------*/
#include <PinChangeInt.h>
#define InCh1 A8 //  Aileron (Dari Receiver)
#define InCh2 A9 //  Elevator (Dari Receiver)
#define InCh3 A10 //  Throttle (Dari Receiver)
#define InCh4 A11 //  Mode (Dari Receiver)

#define MY_PIN A15 // we could choose any pin
volatile int pwm_value = 0;
volatile int prev_time = 0;
uint8_t latest_interrupted_pin;

uint8_t latest_interrupted_pin_1, latest_interrupted_pin_2, latest_interrupted_pin_3, latest_interrupted_pin_4;
int ch1, ch2, ch3, ch4;
volatile int pwm_value_1 = 0, pwm_value_2 = 0, pwm_value_3 = 0, pwm_value_4 = 0;
volatile int prev_time_1 = 0, prev_time_2 = 0, prev_time_3 = 0, prev_time_4 = 0;
/*==================================ByPass Remote==========================*/

/*----------------------------------Mode--------------------------*/
int mode = 0;
/*==================================Mode==========================*/

/*----------------------------------Servo--------------------------*/
#include <Servo.h>
Servo EDFthr, EleA, EleB; // EDF/Throttle, Elevator A, Elevator B (Bypass)
Servo Para; // Parasut
Servo ch1RC, ch2RC, ch3RC, ch4RC; // Ail, Ele, Thr, Mode (Bypass)

int EDF, preEDF;
/*==================================Servo==========================*/

/*----------------------------------BAROMETER (MS5611)(1)--------------------------*/
#define ADDRESS 0x77 // Alamat I2C barometer nya, Bisa 0x76 cek I2C Scanner program

uint32_t D1 = 0, D2 = 0;
int64_t dT = 0, OFF = 0, SENS = 0;
int32_t TEMP = 0, P = 0;
uint16_t C[7];
float Temperature, Pressure, realAlt1, realAlt2, realAltW, TempAltW;
const float sea_press = 1013.25; // Konstan tekanan air laut (mbar)
/*==================================BAROMETER (MS5611)(1)==========================*/

/*----------------------------------BAROMETER (MS5611)(2)--------------------------*/
#include <MS5611.h>
MS5611 ms5611;

float AbAl; // Ketinggian dari permukaan laut
float ReAl; // Ketinggian dari sistem aktif
double ReTe; // Real Temperatur
float RePr; // Real Tekanan
double referencePressure;
/*==================================BAROMETER (MS5611)(2)==========================*/

/*----------------------------------COMPASS (HMC5883L)--------------------------*/
#include <HMC5883L.h>
HMC5883L compass;

int fixedHeadingDegrees;
int previousDegree;
int minX = 0; // Kalibrasi Kompas
int maxX = 0;
int minY = 0;
int maxY = 0;
int offX = 0;
int offY = 0; // Kalibrasi Kompas
int magX = 0;
int magY = 0;
int magZ = 0;
/*==================================COMPASS (HMC5883L)==========================*/

void setup()
{
  Wire.begin();
  Serial.begin(57600);
  Serial2.begin(9600);

  /* // BAROMETER (MS5611)1
    PORTC |= (1 << 4);
    PORTC |= (1 << 5);
    delay(100);
    initial(ADDRESS);
    MS5611();
    delay(1000);
    TempAltW = realAlt1;
    // BAROMETER (MS5611)1 end */

  // MPU DATA
  TWBR = ((F_CPU / 400000L) - 16) / 2; // Set I2C frequency to 400kHz

  i2cData[0] = 7; // Set the sample rate to 1000Hz - 8kHz/(7+1) = 1000Hz
  i2cData[1] = 0x00; // Disable FSYNC and set 260 Hz Acc filtering, 256 Hz Gyro filtering, 8 KHz sampling
  i2cData[2] = 0x00; // Set Gyro Full Scale Range to ±250deg/s
  i2cData[3] = 0x00; // Set Accelerometer Full Scale Range to ±2g
  while (i2cWrite(0x19, i2cData, 4, false)); // Write to all four registers at once
  while (i2cWrite(0x6B, 0x01, true)); // PLL with X axis gyroscope reference and disable sleep mode

  while (i2cRead(0x75, i2cData, 1));
  if (i2cData[0] != 0x68) { // Read "WHO_AM_I" register
    Serial.print(F("Error reading sensor"));
    while (1);
  }

  delay(100); // Wait for sensor to stabilize

  /* Set kalman and gyro starting angle */
  while (i2cRead(0x3B, i2cData, 6));
  accX = (i2cData[0] << 8) | i2cData[1];
  accY = (i2cData[2] << 8) | i2cData[3];
  accZ = (i2cData[4] << 8) | i2cData[5];

  // Source: http://www.freescale.com/files/sensors/doc/app_note/AN3461.pdf eq. 25 and eq. 26
  // atan2 outputs the value of -π to π (radians) - see http://en.wikipedia.org/wiki/Atan2
  // It is then converted from radians to degrees
#ifdef RESTRICT_PITCH // Eq. 25 and 26
  double roll  = atan2(accY, accZ) * RAD_TO_DEG;
  double pitch = atan(-accX / sqrt(accY * accY + accZ * accZ)) * RAD_TO_DEG;
#else // Eq. 28 and 29
  double roll  = atan(accY / sqrt(accX * accX + accZ * accZ)) * RAD_TO_DEG;
  double pitch = atan2(-accX, accZ) * RAD_TO_DEG;
#endif

  kalmanX.setAngle(roll); // Set starting angle
  kalmanY.setAngle(pitch);
  gyroXangle = roll;
  gyroYangle = pitch;
  compAngleX = roll;
  compAngleY = pitch;

  timer = micros();
  // MPU DATA end

  // BYPASS REMOTE
  pinMode(InCh1, INPUT); digitalWrite(InCh1, HIGH);
  pinMode(InCh2, INPUT); digitalWrite(InCh2, HIGH);
  pinMode(InCh3, INPUT); digitalWrite(InCh3, HIGH);
  pinMode(InCh4, INPUT); digitalWrite(InCh4, HIGH);
  pinMode(MY_PIN, INPUT); digitalWrite(MY_PIN, HIGH);

  PCintPort::attachInterrupt(MY_PIN, &rising, RISING);
  PCintPort::attachInterrupt(InCh1, &rising1, RISING);
  PCintPort::attachInterrupt(InCh2, &rising2, RISING);
  PCintPort::attachInterrupt(InCh3, &rising3, RISING);
  PCintPort::attachInterrupt(InCh4, &rising4, RISING);
  // BYPASS REMOTE end

  // SERVO
  // EDFthr.attach(46); // EDF
  EleA.attach(45); // Aktuator Elevon A
  EleB.attach(44); // Aktuator Elevon B
  Para.attach(2); // Parachute
  ch1RC.attach(11); // Elevon RC ke APM
  ch2RC.attach(10); // Elevon RC ke APM
  EDFthr.attach(9); // Throttle RC ke APM
  ch4RC.attach(8); // Mode RC ke APM

  // SERVO end

  // BAROMETER (MS5611)2
  Serial.println("Initialize MS5611 Sensor");
  while (!ms5611.begin())
  {
    Serial.println("Could not find a valid MS5611 sensor, check wiring!");
    delay(500);
  }

  referencePressure = ms5611.readPressure();
  checkSettings();
  // BAROMETER (MS5611)2 end

  // KOMPAS (HMC5883L)
  mpu.setI2CMasterModeEnabled(false);
  mpu.setI2CBypassEnabled(true);
  mpu.setSleepEnabled(false);

  while (!compass.begin())
  {
    delay(500);
  }

  compass.setRange(HMC5883L_RANGE_1_3GA); // Set measurement range
  compass.setMeasurementMode(HMC5883L_CONTINOUS); // Set measurement mode
  compass.setDataRate(HMC5883L_DATARATE_30HZ); // Set data rate
  compass.setSamples(HMC5883L_SAMPLES_8); // Set number of samples averaged
  compass.setOffset(13, 0); // OFFSET bisa berbeda, cek Kalibrasi_Kompas_HMC5883L
  // KOMPAS (HMC5883L) end

  // INFO
  // Serial.print("Temporary Alt: "); Serial.println(TempAltW); // Kalo Pake MS5611()
  Serial.println();
  // INFO end
}

void loop()
{
  ubahmode = 0;
  byPassRemote(); // Untuk kendali manual jika terjadi hal yang diluar kendali FC
  Para.writeMicroseconds(900); // Sudut tergantung posisi servo parasut nanti (Must be Ready to Fly)
  ch4RC.writeMicroseconds(1808); // PWM Mode Manual

  if ((ch4 > 1300) && (ch4 <= 1400)) // (Failsafe Remote, Parasut & EDF)
  {
    while ((ch4 > 1300) && (ch4 <= 1400)) // (Failsafe Remote, Parasut & EDF)
    {
      mode = 9;
      ubahmode = 0;
      ch4RC.writeMicroseconds(1808); // PWM Mode Manual
      Para.writeMicroseconds(2000); // Sudut tergantung posisi servo parasut nanti (Open Parachute)
      EDFthr.writeMicroseconds(972); // PWM tergantung titik terendah EDF (EDF off)
      Serial.println("Failsafe");
      byPass_4();
    } // while ch4 cetek 3
  } // if ch4 cetek 3

  if (Serial.available() > 0) // Baca karakter input di serial
  {
    char cmd = Serial.read();
    mode = 0; // No Mode
    ubahmode = 0;

    if (cmd == '1') // Ambil Data Sensor
    {
      EDFthr.writeMicroseconds(972); // EDF Mati sewaktu ambil data
      mode = 1; // Data Modes
//      ch1RC.writeMicroseconds(1100);
//      ch2RC.writeMicroseconds(1800);      
      ch4RC.writeMicroseconds(1650); // Stabilize (1650) Manual (1808)
      while (cmd == '1')
      {
        byPass_4();
        MPU_data(); // Data Gyro dan Acc
        MS5611_1(); // Kalkulasi Barometer (Suhu,Tekanan,Ketinggian)
        kompas(); // Kompas
        serial(); // Tampilkan ke serial  
        int kanan = map(kalAngleY,0,180,1000,2024);
        int kiri = map(kalAngleY,0,180,2024,1000);
        ch1RC.writeMicroseconds(kanan);
        ch2RC.writeMicroseconds(kiri);
//          byPassRemote();
        
        char cmd = Serial.read();

        if ((cmd == '8') && (distanceM <= 204)) // Launch Mode pikirkan baik2
        {
//          prepareEDF(); // naikan PWM EDF bertahap FIX 7 detik.
//          delay(2000); // Delay untuk menahan Roket agar torsi terbuang
          mode = 8;
          ubahmode = 1;
        } // if 8

        if (ubahmode == 1) // Untuk mode ke APM
        {
          currentMillis = millis();

          if (currentMillis - previousMillis > interval)
          {
            previousMillis = millis();
          }
          
          if (((currentMillis - previousMillis) / 1000) ==  1) // 1 detik (dari 0)
          {
            EDFthr.writeMicroseconds(1168); // 25%
          }          
          else if (((currentMillis - previousMillis) / 1000) == 3) // 3 detik (dari 0)
          {
            EDFthr.writeMicroseconds(1462); // 50%
          }
          else if (((currentMillis - previousMillis) / 1000) == 5) // 5 detik (dari 0)
          {
            EDFthr.writeMicroseconds(1960); // 100%
          }          
          else if (((currentMillis - previousMillis) / 1000) == 8) // 8 detik (dari 0)
          {
            ch4RC.writeMicroseconds(1280); // Mode AUTO di APM
          }
          else if (((currentMillis - previousMillis) / 1000) == 10) // biar gak ngeloop
          {
            EDFthr.writeMicroseconds(1960);
            ubahmode = 0;
          }
          Serial.println((currentMillis - previousMillis) / 1000);
        }

        if (distanceM > 205)
        {
          ch4RC.writeMicroseconds(1808); // PWM Mode Manual
          Para.writeMicroseconds(2000); // Sudut tergantung posisi servo parasut nanti (Open Parachute)
          EDFthr.writeMicroseconds(972); // PWM tergantung titik terendah EDF (EDF off)
          mode = 9;
          ubahmode = 0;         
        }
        
        if (cmd == '9') // Failsafe Mode (EDF mati + Parasut terbuka)
        {
          ch4RC.writeMicroseconds(1808); // PWM Mode Manual
          Para.writeMicroseconds(2000); // Sudut tergantung posisi servo parasut nanti (Open Parachute)
          EDFthr.writeMicroseconds(972); // PWM tergantung titik terendah EDF (EDF off)
          mode = 9;
          ubahmode = 0;
        } // if 9

        if ((ch4 > 1400) && (ch4 <= 1500)) // Failsafe Mode (EDF mati + Parasut terbuka)
        {
          ch4RC.writeMicroseconds(1808); // PWM Mode Manual
          Para.writeMicroseconds(2000); // Sudut tergantung posisi servo parasut nanti (Open Parachute)
          EDFthr.writeMicroseconds(972); // PWM tergantung titik terendah EDF (EDF off)
          mode = 9;
          ubahmode = 0;
        } // if ch4 2 cetek

        if ((ch4 <= 1700) && (ch4 >= 1600)) // Back to Manual
        {
          mode = 0;
          ch4RC.writeMicroseconds(1808); // PWM Mode Manual
          EDFthr.writeMicroseconds(972);
          ubahmode = 0;
          Serial.println("First Level");
          return;
          delay(500);
        } // if ch4 1 cetek

        if (cmd == 'x') //Stop
        {
          ubahmode = 0;
          mode = 0;
          EDFthr.writeMicroseconds(972);
          Serial.println("First Level");
          return;
          delay(500);
        } // if x
      } // while 1
    } // if 1

    else if (cmd == 'k') // Kalibrasi Kompas
    {
      while (cmd == 'k')
      {
        kalib_kompas();
        char cmd = Serial.read();

        if (cmd == 'x') //Stop
        {
          EDFthr.writeMicroseconds(972);
          Serial.println("First Level");
          return;
          delay(500);
        } // if x
      } // while k
    } // if k

    else if (cmd == 'd') // Dummy Data untuk GUI
    {
      while (cmd == 'd')
      {
        dummydata();
        char cmd = Serial.read();

        if (cmd == 'x') //Stop
        {
          EDFthr.writeMicroseconds(972);
          Serial.println("First Level");
          return;
          delay(500);
        } // if x
      } // while d
    } // if d

    else if (cmd == 't')
    {
      Serial.println("MODE TES EDF AKTIF");

      while (cmd == 't') // HATI - HATI !!! Mode TES EDF AKTIF
      {
        char cmd = Serial.read();
        byPass_4();

        if ((ch4 <= 1700) && (ch4 >= 1600)) // Back to Manual
        {
          mode = 0;
          EDFthr.writeMicroseconds(972);
          Serial.println("First Level");
          return;
          delay(500);
        } // if ch4 1 cetek

        if (cmd == '`') // 0%
        {
          EDFthr.writeMicroseconds(972);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 0%");
          char cmd = Serial.read();
        } // if `

        if (cmd == '1') // 10%
        {
          EDFthr.writeMicroseconds(1070);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 10%");
          char cmd = Serial.read();
        } // if 1

        if (cmd == '2') // 20%
        {
          EDFthr.writeMicroseconds(1168);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 20%");
          char cmd = Serial.read();
        } // if 2

        if (cmd == '3') // 30%
        {
          EDFthr.writeMicroseconds(1266);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 30%");
          char cmd = Serial.read();
        } // if 3

        if (cmd == '4') // 40%
        {
          EDFthr.writeMicroseconds(1364);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 40%");
          char cmd = Serial.read();
        } // if 4

        if (cmd == '5') // 50%
        {
          EDFthr.writeMicroseconds(1462);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 50%");
          char cmd = Serial.read();
        } // if 5

        if (cmd == '6') // 60%
        {
          EDFthr.writeMicroseconds(1560);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 60%");
          char cmd = Serial.read();
        } // if 6

        if (cmd == '7') // 70%
        {
          EDFthr.writeMicroseconds(1658);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 70%");
          char cmd = Serial.read();
        } // if 7

        if (cmd == '8') // 80%
        {
          EDFthr.writeMicroseconds(1952);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 80%");
          char cmd = Serial.read();
        } // if 8

        if (cmd == '9') // 90%
        {
          EDFthr.writeMicroseconds(2000);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 90%");
          char cmd = Serial.read();
        } // if 9

        if (cmd == '0') // 100%
        {
          EDFthr.writeMicroseconds(2100);
          EDF = EDFthr.readMicroseconds();
          Serial.print(EDF);
          Serial.println(" 100%");
          char cmd = Serial.read();
        } // if 0

        if (cmd == 'x') //Stop
        {
          EDFthr.writeMicroseconds(972);
          Serial.println("0%");
          Serial.println("First Level");
          return;
          delay(500);
        } // if x
      } // while t
    } // if t



  } // serial available
} // void loop

static void smartDelay(unsigned long ms)
{
  unsigned long start = millis();
  do
  {
    while (Serial2.available())
      gps.encode(Serial2.read());
  } while (millis() - start < ms);
}

static void printFloat(float val, bool valid, int len, int prec)
{
  if (!valid)
  {
    while (len-- > 1)
      Serial.print('*');
    Serial.print(' ');
  }
  else
  {
    Serial.print(val, prec);
    int vi = abs((int)val);
    int flen = prec + (val < 0.0 ? 2 : 1); // . and -
    flen += vi >= 1000 ? 4 : vi >= 100 ? 3 : vi >= 10 ? 2 : 1;
    for (int i = flen; i < len; ++i)
      Serial.print(' ');
  }
  smartDelay(0);
}
