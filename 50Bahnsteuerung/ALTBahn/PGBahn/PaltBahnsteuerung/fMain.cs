using Solid.Arduino;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using Borys.Bahn.ArduinoVerbindung;

namespace Borys.Bahn.Bahnsteuerung
{
  public partial class fMain : Form
  {
    private cArduino Arduino = null;
    private CfTest fTest = null;
    private FSchnittstelle FSchnittstelle = null;

//    private Properties.Settings Props;

    private CfDaten fDaten = null;
    private fWeichen fWeichen = null;
    
    public fMain()
    {
      InitializeComponent();
      Text = Properties.Resources.Fenstertitel + " V" + Application.ProductVersion + ". ";
#if DEBUG
      Text += "DEBUGVERSION";
#else
      Text += Application.CompanyName + ": " + Application.ProductName;
#endif
      //    Props = Properties.Settings.Default;
      lArduino.BackColor = Color.Yellow;
      ComPortSuche comportsuche = new ComPortSuche();
      ArduinoVerbinden(comportsuche.Port);
    }

    private void ArduinoVerbinden(string derPort)
    {
      Arduino = new cArduino(derPort);
      if (Arduino.Status == cArduino.aStatus.asVerbunden)
      {
        lArduino.BackColor = Color.Lime;
        tssl1.Text = Arduino.ToString();
      }
      else
      {
        lArduino.BackColor = Color.Red;
      }
    }


    private void MS1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void TsmiEnde_Click(object sender, EventArgs e)
    {
      BEnde_Click(sender, e);
    }

    private void BEnde_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void BTest_Click(object sender, EventArgs e)
    {

    }

    private void BDaten_Click(object sender, EventArgs e)
    {

    }

    private void FMainShown(object sender, EventArgs e)
    {

    }

    private void MIserielleSchnittstelle_Click(object sender, EventArgs e)
    {
      FSchnittstelle.ShowDialog();
      tssl1.Text = FSchnittstelle.Status();
    }

    /// <summary>
    /// Fenster Weichensteuerung öffnen
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bWeichen_Click(object sender, EventArgs e)
    {
      if (fWeichen == null)
      {
        fWeichen = new fWeichen(Arduino);
      }

      fWeichen.ShowDialog();

    }

    private void fMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (Arduino != null)
      {
        Arduino.Dispose();
      }
    }
  }
}