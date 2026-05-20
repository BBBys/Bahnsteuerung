/**
 * @file BhfMQTT.cpp
 * @author BBB
 * @brief MQTT-Funktionen für Bahnhof-Beleuchtung
 * @version 0.1
 * @date 5 Nov 2021
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
extern int Stunde,Tag ;
extern int StundeAlt;
extern float Temp;
/**
 * @brief Zeichen, dass Parameter geändert
 * 
 */
extern bool StundeNeu;
/**
 * @brief 
 * 
 */
extern EspMQTTClient client;
void onConnectionEstablished()
{
#ifndef NDEBUG
    Serial.println("onConnectionEstablished");
#endif
    client.subscribe("Zeit/Stunde", [](const String &payload)
                     {
                         Stunde = payload.toInt();
                         Serial.printf("StundeAlt=%d Neu=%d\n", StundeAlt, Stunde);
                         StundeNeu = StundeAlt != Stunde;
                     });
    client.subscribe("Zeit/Tag", [](const String &payload)
                     { Tag = payload.toInt(); });
    client.subscribe("Temp/Aussen", [](const String &payload)
                     { Temp = payload.toFloat(); });
    client.publish("SWVersion", VERSION);
    client.publish("SWDatum", __DATE__);
    client.publish("OTA-Usr", OTAUSER);
    client.publish("OTA-Pwd", OTAPASSWD);
    client.publish("Status", "Bahnhof läuft");
    client.publish("Abfrage", "jetzt");
#ifndef NDEBUG
    Serial.println("... onConnectionEstablished return");
#endif
} //void onConnectionEstablished()
