using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Borys.Bahn.Bahnsteuerung
{

  /// <summary>
  /// Text im Label aus anderem Thread setzen
  /// </summary>
  /// <remarks>
  /// InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.
  /// If these threads are different, it returns true.
  /// </remarks>
  public partial class CfTest : Form
  {
    /// <summary>
    /// Status des Programms
    /// </summary>
    enum EStatus
    {
      /// <summary>
      /// Anfangsstatus
      /// </summary>
      nichts = 0,
      /// <summary>
      /// Kommunikation aufbauen
      /// </summary>
      Start,
      /// <summary>
      /// Kommunikation vorhanden
      /// </summary>
      Go,
      /// <summary>
      /// Programm wird beendet
      /// </summary>
      Ende
    }
    /// <summary>
    /// globaler Programmstatus
    /// </summary>
    EStatus Status = EStatus.nichts;
    /// <summary>
    /// empfangenen Text weiterverarbeiten
    /// This delegate enables asynchronous calls 
    /// </summary>
    /// <param name="text">der empfangene Text</param>
    delegate void SetTextCallback(string text);
    /// <summary>
    /// Adresse für nächsten Befehl
    /// </summary>
    private uint Adresse;
    private Properties.Settings Props;
    private cCmd.StartbitUndBefehl Befehl;
    private cLoks Lokliste;
    private cCmds CmdListe;
    private const string CmdQuit = "!!q!!";
    private byte iTestadresse = 28;

    public SerialPort SPort { get; internal set; }

    /// <summary>
    ///  Konstruktor
    /// </summary>
    public CfTest()
    {
      InitializeComponent();

      #region Einstellungen
      Props = Properties.Settings.Default;
      #endregion
      #region Objekte
      LokButtons(flpLoks);
      CmdButtons(flpCmd);
      #endregion
    }

    private void CmdButtons(Panel pPanel)
    {
      //       Lok1 = new cLok("Lok1", 0x18, pPanel, LokAuswahl);
      CmdListe = new cCmds(pPanel, CmdAuswahl);
      CmdListe.Neu("STOP", 1, 0x0d);
      CmdListe.Neu("Licht", 0, 0x10);
      CmdListe.Neu("+", 1, 0x10);
      CmdListe.Neu("-", 1, 0x11);
      CmdListe.Neu("Blinklicht", 0, 0x11);
      CmdListe.Neu("F2", 0, 0x12);
      CmdListe.Neu("F3", 0, 0x13);
      CmdListe.Neu("F4", 0, 0x14);
      CmdListe.Neu("0-00", 0, 0x00);
      CmdListe.Neu("0-01", 0, 0x01);
      CmdListe.Neu("0-3F", 0, 0x3F);
      CmdListe.Neu("1-3F", 0, 0x3F);
      CmdListe.Neu("gn", 0, 0x20);
      CmdListe.Neu("rt", 0, 0x00);
    }

    /// <summary>
    /// Erstellen der Buttons
    /// </summary>
    private void LokButtons(Panel pPanel)
    {
      Lokliste = new cLoks(pPanel, LokAuswahl);
      Lokliste.Neu("Lok1", 0x18);
      Lokliste.Neu("Werkstattlok", 0x19);
      Lokliste.Neu("Lok3", 0x1b);
      Lokliste.Neu("Lok4", 0x1c);
      Lokliste.Neu("0B", 0x0B);
      Lokliste.Neu("0C", 0x0C);
      Lokliste.Neu("0D", 0x0D);
      Lokliste.Neu("0A", 0x0A);
      Lokliste.Neu("09", 0x09);
    }

    /// <summary>
    /// Callback: Lok-Button
    /// </summary>
    void LokAuswahl(object sender, EventArgs e)
    {
      Button b = (Button) sender;
      LokButtonsGrau(b);
      b.BackColor = Color.Yellow;
      Adresse = ((cLok) b.Tag).Adresse;
    }
    void CmdAuswahl(object sender, EventArgs e)
    {
      Button b = (Button) sender;
      LokButtonsGrau(b);
      b.BackColor = Color.Yellow;
      Befehl = ((cCmd) b.Tag).Befehl;
    }

    /// <summary>
    /// Text aus anderm Thread setzen
    /// </summary>
    /// <remarks>
    /// InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.
    /// If these threads are different, it returns true.
    /// </remarks>
    private void SetText(String sEin)
    {
      if (this.lDaten.InvokeRequired)
      {
        SetTextCallback dSTC = new SetTextCallback(SetText);
        Invoke(dSTC, new object[] { sEin });
      }
      else
      {
        this.lDaten.Text = sEin;
        if (Status == EStatus.Go)
        {

        }
        else if (Status == EStatus.Start)
        {
          if (sEin.Contains("IRIF"))
          {
            tsslVersion.Text = sEin;
            SPort.WriteLine("go!");
            Status = EStatus.Go;
          }
        }
      }
    }

    /// <summary>
    /// Verbindung herstellen
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
    private void BStart_Click(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Callback: Daten angekommen
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
    private void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      SerialPort sp = (SerialPort) sender;
      String zeile = "";
      tssl1.Text = "erwarte Daten...";
      //int ib;
      //ib = SP1.BytesToRead;
      if (Status != EStatus.Ende)
        //geschlossen wird woanders sPort.Close();
        try
        {
          zeile = sp.ReadExisting();
          if (String.IsNullOrEmpty(zeile))
            zeile = "<NUL>";
          tssl1.Text = "Daten OK: " + zeile.Length.ToString();
        }
        catch (TimeoutException) { tssl1.Text = "Timeout!"; Status = EStatus.Ende; zeile = "??"; }
        catch (Exception ex) { tssl1.Text = ex.Message; Status = EStatus.Ende; zeile = "?"; }
        finally { SetText(zeile); }
    }
    /// <summary>
    /// beenden
    /// </summary>
    private void BEnde_Click(object sender, EventArgs e)
    {
      Close();
    }

    /// <summary>
    /// Callback: Kommunikationsfehler
    /// </summary>
    private void SPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
    {
      MessageBox.Show(e.EventType.ToString());
    }

    /// <summary>
    /// Test: senden
    /// </summary>
    private void BSenden_Click(object sender, EventArgs e)
    {
      Byte[] senden = new Byte[5];
      senden[0] = (Byte) 'c';
      senden[1] = (Byte) Befehl.SB2;
      senden[2] = (Byte) Adresse;
      senden[3] = (Byte) Befehl.B;
      senden[4] = (Byte) '!';
      SPort.Write(senden, 0, 5);
    }

    /// <summary>
    /// nicht gewählte Buttons Farbe ändern
    /// </summary>
    private static void LokButtonsGrau(Button pButton)
    {
      Control panel = pButton.Parent;
      foreach (Button b in panel.Controls)
        b.BackColor = Color.White;
    }

    /// <summary>
    /// Test
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
    private void Button1_Click(object sender, EventArgs e)
    {
      lPch.Text = iTestadresse.ToString();
      iTestadresse = SicherSenden(Befehl.SB2, iTestadresse, Befehl.B);
    }

    private Byte SicherSenden(uint pSB2, Byte piTestadresse, uint pB)
    {
      try
      {
        Byte[] senden = new Byte[5];
        senden[0] = (Byte) 'c';
        senden[1] = (Byte) pSB2;
        senden[2] = piTestadresse++;
        senden[3] = (Byte) pB;
        senden[4] = (Byte) '!';
        SPort.Write(senden, 0, 5);
        if (SPort.BytesToWrite > 1)
        {
          lDaten.Text = "???";
        }
      }
      catch (Exception exe) { tssl1.Text = exe.Message; }
      return piTestadresse;
    }

    private void CfTest_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (SPort.IsOpen)
      {
        // sPort.Write(CmdQuit);
        Status = EStatus.Ende;
        SPort.DiscardInBuffer();
        SPort.DiscardOutBuffer();
        SPort.DataReceived -= SPort_DataReceived;
      }
    }

    private void CfTest_Shown(object sender, EventArgs e)
    {
      SPort.DataReceived +=SPort_DataReceived;
    }
  }
}