/**
 * @file main.cpp
 * @brief Musik und Partylicht in der Grillhütte
 * @version 1.1
 * @date 9 Okt 2024 14 4 3 2 Okt 29 26 Sep 2023
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2023-2024  B. Borys
 */
#include <Arduino.h>
#include "Musikhaus.h"
extern EspMQTTClient client;
tZustande Zustand = zuNull, Unterzst = zuNull;
extern Adafruit_NeoPixel pixels;
/**
 * @brief 
 * 
 */
void setup()
{
#ifndef NDEBUG
  Serial.begin(115200);
#endif
  log_d("begin...");
  pixels.begin(); // INITIALIZE NeoPixel strip object (REQUIRED)
  pixels.setBrightness(25);
  log_d("Neopixel Setup...fertig");
  delay(500);
/// MQTT
#ifdef NDEBUG
  client.enableDebuggingMessages(false);
#else
  client.enableDebuggingMessages(true);
#endif
  client.enableHTTPWebUpdater("/");
  client.enableLastWillMessage("Musikhaus/lastwill", "Abbruch Musikhaus"); /// LWT-Meldung
  log_d("MQTT---Init OK");
  Zustand = zuIni;
}

void loop()
{
  client.loop();  //für MQTT
  switch (Zustand)
  {
  case zuIni:
    break;
  case zu12:
    um12();
    break;
  case zu121:
    um121();
    break;
  case zu15:
    um15();
    break;
  case zu151:
    um151();
    break;
  case zu19:
    um19();
    break;
  case zu191:
    um191();
    break;
  default:
    break;
  }
  delay(500);
}
