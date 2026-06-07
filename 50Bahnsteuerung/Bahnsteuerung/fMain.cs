using System.Configuration;
using Borys.Bahn.CANguru.Com;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace Borys.Bahn.Bahnsteuerung
{
  /// <summary>
  /// Global:
  /// Anlagenzeit
  /// Icons:
  /// <a href="https://www.flaticon.com/de/kostenlose-icons/aufgaben" title="aufgaben Icons">Aufgaben Icons erstellt von Freepik - Flaticon</a>
  /// <a href="https://www.flaticon.com/de/kostenlose-icons/config" title="config Icons">Config Icons erstellt von srip - Flaticon</a>
  /// <a href="https://www.flaticon.com/free-icons/leader" title="leader icons">Leader icons created by Freepik - Flaticon</a>
  /// <a href="https://www.flaticon.com/free-icons/switch" title="switch icons">Switch icons created by Freepik - Flaticon</a>
  /// <a href="https://www.flaticon.com/free-icons/emergency-stop" title="emergency stop icons">Emergency stop icons created by Smashicons - Flaticon</a>
  /// <a href="https://www.flaticon.com/de/kostenlose-icons/signalisierung" title="signalisierung Icons">Signalisierung Icons erstellt von Freepik - Flaticon</a>
  /// </summary>
  public partial class fMain : Form
  {public cAnlagenZeit AnlagenZeit =null;
    private List<cLok> LokListe = null;
    private  fKonfig fKonfig = null;
    private readonly fFahren fFahren = null;
    private readonly fSchalten fSchalten = null;
    /// <summary>
    /// Verbindungroutinen CAN-Bus
    /// </summary>
    private cCANVerbindung CAN = null;
    private readonly string strIpCANBridge;
    private readonly int BUTTONSIZE;
    private readonly byte[] BRIDGEINIT = { 0, CANKonstanten.bBridgeInit, 47, 11, 5, 0, 0, 0, 0, 0, 0, 0, 0 };
    internal static readonly string KONFIGDATEI = "Bahn.config";

    /// <summary>
    /// für Raspberry-Display: Size 800 x 454
    /// </summary>
    internal static string LokListeLesen(ref List<cLok> lokListe)
    {
      //    _ = MessageBox.Show(KONFIGDATEI, "Lokliste", MessageBoxButtons.OK, MessageBoxIcon.None);

      string ergebnis = null;
      try
      {
        using(TextReader reader = new StreamReader(KONFIGDATEI))
        {
          string zeile;
          zeile = reader.ReadLine();
          //_ = MessageBox.Show("1", "Lokliste", MessageBoxButtons.OK, MessageBoxIcon.None);

          if(zeile != null)
          {
            //wir haben Text
            //   _ = MessageBox.Show("2", "Lokliste", MessageBoxButtons.OK, MessageBoxIcon.None);

            do
            {
              if(zeile.StartsWith(cLok.LOKCONFIGSTART))
              {
                cLok lok;
                //  _ = MessageBox.Show("3", "Lokliste", MessageBoxButtons.OK, MessageBoxIcon.None);

                lok = new cLok(reader);
                //_ = MessageBox.Show("4", "Lokliste", MessageBoxButtons.OK, MessageBoxIcon.None);
                if(lok.Gültig)
                {
                  lokListe.Add(lok);//liest eine Lok-Konfiguration
                  ergebnis = "...gelesen";
                }//if gültig
                else
                {
                  lok.Dispose();
                  _ = MessageBox.Show($"{KONFIGDATEI}:\nFehler in Lok-Konfigurationsdaten", "Lok einlesen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  ergebnis = "...Fehler";
                }//else gültig}
              }//if LOKCONFIGSTART
              zeile = reader.ReadLine();
            } while(zeile != null);
          }//if zeile!=null
          else//Zeile != null
          {
            _ = MessageBox.Show($"{KONFIGDATEI}:\nLok-Konfigurationsdaten leer?", "Lok einlesen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ergebnis = "...Fehler";
          }//else//Zeile != null
        }//using
      }//try
      catch(FileNotFoundException fnf)
      {
        _ = MessageBox.Show(fnf.Message, "Lok einlesen", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ergebnis = "...Fehler";
      }
      //_ = MessageBox.Show("99", "Lokliste", MessageBoxButtons.OK, MessageBoxIcon.None);

      return ergebnis;
    }//LokListeLesen
    public fMain()
    {
      InitializeComponent();
      Text = Properties.Resources.Fenstertitel + " V" + Application.ProductVersion + ". ";
      strIpCANBridge = Properties.Settings.Default.IPCANBRIDGE;
      BUTTONSIZE = Properties.Settings.Default.BUTTONSIZE;
#if DEBUG
      Text += "DEBUGVERSION";
#else
      Text += Application.CompanyName + ": " + Application.ProductName;
#endif
      //_ = MessageBox.Show(Text, "Start", MessageBoxButtons.OK, MessageBoxIcon.None);

      Anordnen();
      fFahren = new fFahren();
      fSchalten = new fSchalten
      {
        //fFahren.ButtonSetzen = ButtonSetzen;
        ButtonSetzen = ButtonSetzen
      };
      //  _ = MessageBox.Show("1", "Start", MessageBoxButtons.OK, MessageBoxIcon.None);
      LokListe = new List<cLok>();
      LokListeLesen(ref LokListe);
      // _ = MessageBox.Show("2", "Start", MessageBoxButtons.OK, MessageBoxIcon.None);
      fFahren.Lokliste = LokListe;
      // _ = MessageBox.Show("fertig", "Start", MessageBoxButtons.OK, MessageBoxIcon.None);
      /*hier schon notwendige Initialisierungen*/
      AnlagenZeit = new cAnlagenZeit();
    }
    private void fMain_Resize(object sender, EventArgs e) => Anordnen();

   /// <summary>
   /// Buttons im Hauptfenster anordnen
   /// </summary>
   private void Anordnen()
    {
      int links, oben, rechts, mitte, unten;
      links = 1;
      oben = 1;
      rechts = Width;
      unten = Height;
      mitte = Width / 2;
      ButtonSetzen(bConfig, links, oben);
      links += BUTTONSIZE + 1;
      ButtonSetzen(bInit, links, oben);
      ButtonSetzen(bStop, rechts - 1 - BUTTONSIZE, oben);
      links = mitte - BUTTONSIZE - 1;
      oben += BUTTONSIZE + 1;
      ButtonSetzen(bFahren, links, oben);
      links += BUTTONSIZE + 1;
      ButtonSetzen(bSchalten, links, oben);
      ButtonSetzen(bClose, rechts - 1 - BUTTONSIZE, unten - 1 - BUTTONSIZE);

    }
    /// <summary>
    /// einen Button auf Position setzen und Größe anpassen
    /// </summary>
    /// <param name="b"></param>
    /// <param name="links"></param>
    /// <param name="oben"></param>
    private void ButtonSetzen(Button button, int links, int oben)
    {
      if(button is null)
        throw new ArgumentNullException(nameof(button));
      button.Left = links;
      button.Top = oben;
      button.Width = BUTTONSIZE;
      button.Height = BUTTONSIZE;
    }

    private void bFahren_Click(object sender, EventArgs e) => fFahren.Show();

    private void bSchalten_Click(object sender, EventArgs e) => fSchalten.Show();

    private void fMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      //timer1.Enabled = false;
      if(CAN != null)
      {
        CAN.Dispose();
        CAN = null;
      }
    }


    private void bStop_Click(object sender, EventArgs e)
    {
      if(CAN != null)
        CAN.Stop();
    }


    private void bCloseClick(object sender, EventArgs e) => Close();


    private void bInit_Click(object sender, EventArgs e)
    {
      Button b = (Button)sender;
      CAN = new cCANVerbindung(strIpCANBridge);
      _ = CAN.Send(BRIDGEINIT);
      if(CAN.Verbunden())
      {
        fFahren.CAN = CAN;
        fFahren.Lokliste = LokListe;
        bFahren.Enabled = true;
        bSchalten.Enabled = true;
        //timer1.Enabled = true;
        b.Enabled = false;
        b.BackColor = Color.Lime;
      }
      else
      {
        b.BackColor = Color.Yellow;
      }
    }

    private void bConfig_Click(object sender, EventArgs e)
    {
      if(fKonfig == null)
      {
        fKonfig = new fKonfig();
      }
      
      fKonfig.LokListe = LokListe;
      _ = fKonfig.ShowDialog();
      LokListe = fKonfig.LokListe;
    }
    /// <summary>
    /// Writes the given object instance to an XML file.
    /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
    /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [XmlIgnore] attribute.</para>
    /// <para>Object type must have a parameterless constructor.</para>
    /// </summary>
    /// <typeparam name="T">The type of object being written to the file.</typeparam>
    /// <param name="filePath">The file path to write the object instance to.</param>
    /// <param name="objectToWrite">The object instance to write to the file.</param>
    /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
    public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append) where T : new()
    {
      TextWriter writer = null;
      try
      {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        writer = new StreamWriter(filePath, append);
        serializer.Serialize(writer, objectToWrite);

      }
      finally
      {
        if(writer != null)
        {
          writer.Close();
        }
      }
    }

    /// <summary>
    /// Reads an object instance from an XML file.
    /// <para>Object type must have a parameterless constructor.</para>
    /// </summary>
    /// <typeparam name="T">The type of object to read from the file.</typeparam>
    /// <param name="filePath">The file path to read the object instance from.</param>
    /// <returns>Returns a new instance of the object read from the XML file.</returns>
    public static T ReadFromXmlFile<T>(string filePath) where T : new()
    {
      TextReader reader = null;
      try
      {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        reader = new StreamReader(filePath);
        return (T)serializer.Deserialize(reader);
      }
      finally
      {
        if(reader != null)
        {
          reader.Close();
        }
      }
    }

    private void fMain_Shown(object sender, EventArgs e)
    {
      tslZeit.Text = DateTime.Now.ToString();
      tslAZeit.Text = AnlagenZeit.Zeit;
    }
  }
}