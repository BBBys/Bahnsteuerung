# Beleuchtung und Ton für die Grillhütte

## Ziel

Lichteffekte in der Grillhütte

- Neopixel-Ring an der Decke der Pavillons
Musik und Geräusche
- Arbeitsgeräusche
- Tanzmusik

## Status

in Arbeit.

- [x] grundlegender Code
- [ ] LEDs schalten
  - [x] Tanzfläche
  - [ ] Grillkohle
- [ ] SD-Karte
  - [ ] lesen
  - [ ] Ton und Musik ausgeben
- [ ] MQTT
  - [x] MQTT-Aufbau
  - [x] WLAN
  - [ ] MQTT-Ablaufsteuerung
    - [x] Lichtprogramm
    - [ ] Musikprogramm
- [ ] Hardware
  - [ ] LED-Ring ankleben
  - [ ] LED in Grills
  - [ ] Lautsprecher
  - [ ] Bodenplatte
    - [ ] Gras
    - [ ] Grills
    - [ ] Schilder
    - [ ] Bänke, Tische
  - [ ] Verkleidung
    - [ ] Hügel
    - [ ] Gras

## Zeitlicher Ablauf

```mermaid
---
title: "Beleuchtung"
---
packet-beta
  0-11: "aus"
  12-14: "gedimmt weiß"
  15-18: "farbig"
  19-21: "Disco"
  22-24: "Blues"
```

```mermaid
---
title: "Ton"
---
packet-beta
  0-13: "Ruhe"
  14-17: "Arbeitsgeräusche"
  18-20: "Tanzmusik"
  21-22: "Disco"
  23-24: "Blues"
```

## Quellen

Verwendet

- Informationen aus dem eBook *EchoTrap : Die Idee, jemanden
in einem unerwarteten Klangerlebnis zu fangen* der
[AZ-Delivery Vertriebs GmbH](https://az-delivery.de) 2024.
- Audio-Software von [schreibfaul1][def]

[def]: https://github.com/schreibfaul1/ESP32-audioI2S
