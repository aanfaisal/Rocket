void rising4x()
{
 latest_interrupted_pin_4=PCintPort::arduinoPin;
 PCintPort::attachInterrupt(latest_interrupted_pin_4, &falling4, FALLING);
 prev_time_4 = micros();
}

void falling4x() {
 latest_interrupted_pin_4=PCintPort::arduinoPin;
 PCintPort::attachInterrupt(latest_interrupted_pin_4, &rising4, RISING);
 pwm_value_4 = micros()-prev_time_4;
}

void byPass_4()
{
 ch4 = pwm_value_4;
// Serial.println(ch4); 
}
