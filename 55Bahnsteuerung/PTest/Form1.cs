using Borys.Bahn.CANguru.Com;
using System;
using System.Windows.Forms;

namespace PTest
{

  public partial class Form1 : Form
  {
    private int cbCmd = 1, cbLen = 4, cbSubcom = 9, cbSpeedH = 9, cbSpeedL = 10;

    private const byte cSTOP = 0x00, cGO = 0x01, cHALT = 0x02;
    private const byte tMM2 = 0x00, tDCC = 0xc0, tMFX = 0x40;
    private const byte lrBleibt = 0, lrVorwärts = 1, lrRückwärts = 2, lrUmschalten = 3;
    /* CAN-IDs */
    private const byte bSystem = 0, bDiscovery = 2, bMFXbind = 4, bGeschwindigkeit = 8, bRichtung = 0x0a, bFunktion = 0x0c, bAutomatisierung = 0x30,
      bBridgeInit = 0x88;
    private const string strIpCANBridge = "192.168.1.46";
    private byte[] Data = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    private cCANVerbindung CAN = null;
    private readonly byte[] BRIDGEINIT = { 0, bBridgeInit, 47, 11, 5, 0, 0, 0, 0, 0, 0, 0, 0 };
    /*
     * 00004711 5 00 00 00 00 00 Stopp an alle
     * 00004711 5 43 53 32 08 00 Stopp an bestimmten Teilnehmer (CS2 mit SNr. 08)
     */
    private byte[] STOP = { 0, bSystem, 47, 11, 5, 0, 0, 0, 0, cSTOP, 0, 0, 0 };
    private byte[] HALT = { 0, bSystem, 47, 11, 5, 0, 0, 0, 0, cHALT, 0, 0, 0 };
    private byte[] DISCOVER = { 0, bDiscovery, 47, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    /*
     * 00004711 5 00 00 00 00 01 Go an alle
     * 00004711 5 43 53 32 08 01 Go an bestimmten Teilnehmer (CS2 mit SNr. 04)
     */
    private byte[] GO = { 0, bSystem, 0x47, 0x11, 5, 0, 0, 0, 0, cGO, 0, 0, 0 };
    /* Beleuchtung
     * 0x00(0C)4B58   [06] 00 00 00 48 00 00 00 00
     * 0x00(0C)4B58   [06] 00 00 00 48 00 01 00 00 
     */
    private byte[] LichtAus = { 0, bFunktion, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 0, 0, 0, 0 };
    private byte[] LichtEin = { 0, bFunktion, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 0, 1, 0, 0 };
    /* Blinklicht  
     * 0x00(0C)4B58[06] 00 00 00 48 01 00 00 00 
     * 0x00(0C)4B58[06] 00 00 00 48 01 01 00 00
     */
    private byte[] BlinkAus = { 0, bFunktion, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 1, 0, 0, 0 };
    private byte[] BlinkEin = { 0, bFunktion, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 1, 1, 0, 0 };
    /*Richtungswechsel
     */
    private byte[] Vor = { 0, bRichtung, 0x4b, 0x58, 5, 0, 0, tMM2, 0x48, lrVorwärts, 0, 0, 0 };
    private byte[] Zurück = { 0, bRichtung, 0x4b, 0x58, 5, 0, 0, tMM2, 0x48, lrRückwärts, 0, 0, 0 };
    private byte[] Richtungswechsel = { 0, bRichtung, 0x4b, 0x58, 5, 0, 0, tMM2, 0x48, lrUmschalten, 0, 0, 0 };
    private byte[] RICHTUNGfragen = { 0, bRichtung, 0x4b, 0x58, 4, 0, 0, tMM2, 0x48, 0, 0, 0, 0 };

    /*Geschwindigkeit
     */
    private byte[] Langsam = { 0, bGeschwindigkeit, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 0, 0xff, 0, 0 };
    private byte[] Schnell = { 0, bGeschwindigkeit, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 3, 0xe7, 0, 0 };
    private byte[] V30 = { 0, bGeschwindigkeit, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 0, 153, 0, 0 };
    private byte[] V50 = { 0, bGeschwindigkeit, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 0, 255, 0, 0 };
    private byte[] V80 = { 0, bGeschwindigkeit, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 1, 0x98, 0, 0 };
    private byte[] V100 = { 0, bGeschwindigkeit, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 1, 0xfe, 0, 0 };
    private byte[] VMAX = { 0, bGeschwindigkeit, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 3, 0xe8, 0, 0 };
    private byte[] CANDatenEmpfangen;
    private string ReceiveString;

    public Form1()
    {
      InitializeComponent();
      timer1.Enabled = false;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int r;
      Button b = (Button)sender;
      b.Text = "??";
      r = CAN.Send(Data);
      b.Text = r.ToString();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Button button = (Button)sender;
      button.Text = "??";
      CANDatenEmpfangen = CAN.Receive();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Button button = (Button)sender;
      button.Text = "??";
      CAN.BeginReceive();
    }

    private void b30_Click(object sender, EventArgs e) => _ = CAN.Send(V30);

    private void b50_Click(object sender, EventArgs e) => _ = CAN.Send(V50);

    private void b80_Click(object sender, EventArgs e) => _ = CAN.Send(V80);

    private void b100_Click(object sender, EventArgs e) => _ = CAN.Send(V100);

    private void bmax_Click(object sender, EventArgs e) => _ = CAN.Send(VMAX);

    private void end_Click(object sender, EventArgs e)
    {

    }

    private void bInit_Click(object sender, EventArgs e)
    {
      Button b = (Button)sender;
      CAN = new cCANVerbindung(strIpCANBridge);
      _ = CAN.Send(BRIDGEINIT);
      timer1.Enabled = true;
      b.Enabled = false;
    }

    private void button1_Click(object sender, EventArgs e) => Close();

    private void bStop_Click(object sender, EventArgs e) => _ = CAN.Send(STOP);

    private void bRicht_Click(object sender, EventArgs e) => _ = CAN.Send(RICHTUNGfragen);

    private void bDisc_Click(object sender, EventArgs e) => _ = CAN.Send(DISCOVER);

    private void timer1_Tick(object sender, EventArgs e)
    {
      CANDatenEmpfangen = CAN.Receive();
      if(CANDatenEmpfangen != null)
      {
        pBlink1.Visible = !pBlink1.Visible;
        byte cmd = CANDatenEmpfangen[cbCmd];
        ReceiveString = (cmd & 0x01) == 1 ? "R: " : "";
        cmd = (byte)(cmd & 0xfe);
        switch(cmd)
        {
          case bMFXbind:
            ReceiveString += $"cmd: MFX Bind UID=0x{CANDatenEmpfangen[5]:x} {CANDatenEmpfangen[6]:x} {CANDatenEmpfangen[7]:x} {CANDatenEmpfangen[8]:x} SID=0x{CANDatenEmpfangen[9]:x} {CANDatenEmpfangen[10]:x}";
            break;
          case bFunktion:
            ReceiveString += $"cmd: 0x{cmd:x} Lokfunktion";
            break;
          case bGeschwindigkeit:
            ReceiveString += $"cmd: 0x{cmd:x} Geschwindigkeit";
            if(CANDatenEmpfangen[cbLen] == 6)
            {
              lSpeed.Text = $"v = {CANDatenEmpfangen[cbSpeedH]}+{CANDatenEmpfangen[cbSpeedL]}";
            }
            break;
          case bRichtung:
            ReceiveString += $"cmd: 0x{cmd:x} Richtung";
            switch(CANDatenEmpfangen[cbSubcom])
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
          case bSystem:
            ReceiveString += $"cmd: 0x{cmd:x} System ";
            byte scmd = CANDatenEmpfangen[cbSubcom];
            switch(scmd)
            {
              case cSTOP:
                ReceiveString += $"STOP";
                break;
              case cGO:
                ReceiveString += $"GO";
                break;
              case cHALT:
                ReceiveString += $"HALT";
                break;
              default:
                ReceiveString += $"{scmd:x}";
                break;
            }
            break;
          case bAutomatisierung:
            ReceiveString += $"cmd: 0x{cmd:x} Automatisierung";
            break;
          default:
            ReceiveString += $"cmd: 0x{cmd:x} ";
            break;
        }
        label1.Text = ReceiveString;
        pBlink2.Visible = !pBlink1.Visible;
      }
    }

    private void button9_Click(object sender, EventArgs e) => _ = CAN.Send(Schnell);

    private void bGo_Click(object sender, EventArgs e) => _ = CAN.Send(GO);

    private void bL1_Click(object sender, EventArgs e) => _ = CAN.Send(LichtAus);

    private void bL2_Click(object sender, EventArgs e) => _ = CAN.Send(LichtEin);

    private void button5_Click(object sender, EventArgs e) => _ = CAN.Send(BlinkAus);

    private void button4_Click_1(object sender, EventArgs e) => _ = CAN.Send(BlinkEin);

    private void button7_Click(object sender, EventArgs e) => _ = CAN.Send(Langsam);

    private void button8_Click(object sender, EventArgs e) => _ = CAN.Send(HALT);

    private void button6_Click(object sender, EventArgs e) => _ = CAN.Send(Richtungswechsel);

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      timer1.Enabled = false;
      if(CAN != null)
      {
        CAN.Dispose();
        CAN = null;
      }
    }
  }
}