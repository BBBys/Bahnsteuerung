using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Borys.Bahn.Bahnsteuerung
{
  /// <summary>
  /// eine Lok
  /// </summary>
  public class cLok : cBusObjekt, IDisposable
  {
    /// <summary>
    /// Konstante 0 als Byte
    /// </summary>
    private const byte BYTE0 = 0;
    private bool Disposed = false;
    /// <summary>
    /// Kennungen der Parameter auf der Datei
    /// </summary>
    private const string zNAME = "Name", zTYP = "Typ", zBILDPFAD = "Bildpfad", zFu1 = "Funktion1",
          zFu2 = "Funktion2", zAdr = "Adresse",
          zG1 = "Geschwindigkeit1", zG2 = "Geschwindigkeit2", zG3 = "Geschwindigkeit3",
          zG4 = "Geschwindigkeit4", zG5 = "Geschwindigkeit5", zKonf = "konfiguriert", zUser = "User";
    //    private readonly Image image;
    public readonly string Typ, BildPfad;
    internal readonly Image Bild;
    public const string LOKCONFIGSTART = "Lokstart", LOKCONFIGEND = "Lokend";
    /// <summary>
    /// Texte für Funktionen
    /// </summary>
    public readonly string F1, F1a, F1b, F2, F2a, F2b;
    /// <summary>
    /// Texte für Geschwindigkeiten
    /// </summary>
    public readonly string S1, S2, S3, S4, S5;
    private readonly string Konfiguriert;
    private readonly string User;
    public readonly byte F2Code, F1Code;
    public readonly uint S1Code, S2Code, S3Code, S4Code, S5Code;
    /// <summary>
    /// muss true sein, sonst hat was nicht geklappt
    /// </summary>
    private readonly bool gültig;
    /// <summary>
    /// Trennung zwischen Kennung und Parameter, deshalb darf kein $ in den Texten auftauchen
    /// </summary>
    private const char zTRENNER = '$';

    public bool Gültig => gültig;

    public cLok(string pName, string pTyp, string pBildPfad, Image pBild, string pAdresse,
      string pF1, string pF1Code, string pF1a, string pF1b, string pF2, string pF2Code, string pF2a, string pF2b,
      string pS1, string pS1Code, string pS2, string pS2Code, string pS3, string pS3Code, string pS4, string pS4Code, string pS5, string pS5Code)
    {
      gültig = true;
      Name = pName;
      Typ = pTyp;
      Adresse = Convert.ToUInt16(pAdresse);
      BildPfad = pBildPfad;
      Bild = pBild;
      F1 = pF1;
      F1a = pF1a;
      F1b = pF1b;
      F2 = pF2;
      F2a = pF2a;
      F2b = pF2b;
      S1 = pS1;
      S2 = pS2;
      S3 = pS3;
      S4 = pS4;
      S5 = pS5;
      Konfiguriert = DateTime.Now.ToString();
      User = Environment.UserName + "@" + Environment.UserDomainName;
      try
      {
        Adresse = pAdresse.Length < 1 ? BYTE0 : Convert.ToByte(pAdresse);
        F1Code = pF1Code.Length < 1 ? BYTE0 : Convert.ToByte(pF1Code);
        F2Code = pF2Code.Length < 1 ? BYTE0 : Convert.ToByte(pF2Code);
        S1Code = pS1Code.Length < 1 ? BYTE0 : Convert.ToUInt32(pS1Code);
        S2Code = pS2Code.Length < 1 ? BYTE0 : Convert.ToUInt32(pS2Code);
        S3Code = pS3Code.Length < 1 ? BYTE0 : Convert.ToUInt32(pS3Code);
        S4Code = pS4Code.Length < 1 ? BYTE0 : Convert.ToUInt32(pS4Code);
        S5Code = pS5Code.Length < 1 ? BYTE0 : Convert.ToUInt32(pS5Code);
      }
      catch(Exception e)
      {
        _ = MessageBox.Show(e.Message + "\n" + "Lok wird nicht gespeichert!", "Konvertierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        gültig = false;
      }
    }

    //public cLok(string sName, uint uiAdresse)
    //{
    //  base.Name = sName;
    //  Adresse = uiAdresse;

    //}

    public cLok() { }

    public cLok(TextReader reader)
    {
      string zeile;
      string[] teile, daten;
      gültig = false;
      //_ = MessageBox.Show("1", "cLok", MessageBoxButtons.OK, MessageBoxIcon.Information);
      while(reader.Peek() >= 0) //gibt nächstes Zeichen, nicht Anzahl!
      {
        zeile = reader.ReadLine();
        //_ = MessageBox.Show(zeile, "cLok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if(zeile.StartsWith(cLok.LOKCONFIGEND))
        {
          gültig = true;
          break;
        }
        teile = zeile.Split(zTRENNER);
        daten = teile[1].Split(';');
        if(teile[0].Equals(zNAME))
        {
          Name = teile[1];
        }

        if(teile[0].Equals(zTYP))
        {
          Typ = teile[1];
        }

        if(teile[0].Equals(zBILDPFAD))
        {
          BildPfad = teile[1];
        }

        if(teile[0].Equals(zFu1))
        {
          F1 = daten[0];
          F1a = daten[1];
          F1b = daten[2];
          F1Code = Convert.ToByte(daten[3]);
        }
        if(teile[0].Equals(zFu2))
        {
          F2 = daten[0];
          F2a = daten[1];
          F2b = daten[2];
          F2Code = Convert.ToByte(daten[3]);
        }

        if(teile[0].Equals(zG1))
        {
          S1 = daten[0];
          S1Code = Convert.ToUInt32(daten[1]);
        }

        if(teile[0].Equals(zG2))
        {
          S2 = daten[0];
          S2Code = Convert.ToUInt32(daten[1]);
        }

        if(teile[0].Equals(zG3))
        {
          S3 = daten[0];
          S3Code = Convert.ToUInt32(daten[1]);
        }

        if(teile[0].Equals(zG4))
        {
          S4 = daten[0];
          S4Code = Convert.ToUInt32(daten[1]);
        }
        if(teile[0].Equals(zG5))
        {
          S5 = daten[0];
          S5Code = Convert.ToUInt32(daten[1]);
        }

        if(teile[0].Equals(zKonf))
        {
          Konfiguriert = teile[1];
        }

        if(teile[0].Equals(zUser))
        {
          User = teile[1];
        }
        if(teile[0].Equals(zAdr))
        {
          Adresse = Convert.ToUInt16(teile[1]);
        }
      }
      //_ = MessageBox.Show("end", "Lokliste", MessageBoxButtons.OK, MessageBoxIcon.None);

    }

    //public cLok(string pName, string text, string pBild, Image image, string text1, string text2)
    //{
    //  Name = pName;
    //  Beschreibung = text;
    //  BildPfad = pBild;
    //  Bild = image;
    //}




    internal void Ausgeben(TextWriter writer)
    {
      if(writer == null)
      {
        throw new ArgumentNullException(nameof(writer));
      }
      writer.WriteLine(LOKCONFIGSTART);
      writer.WriteLine($"{zNAME}{zTRENNER}{Name}");
      writer.WriteLine($"{zTYP}{zTRENNER}{Typ}");
      writer.WriteLine($"{zBILDPFAD}{zTRENNER}{BildPfad}");
      writer.WriteLine($"{zAdr}{zTRENNER}{Adresse}");
      writer.WriteLine($"{zFu1}{zTRENNER}{F1};{F1a};{F1b};{F1Code}");
      writer.WriteLine($"{zFu2}{zTRENNER}{F2};{F2a};{F2b};{F2Code}");
      writer.WriteLine($"{zG1}{zTRENNER}{S1};{S1Code}");
      writer.WriteLine($"{zG2}{zTRENNER}{S2};{S2Code}");
      writer.WriteLine($"{zG3}{zTRENNER}{S3};{S3Code}");
      writer.WriteLine($"{zG4}{zTRENNER}{S4};{S4Code}");
      writer.WriteLine($"{zG5}{zTRENNER}{S5};{S5Code}");
      writer.WriteLine($"{zKonf}{zTRENNER}{Konfiguriert}");
      writer.WriteLine($"{zUser}{zTRENNER}{User}");
      writer.WriteLine(LOKCONFIGEND);
      writer.Flush();
    }
    #region IDisposable Member

    public void Dispose()
    {
      //if (!this.disposed)
      //    Knopf.Dispose();
      Dispose(true);
      Disposed = true;
      GC.SuppressFinalize(this);
    }
    ~cLok() { Dispose(false); }

    private void Dispose(bool disposing)
    {
      if(disposing)
      {
        //// free managed resources
        //if (managedResource != null)
        //{
        //  managedResource.Dispose();
        //  managedResource = null;
        //}
      }
    }
    #endregion
  }


}