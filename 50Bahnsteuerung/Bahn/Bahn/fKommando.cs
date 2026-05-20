using Borys.Bahn.Steuerprogramm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borys.Bahn.Steuerprogramm
{
  public partial class fKommando : Form
  {
    private Settings Props;
    private SerialPort spArduino;
    private string CanText;
    private fBMain FBahn;

    public fKommando()
    {
      InitializeComponent();
      Props = Settings.Default;
      spArduino = new SerialPort(Props.ComPort, Convert.ToInt32(Props.BaudRate));
      spArduino.DataReceived += SpArduino_DataReceived;
      spArduino.ErrorReceived += SpArduino_ErrorReceived;
      spArduino.PinChanged += SpArduino_PinChanged;
      spArduino.ReadTimeout = Props.ReadTimeoutMs;
      spArduino.WriteTimeout = Props.WriteTimeoutMs;
      FBahn = (fBMain)Parent;
    }

    public int BaudRate { get { return spArduino.BaudRate; } internal set { spArduino.BaudRate = value; } }

    public SerialPort Port { get { return spArduino; } }

    public bool PortIsOpen { get { return spArduino.IsOpen; } }

    public string PortName { get { return spArduino.PortName; } internal set { spArduino.PortName = value; } }

    internal void PortClose()
    {
      if (spArduino.IsOpen)
      {
        spArduino.DiscardInBuffer();
        spArduino.DiscardOutBuffer();
        spArduino.Close(); 
      }

    }

    internal void PortOpen()
    {
      spArduino.Open();
    }
    private void SpArduino_PinChanged(object sender, SerialPinChangedEventArgs e)
    {
      throw new NotImplementedException();
    }

    private void SpArduino_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
    {
      throw new NotImplementedException();
    }

    private void SpArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      string zeile;
      int pos;
      SerialPort sp = (SerialPort)sender;
      string s = sp.ReadExisting();
      CanText += s;
      while ((pos = CanText.IndexOf("\r\n")) >= 0)
      {
        zeile = CanText.Substring(0, pos);
        CanText = CanText.Remove(0, pos + 2);
        if (pos > 0)
        {
          if (zeile.Contains("=="))
          {
            string aus = "?";
            var teile = zeile.Split(' ');
            if (teile[4].Equals("00"))
            {
              aus = "System: ";
              if (teile[10].Equals("00")) aus += "STOP";
              else if (teile[10].Equals("01")) aus += "GO";
              else aus += teile[10];

            }
            else if (teile[4].Equals("04"))
            {
              aus = "Geschwindigkeit ";
              if (teile[5].Equals("6"))
              {
                aus += "Lok ";
                aus += teile[9] + " ";
                aus += teile[10] + teile[11];

              }
            }
            FBahn.FMeldung.Add(aus);
          }
          else FBahn.FMeldung.Add(zeile);

        }
        else FBahn.FMeldung.Add("(leer)");
      }
    }

  }
}
