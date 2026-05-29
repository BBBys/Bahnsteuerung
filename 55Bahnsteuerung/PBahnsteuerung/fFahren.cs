using Borys.Bahn.CANguru.Com;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Borys.Bahn.Bahnsteuerung
{
  /// <summary>
  /// Formular Fahrsteuerung
  /// </summary>
  public partial class fFahren : Form
  {
    //internal Action<Button, int, int> ButtonSetzen = null;
    private List<cLok> LListe;
    private readonly List<Button> BSListe;
    private cLok LokAktiv;
    private uint LokAdresse;
    internal cCANVerbindung CAN;
    private readonly PictureBox[] pictureBoxes = new PictureBox[3];
    private const Int32 MAXMELD=10;
    private string F1,F2;
    private byte F1Code,F2Code;
    private uint S1Code, S2Code, S3Code, S4Code, S5Code;
    private String[ ] Meldungen;
    internal List<cLok> Lokliste { get => LListe; set => SetLokliste(value); }

    private void SetLokliste(List<cLok> pListe)
    {
      int i;
      LListe = pListe;
      i = 0;
      foreach(cLok item in LListe)
      {
        //pictureBoxes[i].Image = item.Bild;
        pictureBoxes[i].Enabled = true;
        i++;
      }
    }

    //    private readonly int BUTTONSIZE;

    public fFahren()
    {
      int i;
      InitializeComponent();
      i = 0;
      pictureBoxes[i++] = pbLok1;
      pictureBoxes[i++] = pbLok2;
      pictureBoxes[i++] = pbLok3;
      BSListe = new List<Button> { bHalt, b30, b50, b80, b100, bmax };
      Meldungen = new String[ ] { ".", ".", ".", ".", ".", ".", ".", ".", ".", "." };//entsprechend MAXMELD
      tbMsg.Lines = Meldungen;
    }

    private void bClose_Click(object sender, EventArgs e) => Hide();

    private void bStop_Click(object sender, EventArgs e) => CAN.Stop();

    private void bHalt_Click(object sender, EventArgs e) => CAN.Send(LokAdresse, CANKonstanten.SPEED, 0);//_ = CAN.Send(LokAdresse, CANKonstanten.HALT);

    private void bRückwärts_Click(object sender, EventArgs e) => _ = CAN.Send(LokAdresse, CANKonstanten.ZURÜCK);

    private void bVorwärts_Click(object sender, EventArgs e) => _ = CAN.Send(LokAdresse, CANKonstanten.VOR);

    private void bWechsel_Click(object sender, EventArgs e) => _ = CAN.Send(LokAdresse, CANKonstanten.WECHSEL);
    /// <summary>
    /// Funktion 1 ein
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bF1a_Click(object sender, EventArgs e) => CAN.Send(LokAdresse, CANKonstanten.LOKFUNKTION, F1Code, 1);
    /// <summary>
    /// Funktion 1 aus
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bF1b_Click(object sender, EventArgs e) => CAN.Send(LokAdresse, CANKonstanten.LOKFUNKTION, F1Code, 0);
    /// <summary>
    /// Funktion 2 ein
    /// </summary>

    private void bF2a_Click(object sender, EventArgs e) => CAN.Send(LokAdresse, CANKonstanten.LOKFUNKTION, F2Code, 1);
    /// <summary>
    /// Funktion 2 aus
    /// </summary>

    private void bF2b_Click(object sender, EventArgs e) => CAN.Send(LokAdresse, CANKonstanten.LOKFUNKTION, F2Code, 0);

    private void fFahren_Shown(Object sender, EventArgs e) => timer1.Enabled = true;

    private void fFahren_FormClosing(Object sender, FormClosingEventArgs e) => timer1.Enabled = false;

    private void timer1_Tick(Object sender, EventArgs e)
    {
      Byte[ ] CANDatenEmpfangen =
        //Test {1,2,3,4,5,6,7,8,9,0,1,2,3 };//
        CAN.Receive();
      if(CANDatenEmpfangen != null)
      {
        pBlink1.Visible = !pBlink1.Visible;
        byte cmd = CANDatenEmpfangen[CANKonstanten.cbPRM];
        String ReceiveString = (cmd & 0x01) == 1 ? "R: " : "";
        cmd = (byte)(cmd & 0xfe);
        switch(cmd)
        {
          case CANKonstanten.bMFXbind:
            ReceiveString += $"cmd: MFX Bind UID=0x{CANDatenEmpfangen[5]:x} {CANDatenEmpfangen[6]:x} {CANDatenEmpfangen[7]:x} {CANDatenEmpfangen[8]:x} SID=0x{CANDatenEmpfangen[9]:x} {CANDatenEmpfangen[10]:x}";
            break;
          case CANKonstanten.bFunktion:
            ReceiveString += $"cmd: 0x{cmd:x} Lokfunktion";
            break;
          case CANKonstanten.bGeschwindigkeit:
            ReceiveString += $"cmd: 0x{cmd:x} Geschwindigkeit";
            if(CANDatenEmpfangen[CANKonstanten.cbPLen] == 6)
            {
              inTextBox($"v = {CANDatenEmpfangen[CANKonstanten.cbSpeedH]}+{CANDatenEmpfangen[CANKonstanten.cbSpeedL]}");
            }
            break;
          case CANKonstanten.bRichtung:
            ReceiveString += $"cmd: 0x{cmd:x} Richtung";
            switch(CANDatenEmpfangen[CANKonstanten.cbSubcom])
            {
              case 1:
                ReceiveString += $" vorwärts";
                break;
              case 2:
                ReceiveString += $" rückwärts";
                break;
              case 3:
                ReceiveString += $" wechseln";
                break;
              default:
                ReceiveString += $" bleibt";
                break;
            }
            break;
          case CANKonstanten.bSystem:
            ReceiveString += $"cmd: 0x{cmd:x} System ";
            byte scmd = CANDatenEmpfangen[CANKonstanten.cbSubcom];
            switch(scmd)
            {
              case CANKonstanten.cSTOP:
                ReceiveString += $"STOP";
                break;
              case CANKonstanten.cGO:
                ReceiveString += $"GO";
                break;
              case CANKonstanten.cHALT:
                ReceiveString += $"HALT";
                break;
              default:
                ReceiveString += $"{scmd:x}";
                break;
            }
            break;
          case CANKonstanten.bAutomatisierung:
            ReceiveString += $"cmd: 0x{cmd:x} Automatisierung";
            break;
          default:
            ReceiveString += $"cmd: 0x{cmd:x} ";
            break;
        }
        inTextBox(ReceiveString);
        pBlink2.Visible = !pBlink1.Visible;
      }
    }

    private void inTextBox(String v)
    {
      for(int i = 1; i < MAXMELD; i++)
      {
        Meldungen[i - 1] = Meldungen[i];
      }
      Meldungen[MAXMELD - 1] = v;
      tbMsg.Lines = Meldungen;
    }

    private void bGo_Click(object sender, EventArgs e) => CAN.Go();

    private void pbLok1_Click(object sender, EventArgs e)
    {
      PictureBox pb = (PictureBox)sender;
      pbLok.Image = pb.Image;
      int spalte = tlpLoks.GetColumn(pb);
      LokAktiv = Lokliste[spalte];
      LokAdresse = LokAktiv.Adresse;
      lName.Text = LokAktiv.Name;
      lTyp.Text = LokAktiv.Typ;
      F1 = LokAktiv.F1;
      if(F1 != null)
      {
        lF1.Visible = true;
        bF1a.Visible = true;
        bF1b.Visible = true;
        lF1.Text = F1;
        bF1a.Text = LokAktiv.F1a;
        bF1b.Text = LokAktiv.F1b;
        F1Code = LokAktiv.F1Code;
      }
      else
      {
        lF1.Visible = false;
        bF1a.Visible = false;
        bF1b.Visible = false;
      }
      F2 = LokAktiv.F2;
      if(F2 != null)
      {
        lF2.Visible = true;
        bF2a.Visible = true;
        bF2b.Visible = true;
        lF2.Text = F2;
        bF2a.Text = LokAktiv.F2a;
        bF2b.Text = LokAktiv.F2b;
        F2Code = LokAktiv.F2Code;
      }
      else
      {
        lF2.Visible = false;
        bF2a.Visible = false;
        bF2b.Visible = false;
      }
      BSListe[0].Tag = "Halt";
      BSListe[1].Tag = LokAktiv.S1;
      BSListe[2].Tag = LokAktiv.S2;
      BSListe[3].Tag = LokAktiv.S3;
      BSListe[4].Tag = LokAktiv.S4;
      BSListe[5].Tag = LokAktiv.S5;
      SpeedButtonZurück(BSListe);
      S1Code = LokAktiv.S1Code;
      S2Code = LokAktiv.S2Code;
      S3Code = LokAktiv.S3Code;
      S4Code = LokAktiv.S4Code;
      S5Code = LokAktiv.S5Code;

    }

    private void b30_Click(object sender, EventArgs e)
    {
      uint speed;
      Button b;
      int spalte;
      b = (Button)sender;
      SpeedButtonZurück(BSListe);
      spalte = tlpSpeed.GetColumn(b);
      switch(spalte)
      {
        case 0:
          speed = 0;  //Halt
          break;
        case 1:
          //    private byte[] V30 = { 0, bGeschwindigkeit, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 0, 153, 0, 0 };
          speed = S1Code;
          break;
        case 2:
          speed = S2Code;
          break;
        case 3:
          speed = S3Code;
          break;
        case 4:
          speed = S4Code;
          break;
        case 5:
          speed = S5Code;// 1000=Max, ergibt 0x03, 0xe8
          break;
        default:
          speed = 0;
          break;
      }
      if(CAN.Send(LokAdresse, CANKonstanten.SPEED, speed) > 0)
        b.Text = ">" + b.Tag + "<";
    }
    /// <summary>
    /// setzt die Markierung auf den Geschwindigkeits-Tasten zurück
    /// </summary>
    private void SpeedButtonZurück(List<Button> l)
    {
      foreach(Button b in l)
        b.Text = b.Tag.ToString();
    }
  }
}