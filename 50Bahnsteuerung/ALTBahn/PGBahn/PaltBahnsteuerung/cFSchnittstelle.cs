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
using Borys.Bahn.Bahnsteuerung.Properties;

namespace Borys.Bahn.Bahnsteuerung
{
  public partial class FSchnittstelle : Form
  {
    public string Comport { get; internal set; }
        private Settings Props;
        public SerialPort SPort { get; internal set; }
    public int Comrate { get; internal set; }
    public FSchnittstelle()
    {
      InitializeComponent();
    }

    public FSchnittstelle(SerialPort pPort, string pComport, int pComrate) 
    {
      InitializeComponent();
      Props = Settings.Default;
      SPort = pPort;
      Comport = pComport;
      Comrate = pComrate;
      //cbPort.Text = Comport; /*löst SelectedIndexChanged aus, das führt zu PortÖffnen();*/
      PortÖffnen();
    }

    internal string Status()
    {
      String status = "";
      if (SPort.IsOpen)
        status = "geöffnet " + SPort.PortName + "@" + SPort.BaudRate + ", " + SPort.BytesToRead + " Bytes warten";
      else
        status = "Port nicht geöffnet";
      return status;
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Literale nicht als lokalisierte Parameter übergeben", MessageId = "System.Windows.Forms.ToolStripItem.set_Text(System.String)")]
    private void PortÖffnen()
    {
      if (SPort.IsOpen)
      {
        SPort.Close();
      }
      SPort.PortName = Comport;
      SPort.BaudRate = Comrate;
      tssl1.Text = Comport + " öffnen...";
      try
      {
        SPort.Open();
        tssl1.Text = Comport + " geöffnet mit " + Comrate.ToString();
        //timer.Enabled = true;
      }
      catch (TimeoutException)
      {
        //timer.Enabled = false;
        tssl1.Text = "Timeout!";
      }
      catch (Exception ex)
      {
        //timer.Enabled = false;
        tssl1.Text = ex.Message;
      }
    }
    /// <summary>
    /// Port ausgewählt
    /// </summary>
    private void CbPort_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox cb = (ComboBox) sender;
      Comport = cb.Text;
      Props.Comport = Comport;
      Props.Save();
      PortÖffnen();
    }
    /// <summary>
    /// Callback: Kommunikationsfehler
    /// </summary>
    private void SPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
    {
      MessageBox.Show(e.EventType.ToString());
    }


    private void BVerbergen_Click(object sender, EventArgs e)
    {
      Hide();
    }

    private void Bsuchen_Click(object sender, EventArgs e)
    {
      cbPort.Items.Clear();
      tssl1.Text = "suche Anschlüsse...";
      string[] ports = SerialPort.GetPortNames();
      int pcount = ports.Count();
      if (pcount > 0)
      {
        cbPort.BeginUpdate();
        foreach (string s in ports)
        {
          cbPort.Items.Add(s);
        }
        cbPort.EndUpdate();
        tssl1.Text = pcount.ToString() + " serielle Anschlüsse";
       
      }
      else
        tssl1.Text = "keine seriellen Anschlüsse!";
    }

    private void Böffnen_Click(object sender, EventArgs e)
    {
      Button b = (Button) sender;
      PortÖffnen();
      b.Enabled = !SPort.IsOpen;
      
    }

    private void FSchnittstelle_Enter(object sender, EventArgs e)
    {

    }
  }
}
