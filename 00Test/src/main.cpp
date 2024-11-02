/**
 * @file main.cpp
 * @brief Testfeld
 * @version 1.1
 * @date 1 Nov 29 Okt 2024
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024  B. Borys
 */
#include <Arduino.h>
#include "test.h"
/**
 * @brief
 *
 */
void setup()
{
#ifndef NDEBUG
  Serial.begin(115200L);
  while(!Serial.available()) { ; }
  Serial.readStringUntil('.');
#endif
  log_d("begin...");
  sdsetup();
  tonsetup();
  // ledsetup();
  log_d("...Setup ok");
}

void loop()
{
  tonloop();
  sdloop();
  //ledloop();
}
