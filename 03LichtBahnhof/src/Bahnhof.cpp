/**
 * @file Bahnhof.cpp
 * @author BBB
 * @brief Beleuchtung Bahnhofsgebäude
 * @version 0.2
 * @date 7 5 4 Nov 2021
 * 
 * @copyright Copyright (c) 2021
 * 
 */
#include "Bahnhof.h"
#include <EspMQTTClient.h>
/**
 * @brief Parameter für die Lichtsteuerung
 * 
 */
    int Stunde = 12,
        Tag = 1;
int StundeAlt = Stunde;
float Temp;
/**
 * @brief Zeichen, dass Parameter geändert
 * 
 */
bool StundeNeu = false;
/**
 * @brief MQTT
 * 
 */
EspMQTTClient client(
    WLANSSID,
    WLANPWD,
    MQTTBROKERIP, // MQTT Broker server ip
    OTAUSER,      // Can be omitted if not needed
    OTAPASSWD,    // Can be omitted if not needed
    MQTTNAME,     // Client name that uniquely identify your device
    1883          // The MQTT port, default to 1883. this line can be omitted
);


// #ifndef D5
// #define D5 5
// #endif
#define LED_PIN D5                                            // Which pin on the Arduino is connected to the NeoPixels?
#define LED_COUNT nPixel                                          // How many NeoPixels are attached to the Arduino?
#define BRIGHTNESS 55                                         // NeoPixel brightness, 0 (min) to 255 (max)
Adafruit_NeoPixel strip(LED_COUNT, D5, NEO_GRB + NEO_KHZ800); // Declare our NeoPixel strip object:
cLRLicht Halle1(&strip, pxHalle1);
cLRLicht Halle2(&strip, pxHalle2);
cLRLicht Schalter(&strip, pxSchalterhalle);
cNLicht Gastst(&strip, pxGaststaette, NEOGELB);
cNLicht Wohnzimmer(&strip, pxWohnzimmer, NEOGELB);
cNLicht Kueche(&strip, pxKueche, NEOWEISS);

void setup()
{
#ifndef NDEBUG
  Serial.begin(115200);
  Serial.println("\n...setup");
#endif
  // pinMode(LED_BUILTIN, OUTPUT);
#ifdef NDEBUG
  client.enableDebuggingMessages(false);
#else  //NDEBUG
  client.enableDebuggingMessages(true);
#endif //NDEBUG
  //client.enableHTTPWebUpdater(OTAUSER, OTAPASSWD);
  client.enableLastWillMessage("Bahnhof/lastwill", "Abbruch Bahnhof"); /// LWT-Meldung
#ifndef NDEBUG
  Serial.println("Setup OK");
#endif
  strip.begin();          // INITIALIZE NeoPixel strip object (REQUIRED)
  Halle1.aus();
  Halle2.aus();
  strip.show();           // Turn OFF all pixels ASAP
  strip.setBrightness(55); // Set BRIGHTNESS to about 1/5 (max = 255)
}

void loop()
{
  client.loop();
  if (StundeNeu)
  {
    // Küche
    if (LichtSollAn(Stunde, lazKueche) && !LichtSollAn(StundeAlt, lazKueche))
    {
      Kueche.ein();
    }
    else
    {
      if (!LichtSollAn(Stunde,lazKueche) && LichtSollAn(StundeAlt,lazKueche))
      {
        Kueche.aus();
      }
    }
    //Gastwirtschaft
    if (LichtSollAn(Stunde, lazWirtschaft) && !LichtSollAn(StundeAlt, lazWirtschaft))
    {
      Gastst.ein();
          }
    else
    {
      if (!LichtSollAn(Stunde,lazWirtschaft) && LichtSollAn(StundeAlt,lazWirtschaft))
      {
        Gastst.aus();
              }
    }
    //Wohnzimmer
    if (LichtSollAn(Stunde, lazWohnzimmer) && !LichtSollAn(StundeAlt, lazWohnzimmer))
    {
      Wohnzimmer.ein();
          }
    else
    {
      if (!LichtSollAn(Stunde,lazWohnzimmer) && LichtSollAn(StundeAlt,lazWohnzimmer))
      {
        Wohnzimmer.aus();
      }
    }
    //Werkstatt
    if (LichtSollAn(Stunde, lazWerkstatt) && !LichtSollAn(StundeAlt, lazWerkstatt))
    {
      Halle1.ein();
      Halle2.ein();
    }
    else
    {
      if (!LichtSollAn(Stunde,lazWerkstatt) && LichtSollAn(StundeAlt,lazWerkstatt))
      {
        Halle1.aus(1);
        Halle2.aus(9);
              }
    }
    //Verkauf
    if (LichtSollAn(Stunde, lazVerkauf) && !LichtSollAn(StundeAlt, lazVerkauf))
    {
      Schalter.ein();
      }
    else
    {
      if (!LichtSollAn(Stunde,lazVerkauf) && LichtSollAn(StundeAlt,lazVerkauf))
      {
        Schalter.aus(5);
      }
    }
    StundeAlt = Stunde;
    StundeNeu = false;
  }

  Halle1.check();
  Halle2.check();
  Schalter.check();
  delay(100);
  strip.show();
}