/**
 * @file main.cpp
 * @brief Musik und Partylicht in der Grillhütte
 * @version 1.1
 * @date 28 27 9 Okt 2024 14 4 3 2 Okt 29 26 Sep 2023
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2023-2024  B. Borys
 */
#ifdef DEBUG
#define DEBUG_PRINT(x) Serial.print(x)
#define DEBUG_PRINTLN(x) Serial.println(x)
#else
#define DEBUG_PRINT(x)
#define DEBUG_PRINTLN(x)
#endif
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
  Serial.begin(115200L);
#endif
  log_d("begin...");
  pixels.begin(); // INITIALIZE NeoPixel strip object (REQUIRED)
  pixels.setBrightness(25);
  //pixels.setPixelColor(1, pixels.Color(255, 255, 255));
  pixels.show(); // Send the updated pixel colors to the hardware.
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
  client.loop(); // für MQTT
  switch (Zustand)
  {
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
  case zu22:
    um22();
    break;
    case zuIni:
    break;
    case zuEnde:
      break;
  case zu0:
  default:
    um0();
    Zustand = zuIni;
    break;
  }
  delay(500);
}
