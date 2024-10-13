/**
 * @file main.cpp
 * @brief Licht und Effekte an der Burg
 * @version 1.0
 * @date 8 Okt 2024
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024 B. Borys
 */ 
#include<Arduino.h>
#include "Licht.h"

#include <EspMQTTClient.h>
extern EspMQTTClient client;

/// @brief wann wird weitergeschaltet
/// @param zeit in Sekunden
/// @return 
unsigned long Weiter(unsigned long zeit)
{
  return millis() + 1000L * zeit;
}
const int SENSOR = A4;///Helligkeit
const int TURM1 = 13;///rotes Blinklicht auf dem Turm
const int TURM2 = 12;
const int TURMAN = 5000;
const int TURMAUS = 777;
const int INNEN = 3; /// diverse Beleuchtung in und an der Burg
const int FRONT = 4;
const int BODEN = 5;
const int AUGEN1 = 7;///Augen im Turmfenster
const int AUGEN2 = 8;
const unsigned long NORMALZEIT = 60 * 1000L;
const unsigned long DUNKELZEIT = 30 * 1000L;
enum Stat ///Zeitlicher Ablauf
{
  start,
  normal,
  stAus,
  dunkel1,
  dunkel2,
  dunkel3
} stat;
unsigned long wechsel = 0;
bool tag = true, dunkel = true;
Licht *innen, *front, *boden;
BLicht *turm1, *turm2, *augen1, *augen2;

/// @brief 
void setup()
{
  stat = start;
  augen2 = new BLicht(AUGEN2, 10000, 200);
  augen1 = new BLicht(AUGEN1, 11000, 250);
  boden = new Licht(BODEN);
  innen = new Licht(INNEN);
  front = new Licht(FRONT);
  turm1 = new BLicht(TURM1, TURMAN - 33, TURMAUS);
  turm2 = new BLicht(TURM2, TURMAN + 33, TURMAUS);
  randomSeed(analogRead(0));
  /// MQTT
#ifdef NDEBUG
  client.enableDebuggingMessages(false);
#else
  client.enableDebuggingMessages(true);
#endif
  client.enableHTTPWebUpdater("/");
  client.enableLastWillMessage("Burg/lastwill", "Abbruch Burg"); /// LWT-Meldung
  log_d("MQTT---Init OK");
}

void loop()
{
  /// Tag oder Nacht laut LDR
  int sensorValue;
  client.loop(); // für MQTT

  sensorValue = analogRead(SENSOR);
  tag = (sensorValue > 600);
  dunkel = (sensorValue < 700);

  turm1->check();
  turm2->check();
  augen1->check();
  augen2->check();
  
  if (!dunkel)/// wenn es nicht dunkel ist bleiben die Blinklichter auf dem Turm aus
  {
    turm1->blinken(false);
    turm2->blinken(false);
  }
  if (tag)/// am Tag ist alles Licht aus
  {
    stat = start;
    augen2->blinken(false);
    augen1->blinken(false);
    boden->aus();
    innen->aus();
    front->aus();
  }
  else
  {
    switch (stat)///wenn es nicht Tag ist passiert verschiedenes
    {
    case start:///zuerst Beleuchtung ein, nur die Augen in den Fenstern bleiben zu
      turm2->blinken(true);
      turm1->blinken(true);
      augen1->blinken(false);
      delay(2000);
      augen2->blinken(false);
      delay(3000);
      innen->ein();
      delay(500);
      front->ein();
      delay(2000);
      boden->ein();
      ///nach der Vorbereitung geht es normal weiter
      /// aber nach 60 Sek passiert etwas
      stat = normal;
      wechsel = millis() + NORMALZEIT;
      break;
    case normal:
      if (millis() > wechsel)
        ///jetzt passiert etwas
        stat = stAus;
      break;
    case stAus:
      ///das Licht flackert und in einem Fenster erscheinen Augen
      innen->aus();
      delay(333);
      front->aus();
      delay(222);
      boden->aus();
      innen->ein();
      delay(222);
      innen->aus();
      front->ein();
      delay(100);
      front->aus();
      augen1->blinken(true);
      delay(222);
      ///nach 30 Sek geht es weiter
      stat = dunkel1;
      wechsel = millis() + DUNKELZEIT;
      break;
    case dunkel1:
      if (millis() > wechsel)
      {
        ///wenn die 30 Sek vorbei sind geht alles durcheinander
        augen2->blinken(true);
        for (int i = 0; i < random(3, 7); i++)
        {
          boden->ein();
          augen1->check();
          augen2->check();
          delay(random(50, 777));
          boden->aus();
          augen1->check();
          augen2->check();
          delay(700);
          augen1->blinken(true);
          innen->ein();
          augen1->check();
          augen2->check();
          delay(random(50, 666));
          innen->aus();
          augen1->check();
          augen2->check();
          delay(460);
          boden->ein();
          augen1->check();
          augen2->check();
          delay(random(50, 555));
          boden->aus();
          augen1->check();
          augen2->check();
          delay(340);
          augen1->check();
          augen2->check();
          augen1->blinken(false);
          front->ein();
          augen1->check();
          augen2->check();
          delay(random(50, 444));
          front->aus();
          augen1->check();
          augen2->check();
          delay(225);
          boden->ein();
          augen1->check();
          augen2->check();
          delay(random(50, 333));
          boden->aus();
          augen1->check();
          augen2->check();
          delay(150);
          innen->ein();
          augen1->check();
          augen2->check();
          delay(random(50, 222));
          innen->aus();
          augen1->check();
          augen2->check();
          delay(100);
          augen1->check();
          augen2->check();
        }
        ///30 Sekunden lang
        wechsel = millis() + DUNKELZEIT;
        stat = dunkel2;
      } /*if millis>wechsel*/
      break;
    case dunkel2:
      turm1->blinken(false);
      turm2->blinken(false);
      if (millis() > wechsel)
      {
        augen2->blinken(true);
        boden->ein();
        augen1->check();
        augen2->check();
        delay(50);
        boden->aus();
        augen1->check();
        augen2->check();
        delay(random(50, 150));
        boden->ein();
        augen1->check();
        augen2->check();
        delay(50);
        boden->aus();
        augen1->check();
        augen2->check();
        delay(random(50, 150));
        boden->ein();
        augen1->check();
        augen2->check();
        delay(50);
        boden->aus();
        augen1->check();
        augen2->check();
        delay(random(50, 150));
        boden->ein();
        augen1->check();
        augen2->check();
        delay(50);
        boden->aus();
        augen1->check();
        augen2->check();
        delay(random(50, 150));
        augen1->blinken(true);
        wechsel = millis() + DUNKELZEIT;
        stat = dunkel3;
      }
      break;
    case dunkel3:
      ///es beruhigt sich, nur die Augen blinzeln
      augen1->check();
      augen2->check();
      if (millis() > wechsel)
        ///dann wieder von vorne
        stat = start;
      break;
    }
  }
}
