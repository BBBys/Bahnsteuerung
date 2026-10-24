#include <iostream>
#include <vector>
#include <cstdint>

// Struktur für die decodierten Daten
struct DFPlayerMessage
{
    uint8_t command;
    uint16_t parameter;
    bool isValid;
};

// Funktion zur Berechnung der Prüfsumme (Checksum)
uint16_t calculateChecksum(const uint8_t *buffer)
{
    uint16_t sum = 0;
    for (int i = 1; i < 7; i++)
    { // Summiere Version, Länge, Befehl, Feedback, Param High, Param Low
        sum += buffer[i];
    }
    return -sum; // Zweierkomplement
}

// Funktion zum Decodieren des Pakets (Erwartet ein Array aus 10 Bytes)
DFPlayerMessage decodeDFPlayer(const uint8_t *packet)
{
    DFPlayerMessage msg = {0, 0, false};

    // 1. Start- und End-Byte prüfen
    if (packet[0] != 0x7E || packet[9] != 0xEF)
    {
        std::cout << "Fehler: Ungültiges Start- oder End-Byte!\n";
        return msg;
    }

    // 2. Prüfsumme verifizieren
    uint16_t receivedChecksum = (packet[7] << 8) | packet[8];
    uint16_t computedChecksum = calculateChecksum(packet);

    if (receivedChecksum != computedChecksum)
    {
        std::cout << "Fehler: Prüfsumme falsch!\n";
        return msg;
    }

    // 3. Daten extrahieren
    msg.command = packet[3];
    msg.parameter = (packet[5] << 8) | packet[6]; // High- und Low-Byte zusammenfügen
    msg.isValid = true;

    return msg;
}
/*
int main()
{
    // Die Test-Sequenz aus deiner Anfrage
    uint8_t rawData[] = {0x7E, 0xFF, 0x06, 0x3D, 0x00, 0x00, 0x02, 0xFE, 0xBC, 0xEF};

    DFPlayerMessage result = decodeDFPlayer(rawData);

    if (result.isValid)
    {
        std::cout << "--- Paket erfolgreich decodiert ---\n";
        std::cout << "Befehl (Hex): 0x" << std::hex << (int)result.command << "\n";
        std::cout << "Parameter (Dezimal): " << std::dec << result.parameter << "\n";

        // Interpretation des spezifischen Befehls
        if (result.command == 0x3D)
        {
            std::cout << "Status: Wiedergabe von Track " << result.parameter << " beendet.\n";
        }
    }

    return 0;
}
*/