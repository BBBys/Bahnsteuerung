#Programmablauf und Kommunikation
## Formular fMain
Button bFahren -> Form fFahren-Show
## Formular fFahren
- Button bHalt -> b30_Click
- cCANVerbindung CAN
### Button b30_Click
Der angeklickte Button sitzt in einer Spalte der 2. Zeile von tlpSpeed. 
Der zugehörigr Geschwindigkeitscode wird aus den Lok-Daten übernommen.
Das CAN-Kommando wird zusammengebaut und an CAN.Send übergeben.
## Klasse cCANVerbindung
- Send
- UdpClient ToCAN, FromCAN 
### Send
übergibt Befehl an ToCAN.Send