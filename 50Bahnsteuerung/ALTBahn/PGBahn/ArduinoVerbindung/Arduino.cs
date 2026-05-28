using Solid.Arduino;
using Solid.Arduino.Firmata;
using System;
using System.IO.Ports;

namespace Borys.Bahn.ArduinoVerbindung
{
  public class cArduino:IDisposable
  {
    public enum aStatus  {asNeu,asVerbunden,asFehler };
    private aStatus status = aStatus.asNeu;
    private readonly string USBPort;
    private readonly EnhancedSerialConnection USBConnection;

    public aStatus Status { get => status;private set => status = value; }
    public ArduinoSession Session { get; private set; }

    public cArduino(string pPort)
    {
      USBPort = pPort;
      try
      {
        USBConnection = new EnhancedSerialConnection(USBPort, SerialBaudRate.Bps_57600);
        USBConnection.Open();
        Session = new ArduinoSession(USBConnection,3000);
        
        //Firmware firmware = Session.GetFirmware();
        Status = aStatus.asVerbunden;
      }
      catch (System.IO.IOException ee)
      {
        throw new Exception("Port falsch?",ee);
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
        throw new Exception(ee.Message+": Open Arduino-Port", ee);
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

    public void SetPinModeDigitalOutput(int pin) => Session.SetDigitalPinMode(pin, PinMode.DigitalOutput);

    public override string ToString() => $"Arduino: port {USBConnection.PortName} at {USBConnection.BaudRate} baud.";

    public void Dispose()
    {
      Session.Clear();
      Session.Dispose();
      USBConnection.Close();
      USBConnection.Dispose();
    }

    /// <summary>
    /// Wert Digitalpin setzen
    /// </summary>
    /// <param name="pin">Pin</param>
    /// <param name="wie">High oder Low</param>
    public void SetDigitalPin(int pin, bool wie) => Session.SetDigitalPin(pin, wie);

  }
}
