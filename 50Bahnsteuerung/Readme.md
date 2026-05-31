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
- Gustav Wostrack, Digitale Modellbahn selbstgebaut : CANguru-Steuerung mit ESP32 in Arduino-Umgebung. Dpunkt.verlag, 2020.
Insbesondere die CAN-Bus-Routinen stammen aus dem Buch.
- N.N., Kommunikationsprotokoll Graphical User Interface Prozessor (GUI) <-> Gleisformat Prozessor (Gleis Format Prozessor) über CAN Transportierbar über Ethernet. Göppingen: Gebr. Märklin & Cie. GmbH 2012.
## Icons
- <a href="https://www.flaticon.com/de/kostenlose-icons/aufgaben" title="aufgaben Icons">Aufgaben Icons erstellt von Freepik - Flaticon</a>
- <a href="https://www.flaticon.com/de/kostenlose-icons/config" title="config Icons">Config Icons erstellt von srip - Flaticon</a>
- <a href="https://www.flaticon.com/free-icons/leader" title="leader icons">Leader icons created by Freepik - Flaticon</a>
- <a href="https://www.flaticon.com/free-icons/switch" title="switch icons">Switch icons created by Freepik - Flaticon</a>
- <a href="https://www.flaticon.com/free-icons/emergency-stop" title="emergency stop icons">Emergency stop icons created by Smashicons - Flaticon</a>
- <a href="https://www.flaticon.com/de/kostenlose-icons/signalisierung" title="signalisierung Icons">Signalisierung Icons erstellt von Freepik - Flaticon</a>
- <a href="https://www.flaticon.com/de/kostenlose-icons/gang-einstellen" title="gang einstellen Icons">Gang einstellen Icons erstellt von Aswell Studio - Flaticon</a>
- <a href="https://www.flaticon.com/de/kostenlose-icons/reparatur-zu-hause" title="reparatur zu hause Icons">Reparatur zu hause Icons erstellt von Freepik - Flaticon</a>