using Solid.Arduino;
using Solid.Arduino.Firmata;
using System;
using System.Windows.Forms;
using Borys.Bahn.ArduinoVerbindung;

namespace PFirmata
{
  public partial class Form1 : Form
  {
    private cArduino Arduino;

    public Form1() => InitializeComponent();

    private void bEnde_Click(object sender, EventArgs e) => Close();
    private static ISerialConnection Connection
    {
      get
      {
        Console.WriteLine("Searching Arduino connection...");
        ISerialConnection connection = EnhancedSerialConnection.Find();

        switch (connection)
        {
          case null:
            Console.WriteLine("No connection found. Make shure your Arduino board is attached to a USB port.");
            break;
          default:
            Console.WriteLine($"Connected to port {connection.PortName} at {connection.BaudRate} baud.");
            break;
        }

        return connection;
      }
    }

    public ArduinoSession session { get; private set; }

    private static void PerformBasicTest(IFirmataProtocol session)
    {
      /*Firmware firmware = session.GetFirmware();
      Console.WriteLine($"Firmware: {firmware.Name} version {firmware.MajorVersion}.{firmware.MinorVersion}");
      ProtocolVersion protocolVersion = session.GetProtocolVersion();
      var x = session.GetBoardCapability();
      var y = session.GetFirmware();
      var z = session.GetType();

      Console.WriteLine($"Firmata protocol version {protocolVersion.Major}.{protocolVersion.Minor}");
      */
      session.SetDigitalPinMode(13, PinMode.DigitalOutput);
      session.SetDigitalPin(13, true);
      Console.WriteLine("Command sent: Light on (pin 10)");
      Console.WriteLine("Press a key");
      Console.Read();
      session.SetDigitalPin(13, false);
      Console.WriteLine("Command sent: Light off");
    }
    private void button1_Click(object sender, EventArgs e)
    {
      Arduino = new cArduino("COM5");

      if (Arduino.Status==cArduino.aStatus.asVerbunden)
      {
        session = Arduino.Session;


        PerformBasicTest(session);
      }
      //Console.WriteLine("Press a key");
      //Console.ReadKey(true);
    }

    private void button2_Click(object sender, EventArgs e) => session.SetDigitalPin(13, true);

    private void button3_Click(object sender, EventArgs e) => session.SetDigitalPin(13, false);
  }
}