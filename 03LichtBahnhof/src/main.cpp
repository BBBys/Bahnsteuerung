/**
 * @file main.cpp
 * @brief Licht, Ton und Anzeige am Bahnhof
 * @version 1.1
 * @date 16 14 10 Okt 2024 
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024  B. Borys
 */
#include <Arduino.h>
#include <EspMQTTClient.h>
#include <Adafruit_NeoPixel.h>
#include <uhr.h>
#include "bahnhof.h"
#include "licht.h"
extern EspMQTTClient client;
Lichter alleLichter;
tZustande Zustand = zuNull, Unterzst = zuNull;
extern Adafruit_NeoPixel pixels;
//Adafruit_SSD1306 display;
extern Uhr uhr;
/**
 * @brief
 *
 */
void setup()
{
#ifndef NDEBUG
  Serial.begin(115200);
#endif
  Uhr *uhr=new Uhr( 31);
  log_d("begin...");
  #ifdef neop
  pixels.begin(); // INITIALIZE NeoPixel strip object (REQUIRED)
  pixels.setBrightness(25);
  log_d("Neopixel Setup...fertig");
  #endif
  delay(500);
#ifdef MQTTein
/// MQTT ------------------------------------------------------------
#ifdef NDEBUG
  client.enableDebuggingMessages(false);
#else
  client.enableDebuggingMessages(true);
#endif
  client.enableHTTPWebUpdater("/");
  client.enableLastWillMessage(
    "MQTTNAME/lastwill", 
    "Abbruch Bahnhof"); /// LWT-Meldung
  log_d("MQTT---Init OK");
#endif
  Zustand = zuIni;
  Zustand = zuIni;
}

void loop()
{
#ifdef MQTTein
  client.loop();  //für MQTT
#endif
  uhr.loop();
  alleLichter.Loop();
  switch (Zustand)
  {
  default:
    break;
  }
  delay(500);
}
