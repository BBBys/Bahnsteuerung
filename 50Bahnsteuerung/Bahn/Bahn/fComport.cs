using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Borys.Bahn.Steuerprogramm.Properties;
using System.IO.Ports;
using Borys.Bahn.Steuerprogramm;

namespace Borys.Bahn.Steuerprogramm
{
  public partial class fComport : Form
  {
    private readonly Settings Props;
    private string sPort, sSpeed;

    public fKommando Kommando { get; internal set; }

    public fComport()
    {
      InitializeComponent();

      Text = Properties.Resources.ComportFenstertitel;
#if DEBUG
            Text += " DEBUG";
#else
      Text += Application.CompanyName + ": " + Application.ProductName;
#endif
      Props = Properties.Settings.Default;
      sSpeed = Props.BaudRate;
      sPort = Props.ComPort;
      cbPort.BeginUpdate();
      foreach (string s in SerialPort.GetPortNames())
      {
        cbPort.Items.Add(s);
      }
      cbPort.EndUpdate();
      cbPort.Text = sPort;
      cbSpeed.Text = sSpeed.ToString(); ;
    }

    private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox cb = (ComboBox)sender;

      if (cb.SelectedIndex != -1)
      {
        sPort = cb.SelectedItem.ToString();
        Props.ComPort = sPort;
        Props.Save();
      }
    }

    private void bSchliessen_Click(object sender, EventArgs e)
    {
  Hide();
    }

    private void fComport_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private bool CheckOpen()
    {
      if (Kommando.PortIsOpen)
      {
        lOpen.Visible = true;
        lClosed.Visible = false;
        return true;
      }
      else
      {
        lOpen.Visible = false;
        lClosed.Visible = true;
        return false;
      }
    }

    private void bTrennen_Click(object sender, EventArgs e)
    {
      Kommando.PortClose();
      CheckOpen();
    }

    private void bVerbinden_Click(object sender, EventArgs e)
    {
      Button b = (Button)sender;
      //   toolStripStatusLabel1.Text = "verbinden ...";
      //lop.FillColor = Color.Yellow;
      try
      {
        Kommando.PortName = sPort;
        Kommando.BaudRate = Convert.ToInt32(sSpeed);
        Kommando.PortOpen();
        CheckOpen();
      }
      catch (Exception fehl)
      {
        lMeldung.Text = fehl.Message;
        errorProvider1.SetError(b, fehl.Message);
      }
    }

    private void fComport_Activated(object sender, EventArgs e)
    {
   lMeldung.Text = string.Empty;
      errorProvider1.SetError(bVerbinden, string.Empty);
      CheckOpen();
    }

    private void cbSpeed_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox cb = (ComboBox)sender;

      if (cb.SelectedIndex != -1)
      {
        sSpeed = cb.SelectedItem.ToString();
        Props.BaudRate = sSpeed;
        Props.Save();
      }
    }
  }
}