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

namespace Borys.Bahn.Bahnsteuerung
{

  public partial class CfDaten : Form
  {
    private char[] Handshake = { 'S', 'Q' };

    private enum HsCodes { hsStart = 0, hsQuit };
    /// <summary>
    /// Zeiger: serielle Schnittstelle
    /// </summary>
    /// <remarks>Original in FMain</remarks>
    public SerialPort SPort { get; internal set; }
#if DEBUG
    //bool DBG = true;
#else
    //bool DBG = false;
#endif

    /// <summary>
    /// empfangenen Text weiterverarbeiten
    /// This delegate enables asynchronous calls 
    /// </summary>
    /// <param name="text">der empfangene Text</param>
    delegate void SetTextCallback(string text);
    delegate void CBAutoCheckCallback(bool check);

    public CfDaten()
    {
      InitializeComponent();
      SetText("init");
    }



    /// <summary>
    /// bein Schließen: Eingabepuffer leeren, Timer abstellen
    /// </summary>
    private void CfDaten_FormClosing(object sender, FormClosingEventArgs e)
    {
      timer1.Enabled = false;
      if (SPort.IsOpen)
      {
        SPort.Write(Handshake, (int) HsCodes.hsQuit, 1);
        // sPort.Write(CmdQuit);
        SPort.DiscardInBuffer();
#if CALLBACK
        SPort.DataReceived -= SPort_DataReceived;
#endif
      }
    }
#if CALLBACK
    /// <summary>
    /// Callback, wenn Daten eingetroffen
    /// </summary>
    /// <remarks>funktioniert nicht unter LINUX, nur Windows</remarks>
    private void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      CBautoCheck(false);
           SetText(DatenLesen((SerialPort) sender));
    }
#endif

    private string DatenLesen() => DatenLesen(SPort);
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Literale nicht als lokalisierte Parameter übergeben", MessageId = "System.Windows.Forms.ToolStripItem.set_Text(System.String)")]
    private string DatenLesen(SerialPort sp)
    {
      int ib;
      string zeile;
      ib = sp.BytesToRead;
      if (ib > 0)
      {
        tssl1.Text = "erwarte Daten...";

        try
        {
          zeile = sp.ReadExisting();
          if (String.IsNullOrEmpty(zeile))
          {
            zeile = "<NUL>";
          }
          tssl1.Text = "Daten OK: " + zeile.Length.ToString();
        }
        catch (TimeoutException)
        {
          tssl1.Text = "Timeout!";
          zeile = "??";
        }
        catch (Exception ex)
        {
          tssl1.Text = ex.Message;
          zeile = "?";
        }
      }
      else
        zeile = "<NUL>";
      return zeile;
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
      if (this.tbDaten.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(SetText);
        Invoke(d, new object[] { sEin });
      }
      else
      {
        char[] p = { '\n', '\r' };
        int n = tbDaten.Lines.Count();
        string[] zeilen = sEin.Split(p);
        foreach (String zeile in zeilen)
        {
          String s;
          s = Decode(zeile);
          tbDaten.AppendText(s);
        }
      }
    }

    private static String Decode(String sEin)
    {
      bool rückm;
      String tein, adr, msg, cmd, wert;
      int i1, i2, rshift;
      if (sEin.Equals("init", StringComparison.OrdinalIgnoreCase))
        return "Init";
      if (sEin.Equals("<NUL>", StringComparison.OrdinalIgnoreCase))
        return "";
      if (sEin.Length < 5)
        return sEin;
      tein = (sEin.Trim()).ToUpper();
      //String[] teile = tein.Split(' ', StringSplitOptions.RemoveEmptyEntries);
      String[] teile = tein.Split(' ');
      int l = teile.Length;
      msg = "";
      if (l > 0)
      {
        adr = teile[0];
        if (adr.Length != 4)
          return "Syntax: " + tein;
        i1 = adr.CompareTo("4000");
        i2 = adr.CompareTo("7FFF");
        if (i1 >= 0 && i2 < 1) // 4000 bis 7FFF: MFX
          msg += "MFX ";
        else
          msg += "Adresse ";
        msg += adr + ": ";
      }
      rückm = false;
      rshift = 0;
      if (l > 1)
        if (teile[1].Equals("R"))
        {
          msg += "Rückmeldung: ";
          rückm = true;
          rshift = 1;
        }
      if (l > 3 - rshift)
        cmd = teile[3 - rshift];
      else
        return "Syntax: " + tein;
      if (l > 9 - rshift)
      {
        if (cmd.Equals("04"))
        {
          msg += "Lok " + teile[5 - rshift] + teile[6 - rshift] + teile[7 - rshift] + teile[8 - rshift] + ", ";
          msg += "Geschwindigkeit " + teile[9 - rshift] + teile[10 - rshift];
        }
        if (cmd.Equals("06"))
        {
          msg += "Lok " + teile[5 - rshift] + teile[6 - rshift] + teile[7 - rshift] + teile[8 - rshift] + ", ";
          msg += "Funktion " + teile[9];
          if (l > 10)
            wert = teile[10 - rshift].Equals("00") ? " aus" : " an";
          else
            wert = "?";
          msg += wert;
        }
        else if (cmd.Equals("00"))
          msg = DecodeSytem(msg, rshift, teile);
      }
      else if (l > 4 - rshift)
        if (cmd.Equals("18"))
          msg += "Abfrage Teilnehmer/Softwarestand";

      return msg + "\n\r";
    }

    private static string DecodeSytem(string msg, int rshift, string[] teile)
    {
      msg += "System";
      msg += " an " + teile[5 - rshift] + teile[6 - rshift] + teile[7 - rshift] + teile[8 - rshift] + ":";
      if (teile[9 - rshift].Equals("08"))
        msg += " Gleisprotokoll " + teile[10];
      else if (teile[9 - rshift].Equals("00"))
        msg += " STOP!";
      else if (teile[9 - rshift].Equals("01"))
        msg += " Stop aufgehoben";
      else if (teile[9 - rshift].Equals("09"))
        msg += " Neuanmeldezähler " + teile[10 - rshift] + teile[11 - rshift];
      return msg;
    }

    /// <summary>
    /// Checkbox aus anderm Thread setzen
    /// </summary>
    /// <remarks>
    /// InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.
    /// If these threads are different, it returns true.
    /// </remarks>
    private void CBautoCheck(bool check)
    {
      if (CBauto.InvokeRequired)
      {
        CBAutoCheckCallback d = new CBAutoCheckCallback(CBautoCheck);
        this.Invoke(d, new object[] { check });
      }
      else
      {
        CBauto.Checked = check;
      }
    }

    /// <summary>
    /// wenn angezeigt: Timer einschalten
    /// </summary>
    private void CfDaten_Shown(object sender, EventArgs e)
    {

#if CALLBACK
      SPort.DataReceived += SPort_DataReceived;
#else
      SPort.Write(Handshake, (int) HsCodes.hsStart, 1);
      timer1.Enabled = true;
#endif
    }

    /// <summary>
    /// 1x lesen
    /// </summary>
    private void BLesenClick(object sender, EventArgs e)
    {
      SetText(DatenLesen());
    }

    /// <summary>
    /// Timer: Daten lesen
    /// </summary>
    private void TTimTick(object sender, EventArgs e)
    {
      Timer tim = (Timer) sender;
      tim.Enabled = false;
      SetText(DatenLesen());
      tim.Enabled = true;
    }

    private void CBauto_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox cb = (CheckBox) sender;
      timer1.Enabled = cb.Checked;
    }
  }
}