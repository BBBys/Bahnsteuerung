#include <licht.h>
#include "fahrstuhl.h"
unsigned long Weiter(unsigned long zeit)
{
  return millis() + 1000L * zeit;
}
const int WECHSELZEIT = 10;
const int SENSOR = A7;
/* LEDs */
const int TURM = 13;
const int AUSSICHT = 12;
const int SCHLAF1 = 10;
const int SCHLAF2 = 11;
const int STUBE = 3;
const int KUCHE = 9;
//const int AUGEN1 = 7;
//const int AUGEN2 = 8;
const int FST1 = 6;
const int FST2 = 5;
const int TURMAN = 5000;
const int TURMAUS = 777;
const unsigned long NORMALZEIT = 60 * 1000L;
const unsigned long DUNKELZEIT = 180 * 1000L;
const int FSTMIN = 60, FSTMAX = 300;
enum  Stat {stStart, stHell, stAus, stDunkel1, stDunkel2, stDunkel3a, stDunkel3b, stDunkel4} stat;
unsigned long wechsel = 0;
bool tag = true, dunkel = true;
ALicht *schlaf1, *schlaf2;
LLicht *aussicht, *stube, *kuche;
BLicht *turm;
ALicht *fst1, *fst2;
Fahrstuhl *fst;
// the setup function runs once when you press reset or power the board
void setup() {
  stat = stStart;
  /*  augen2 = new BLicht(AUGEN2, 10000, 200);
    augen1 = new BLicht(AUGEN1, 11000, 250);
    front = new Licht(FRONT);
    turm1 = new BLicht(TURM1, TURMAN - 33, TURMAUS);
  */
  fst1 = new ALicht(FST1);
  fst2 = new ALicht(FST2);
  aussicht = new LLicht(AUSSICHT);
  stube = new LLicht(STUBE);
  kuche = new LLicht(KUCHE);
  schlaf1 = new ALicht(SCHLAF1);//, 2.5 * NORMALZEIT, DUNKELZEIT);
  schlaf2 = new ALicht(SCHLAF2);//, 3 * NORMALZEIT, DUNKELZEIT);
  turm = new BLicht(TURM, TURMAN, TURMAUS);
  randomSeed(analogRead(0));
  fst = new Fahrstuhl(fst1, fst2, aussicht);
  fst->start(3000);

}

// the loop function runs over and over again forever
void loop() {
  int sensorValue;
  sensorValue = analogRead(SENSOR);
  tag = (sensorValue > 550);
  dunkel = (sensorValue < 400);
  switch (stat)
  {
    case stStart:
      if (tag)stat = stAus;
      else stat = stDunkel1;
      break;
    case stAus:
      schlaf1->aus();
      schlaf2->aus();
      stube->aus();
      aussicht->aus();
      kuche->aus();
      stat = stHell;
      break;
    case stHell:
      if (dunkel)
        stat = stDunkel1;
      break;
    case stDunkel1:
      if (tag)
      { 
        stat = stAus;
        break;
      }
      schlaf1->aus();
      schlaf2->aus();
      stube->ein();
      kuche->ein();
      stat = stDunkel2;
      wechsel = Weiter(WECHSELZEIT);
      break;
    case stDunkel2:
      if (tag)
      { 
        stat = stAus;
        break;
      }
      if (millis() < wechsel)
        break;
      schlaf1->ein();
      schlaf2->halb();
      //stube->ein();
      kuche->aus();
      stat = stDunkel3a;
      wechsel = Weiter(WECHSELZEIT);
      break;
    case stDunkel3a:
      if (tag)
      { 
        stat = stAus;
        break;
      }
      if (millis() < wechsel)
        break;
      schlaf1->aus();
      schlaf2->aus();
      stube->aus();
      kuche->aus();
      stat = stDunkel3b;
      wechsel = Weiter(WECHSELZEIT/3);
      break;
    case stDunkel3b:
      if (tag)
      { 
        stat = stAus;
        break;
      }
      if (millis() < wechsel)
        break;
      schlaf1->aus();
      schlaf2->ein();
      stube->aus();
      kuche->aus();
      stat = stDunkel4;
      wechsel = Weiter(WECHSELZEIT);
      break;
    case stDunkel4:
      if (tag)stat = stAus;
      if (millis() < wechsel)
        break;
      schlaf2->aus();
      break;
    default: stat = stStart;
  }
  turm->check();
  stube->check();
  kuche->check();
  schlaf1->check();
  schlaf2->check();
  if (fst->check()) {
    fst->start((long)random(FSTMIN, FSTMAX) * 1000L);
  }
  if (dunkel)
  {
    turm->blinken(true);
  }
  if (tag)
  {
    turm->blinken(false);
  }
}
