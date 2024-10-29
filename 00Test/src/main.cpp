/**
 * @file main.cpp
 * @brief Testfeld
 * @version 1.1
 * @date 29 Okt 2024
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2023-2024  B. Borys
 */
#include <Arduino.h>
const int Tafel =PIN_DAC1, Grill=PIN_DAC2;
/**
 * @brief
 *
 */
void setup()
{
#ifndef NDEBUG
  Serial.begin(115200L);
#endif
  log_d("begin...");
  pinMode(Tafel, OUTPUT);
  pinMode(Grill,ANALOG);
}

void loop()
{
  static int hell = 20;
  
 // digitalWrite(Tafel, 1); // turn the LED on (HIGH is the voltage level)
 // analogWrite(Grill, 0); // turn the LED on (HIGH is the voltage level)
 // delay(500);             // wait for a second
 // digitalWrite(Tafel, 0); // turn the LED on (HIGH is the voltage level)
switch (random(3))
{
case 0:
  log_d("0");
  hell += 15;
  break;
case 1:
  log_d("1");
  hell -= 15;
  break;
default:log_d("2");
  break;
}
hell = min(max(hell, 15), 200);
analogWrite(Grill, hell);
delay(333);
}
