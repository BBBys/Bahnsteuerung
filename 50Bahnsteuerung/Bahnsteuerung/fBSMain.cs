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
    public partial class fBSMain : Form
    {
        /// <summary>
        /// Status des Programms
        /// </summary>
        enum eStatus
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
        eStatus Status = eStatus.nichts;
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
        /// <summary>
        /// Port
        /// </summary>
        private string Comport;
        /// <summary>
        /// Baudrate, bei USB wohl unnötig
        /// </summary>
        private int Comrate;
        private Properties.Settings Props;
        private cCmd.StartbitUndBefehl Befehl;
        private cLoks Lokliste;
        private cCmds CmdListe;
        private const string CmdQuit = "!!q!!";
        private byte iTestadresse=28;
        /// <summary>
        /// Hauptformular Konstruktor
        /// </summary>
        public fBSMain()
        {
            InitializeComponent();
            Text = Properties.Resources.Fenstertitel + " V" + Application.ProductVersion + ". ";
#if DEBUG
            Text += "DEBUGVERSION";
#else
            Text += Application.CompanyName + ": " + Application.ProductName;
#endif
            #region Einstellungen
            Props = Properties.Settings.Default;
            Comport = Props.Comport;
            Comrate = Props.Comrate;

            cbPort.BeginUpdate();
            foreach (string s in SerialPort.GetPortNames())
            {
                cbPort.Items.Add(s);
            }
            cbPort.EndUpdate();
            cbPort.Text = Comport;
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
            Button b = (Button)sender;
            LokButtonsGrau(b);
            b.BackColor = Color.Yellow;
            Adresse = ((cLok)b.Tag).Adresse;
        }
        void CmdAuswahl(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            LokButtonsGrau(b);
            b.BackColor = Color.Yellow;
            Befehl = ((cCmd)b.Tag).Befehl;
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
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { sEin });
            }
            else
            {
                this.lDaten.Text = sEin;
                if (Status == eStatus.Go)
                {

                }
                else if (Status == eStatus.Start)
                {
                    if (sEin.Contains("IRIF"))
                    {
                        tsslVersion.Text = sEin;
                        sPort.WriteLine("go!");
                        Status = eStatus.Go;
                    }
                }
            }
        }

        /// <summary>
        /// Verbindung herstellen
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void bStart_Click(object sender, EventArgs e)
        {
            Status = eStatus.Start;
            sPort.PortName = Comport;
            sPort.BaudRate = Comrate;
            tssl1.Text = Comport + " öffnen...";
            try
            {
                sPort.Open();
                tssl1.Text = "geöffnet";
                //timer.Enabled = true;
            }
            catch (TimeoutException)
            {
                //timer.Enabled = false;
                tssl1.Text = "Timeout!";
                Status = eStatus.Ende;
            }
            catch (Exception ex)
            {
                //timer.Enabled = false;
                tssl1.Text = ex.Message;
                Status = eStatus.Ende;
            }
        }

        /// <summary>
        /// Callback: Daten angekommen
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String zeile = "";
            tssl1.Text = "erwarte Daten...";
            //int ib;
            //ib = SP1.BytesToRead;
            if (Status == eStatus.Ende) sPort.Close();
            else try
                {
                    zeile = sPort.ReadExisting();
                    tssl1.Text = "Daten OK: " + zeile.Length.ToString();
                }
                catch (TimeoutException) { tssl1.Text = "Timeout!"; Status = eStatus.Ende; }
                catch (Exception ex) { tssl1.Text = ex.Message; Status = eStatus.Ende; }
            SetText(zeile);
        }

        /// <summary>
        /// beenden
        /// </summary>
        private void bEnde_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
            {
                sPort.Write(CmdQuit);
                Status = eStatus.Ende;
                sPort.Close(); 
            }
            Close();
        }

        /// <summary>
        /// Callback: Kommunikationsfehler
        /// </summary>
        private void sPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.EventType.ToString());
        }

        /// <summary>
        /// Test: senden
        /// </summary>
        private void bSenden_Click(object sender, EventArgs e)
        {
            Byte[] senden = new Byte[5];
            senden[0] = (Byte)'c';
            senden[1] = (Byte)Befehl.SB2;
            senden[2] = (Byte)Adresse;
            senden[3] = (Byte)Befehl.B;
            senden[4] = (Byte)'!';
            sPort.Write(senden, 0, 5);
        }

        /// <summary>
        /// Port ausgewählt
        /// </summary>
        private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox cb = (ToolStripComboBox)sender;
            Comport = cb.Text;
            Props.Comport = Comport;
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
        private void button1_Click(object sender, EventArgs e)
        {
            lPch.Text = iTestadresse.ToString();
            try
            {
                Byte[] senden = new Byte[5];
                senden[0] = (Byte)'c';
                senden[1] = (Byte)Befehl.SB2;
                senden[2] = (Byte)iTestadresse++;
                senden[3] = (Byte)Befehl.B;
                senden[4] = (Byte)'!';
                sPort.Write(senden, 0, 5);
                if (sPort.BytesToWrite > 1)
                    lDaten.Text = "???";
            }
            catch (Exception exe) { tssl1.Text = exe.Message; }
        }
    }
}