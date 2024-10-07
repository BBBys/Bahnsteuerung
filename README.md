# Bahnsteuerung
Steuerung einer Märklin-Modelleisenbahn 
unter Verwendung der Routinen aus dem [CANguru-System](https://github.com/CANguru-System)
## Änderungen zum Original
(wenn es denn so funktioniert)
* Steuerung durch angepasste Software auf einem Raspberry Pi mit Touchscreen
   ![Raspberry Pi mit Touchscreen](bilder/b1.jpg)
* Verbindung durch WLAN
## Struktur
> [!Note]
> geplant
```mermaid
flowchart TD
    User-->|Touchscreen| Raspberry
    User-->Märklin-Steuerung
    Raspberry-->|WLAN| Olimex;
    Olimex-->|CAN-Bus| Gleisbox
    Märklin-Steuerung-->|CAN-Bus| Gleisbox
    Gleisbox-->Schiene
    Schiene-->Loks
    Raspberry-->|WLAN| ESP32-Steuerungen
    ESP32-Steuerungen-->Weichen/Signale/Häuser
  
```
