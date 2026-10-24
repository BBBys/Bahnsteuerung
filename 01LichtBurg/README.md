# Geräusche und Beleuchtung der Burg

## Ziel

Burgruine bei Dunkelheit beleuchten

- zwei rote Blinklichter auf dem Turm
- farbige Effektbeleuchtung an den Mauern und im Innenhof

In Abständen Events:

- Licht aus
- Augen blinzeln in den Fenstern
- durchscheinendes Gespenst im Burghof
  - Leuchtfarbe und UV-LEDs

## Status

in Arbeit.

- [x] grundlegender Code
- [ ] LEDs über Multiplexer schalten
- [ ] Gespenst
- [ ] MQTT-Steuerung
- [ ] Hardware
- [ ] Ton (Glocken, Orgel, Heulen ...)

# Seeed Studio MP3-Player KT403A

## SD-Karte

Quelle: Copilot

Damit der Seeed Studio MP3-Player KT403A (häufig auf dem Grove Serial MP3 Player v2.0 verbaut) Dateien über serielle Befehle
gezielt ansteuern kann, müssen die SD-Karte und die Dateien einer strikten Struktur und Benennung folgen.
Die SD-Karte muss im FAT16- oder FAT32-Format formatiert sein.
Die Dateien müssen in einem bestimmten Verzeichnis liegen und dürfen nur bestimmte Dateinamen haben.

Der KT403A-Chip unterstützt drei verschiedene Logiken, um Dateien gezielt per Software/Code
(z. B. mit der offiziellen Seeed_Serial_MP3_Player-Bibliothek) anzusprechen:

### Methode A: Nummerierte Ordner (Empfohlen für Kategorien)

Perfekt, wenn du deine Tracks in Alben, Sprachen oder Kategorien unterteilen willst.
• Ordnername: Müssen zweistellig nummeriert sein: 01, 02, 03 bis 99.
• Dateiname: Müssen mit einer dreistelligen Nummer beginnen, gefolgt von beliebigem Text: 001.mp3, 002_Alarm.wav, 099_Lied.mp3.

Struktur-Beispiel:

```text
SD-Karte/
├── 01/
│   ├── 001_intro.mp3
│   ├── 002_ambient.mp3
├── 02/
│   ├── 001_soundeffect.wav

```

Ansteuerung im Code: playSongSpecify(1, 1); spielt den ersten Track im Ordner 01.

### Methode B: Der globale "MP3"-Ordner (Für große Musiksammlungen)

Erlaubt es, bis zu 65.535 Titel in einem einzigen Verzeichnis gezielt per Index aufzurufen.
• Ordnername: Muss exakt MP3 heißen (Groß-/Kleinschreibung ist dem Chip egal).
• Dateiname: Müssen mit einer vierstelligen Nummer benannt werden: 0001.mp3, 0002.mp3 bis 9999.mp3.
Struktur-Beispiel:

```text
SD-Karte/
└── MP3/
    ├── 0001.mp3
    ├── 0002.mp3
```

Ansteuerung im Code: playSongMP3(2); spielt gezielt die Datei 0002.mp3.

### Methode C: Der "ADVERT"-Ordner (Für Unterbrechungen/Durchsagen)

Ein Spezialordner.
Wenn eine Datei aus diesem Ordner aufgerufen wird, pausiert der KT403A den aktuell laufenden Song,
spielt die Durchsage ab und springt danach exakt an die vorherige Stelle im Lied zurück.
• Ordnername: Muss exakt ADVERT heißen.
• Dateiname: Genau wie bei Methode A dreistellig: 001.mp3, 002.mp3.

### Wichtiger Fallstrick beim Kopieren (Reihenfolge)

Wenn du Dateien direkt im Hauptverzeichnis (Root) ablegst, ohne Ordner zu nutzen, besitzt der KT403A keine Namenserkennung.
Er sortiert Tracks in diesem Fall ausschließlich nach der physikalischen Reihenfolge, in der sie auf die SD-Karte kopiert wurden.
• Tipp: Wenn du Lieder im Root-Verzeichnis abspielst (z. B. via playSongIndex(1);),
kopiere die Dateien einzeln nacheinander auf die Karte, um die gewünschte Reihenfolge zu erzwingen.
Für eine gezielte Auswahl im Code sind die Methoden A und B jedoch deutlich zuverlässiger.

## Statusmeldungen des MP3-Players

0x7E 0xFF 0x6 0x3D 0x0 0x0 0x2 0xFE 0xBC 0xEF
• 0x7E: Start-Byte des Protokolls
• 0xFF: Versions-Byte
• 0x06: Länge des Datenpakets (6 Bytes Nutzdaten)
• 0x3D: Befehl bzw. Rückgabewert – bedeutet „Wiedergabe auf der SD-Karte beendet“ (TF-Card)
• 0x00: Feedback-Status
• 0x00 0x02: Parameter – Gibt die Nummer des eben fertig abgespielten Tracks an (hier: Track 2)
• 0xFE 0xBC: Prüfsumme (Checksum) zur Absicherung der Datenübertragung
• 0xEF: End-Byte des Protokolls

Der Parameter (die Track-Nummer) ist auf zwei Bytes aufgeteilt.
Mit (packet[5] << 8) | packet[6] werden diese wieder zu einer einzigen 16-Bit-Zahl (uint16_t) zusammengesetzt.

# Quellen der Audio Files

- Iirogueking, CC BY-SA 4.0 <https://creativecommons.org/licenses/by-sa/4.0>, via Wikimedia Commons
- copyc4t, CC BY 4.0 <https://creativecommons.org/licenses/by/4.0>, via Wikimedia Commons

## von pixabay

- gregorquendel-bach-toccata-and-fugue-in-d-minor-bwv-565-250589
- mish7913-hooded-crow-panic-cawing-217458
- jasonlee3071-church-bells-194653
