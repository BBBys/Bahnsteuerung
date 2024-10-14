/**
 * @file MHMqtt.cpp
 * @brief MQTT für Bahnhof
 * @version 1.1
 * @date 10 OKT 2024
 *
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024 B. Borys
 */
#include "bahnhof.h"
#include "uhr.h"
#include <Ticker.h>
#include <Adafruit_NeoPixel.h>
#include <EspMQTTClient.h>
extern Uhr uhr;
extern Ticker Zeitgeber;
extern Adafruit_NeoPixel pixels;
extern tZustande Zustand;
#ifdef MQTTein
// https://github.com/plapointe6/EspMQTTClient
EspMQTTClient client(
    WLANSSID,
    WLANPWD,
    MQTTBROKERIP, // MQTT Broker server ip
    OTAUSER,      // Can be omitted if not needed
    OTAPASSWD,    // Can be omitted if not needed
    MQTTNAME,     // Client name that uniquely identify your device
    1883          // The MQTT port, default to 1883. this line can be omitted
);
/*
   MQTT
   ====================================================================================================
*/
/**
 * @brief MQTT-Callback
 * Topics:
 * uhr/zeit Stundenwechsel
 */
void onConnectionEstablished()
{
   log_d("onConnectionEstablished...");
   client.subscribe("uhr/zeit", [](const String &payload)
                    {
                       u_int8_t pl;
#ifndef NDEBUG                       
                       Serial.println(payload);
#endif                                              
                       pl = payload.toInt();
                       uhr.stellen(pl);
                       // Anzeigen();
                    });
   // client.subscribe("Temp/Aussen", [](const String &payload)
   //                  {
   //                    //Serial.println(payload);
   //                    TempA = payload.toDouble();
   //                    //Serial.println(TempA);
   //                    Anzeigen();
   //                  });
   /**
       * @brief 
       * 
       */
   client.publish("SWDatum", __DATE__);
   client.publish("OTA-Usr", OTAUSER);
   client.publish("OTA-Pwd", OTAPASSWD);
   client.publish("Status", "Bahnhof läuft");
} // void onConnectionEstablished()
#endif
