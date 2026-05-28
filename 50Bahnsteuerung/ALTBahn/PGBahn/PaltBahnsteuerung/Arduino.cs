using Solid.Arduino;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borys.Bahn.Bahnsteuerung
{
  internal class cArduino:IDisposable
  {
    public enum aStatus  {asNeu,asVerbunden,asFehler };
    private ISerialConnection Connection;
    private aStatus status = aStatus.asNeu;

    internal aStatus Status { get => status;private set => status = value; }
    public ArduinoSession Session { get; private set; }

    public cArduino()
    {

      try
      {
        Connection = GetConnection();
        if (Connection != null)
        {
          Session = new ArduinoSession(Connection);
          Status = aStatus.asVerbunden;
          Solid.Arduino.Firmata.BoardCapability x = Session.GetBoardCapability();
          Solid.Arduino.Firmata.Firmware y = Session.GetFirmware();
          Type z = Session.GetType();

        }
      }
      catch (Exception ex)
      {
        Status = aStatus.asFehler;
        MessageBox.Show("keine Verbindung", "Arduino", MessageBoxButtons.OK, MessageBoxIcon.Stop);
      }
    }
    private static ISerialConnection GetConnection()
    {
      string usbPort = "";
      ISerialConnection connection;
      Console.WriteLine("Searching Arduino connection...");
      // Get a list of serial port names.
      var ports = SerialPort.GetPortNames();
      if (ports.Length < 1)
      {
        MessageBox.Show("keine serielle Schnittstelle gefunden!", "Arduino", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return null;
      }

      Console.WriteLine("The following serial ports were found:");

      // Display each port name to the console.
      foreach (var port in ports)
      {
        Console.WriteLine(port);
      }
      foreach (var port in ports)
      {
        if (port.Contains("/dev/ttyUSB") || port.Contains("COM"))
        {
          usbPort = port;
          break;
        }
      }

      if (usbPort.Length < 1)
      {
        MessageBox.Show("keine passende serielle Schnittstelle gefunden!", "Arduino", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return null;
      }

      //alt ISerialConnection connection = EnhancedSerialConnection.Find();
      //Ziel:  var session = new ArduinoSession())
      try
      {
        //  connection = new EnhancedSerialConnection("/dev/Arduino", SerialBaudRate.Bps_9600);
        connection = new EnhancedSerialConnection(usbPort, SerialBaudRate.Bps_9600);

      }

      catch (Exception ee)
      {
        MessageBox.Show(ee.Message, "Open Arduino-Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
        throw;
      }
      switch (connection)
      {
        case null:
          Console.WriteLine("No connection found. Make shure your Arduino board is attached to a USB port.");
          break;
        default:
          Console.WriteLine($"Arduino: port {connection.PortName} at {connection.BaudRate} baud.");
          break;
      }

      return connection;
    }

    public override string ToString() => $"Arduino: port {Connection.PortName} at {Connection.BaudRate} baud.";

    public void Dispose()
    {
      Session.Dispose();
      Connection.Close();
      Connection.Dispose();
    }
  }
}
