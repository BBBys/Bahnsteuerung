# Projektmappe Bahnsteuerung
## Bahnsteuerung
Programm zur Steuerung über CAN-Bus-Befehle.
Läuft auf 800x480-Touchscreen.
In Entwicklung, aber im wesentlichen schon 
funktionsfähige Version.
### GUI
- Font: Bahnschrift 18 pt
## Testprogramme
### PTouch
Programm für den 800x480-Touchscreen,
dabei ist die Fensterfläche 806x450 und wird durch *WindowState = Maximized* erreicht.
(Prüfen der Fenster-Abmessungen im Branch *SizeTest*.)
Test für Größen und Anordnung
#### GUI
Button-Scrift: *MS Sans Serif*, 15pt, Fett
### TestBahnsteuerung
Testprogramm, um CAN-Befehle zusammenzustellen und zu zu senden
### Steuerprogramm
Testprogramm, um Loks mit ihren Funktionen anzusprechen und CAN-Befehle zu senden
### PMqttBroker, PMqttServer
MQTT-Tests 
# Quellen
N.N., Kommunikationsprotokoll Graphical User Interface Prozessor (GUI) <-> Gleisformat Prozessor (Gleis Format Prozessor) über CAN Transportierbar über Ethernet. Göppingen: Gebr. Märklin & Cie. GmbH 2012.
  