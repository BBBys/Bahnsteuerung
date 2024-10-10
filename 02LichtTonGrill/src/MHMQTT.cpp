/**
 * @file MHMqtt.cpp
 * @brief MQTT für Musikhaus
 * @version 1.1
 * @date 14 4 3 OKT 27 Sep 2023
 *
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2023 B. Borys
 */
#include "musikhaus.h"
extern Ticker Zeitgeber;
extern Adafruit_NeoPixel pixels;
extern tZustande Zustand;
/*
   ================================================================================================
   MQTT
   https://github.com/plapointe6/EspMQTTClient
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
/*
   MQTT
   ====================================================================================================
*/
/**
 * @brief MQTT-Callback
 *
 */
void onConnectionEstablished()
{
   log_d("onConnectionEstablished...");
   client.subscribe("u/zeit", [](const String &payload)
                    {
                       u_int8_t pl;
#ifndef NDEBUG                       
                       Serial.println(payload);
#endif                                              
                       pl = payload.toInt();
                       //Zwischenzeiten abfangen
                       if (pl<12)
                       {
                        /* egal */
                       }else //pl mindestens 12
                       if (pl<15)
                       {
                        pl=12;
                       }else //pl mindestens 15
                       if (pl<19)
                       {
                        pl=15;
                       }
                       switch (pl)
                       {
                       case 12:
                          Zustand = zu12;
                          break;
                       case 15:
                          Zustand = zu15;
                          break;
                       case 19:
                          Zustand = zu19;
                          break;
                       default:
                          break;
                       }
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
   client.publish("Status", "Musikhaus läuft");
} // void onConnectionEstablished()