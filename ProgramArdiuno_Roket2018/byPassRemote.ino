// Rising
void rising1()
{
 latest_interrupted_pin_1=PCintPort::arduinoPin;
 PCintPort::attachInterrupt(latest_interrupted_pin_1, &falling1, FALLING);
 prev_time_1 = micros();
}
void rising2()
{
 latest_interrupted_pin_2=PCintPort::arduinoPin;
 PCintPort::attachInterrupt(latest_interrupted_pin_2, &falling2, FALLING);
 prev_time_2 = micros();
}
void rising3()
{
 latest_interrupted_pin_3=PCintPort::arduinoPin;
 PCintPort::attachInterrupt(latest_interrupted_pin_3, &falling3, FALLING);
 prev_time_3 = micros();
}
void rising4()
{
 latest_interrupted_pin_4=PCintPort::arduinoPin;
 PCintPort::attachInterrupt(latest_interrupted_pin_4, &falling4, FALLING);
 prev_time_4 = micros();
}

// Falling
void falling1() {
 latest_interrupted_pin_1=PCintPort::arduinoPin;
 PCintPort::attachInterrupt(latest_interrupted_pin_1, &rising1, RISING);
 pwm_value_1 = micros()-prev_time_1;
}
void falling2() {
 latest_interrupted_pin_2=PCintPort::arduinoPin;
 PCintPort::attachInterrupt(latest_interrupted_pin_2, &rising2, RISING);
 pwm_value_2 = micros()-prev_time_2;
}
void falling3() {
 latest_interrupted_pin_3=PCintPort::arduinoPin;
 PCintPort::attachInterrupt(latest_interrupted_pin_3, &rising3, RISING);
 pwm_value_3 = micros()-prev_time_3;
}
void falling4() {
 latest_interrupted_pin_4=PCintPort::arduinoPin;
 PCintPort::attachInterrupt(latest_interrupted_pin_4, &rising4, RISING);
 pwm_value_4 = micros()-prev_time_4;
}

void byPassRemote()
{
 ch1 = pwm_value_1;
 ch2 = pwm_value_2;
 ch3 = pwm_value_3;
 ch4 = pwm_value_4; 
 ch1RC.writeMicroseconds(ch1); // dari pin A8 ke
 ch2RC.writeMicroseconds(ch2); // dari pin A9 ke
 EDFthr.writeMicroseconds(ch3); // dari pin A10 ke
 ch4RC.writeMicroseconds(ch4); // dari pin A11 ke
 Serial.print(ch1); Serial.print(" ");
 Serial.print(ch2); Serial.print(" ");
 Serial.print(ch3); Serial.print(" ");
 Serial.println(ch4); 
}
