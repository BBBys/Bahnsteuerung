using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace Borys.Bahn.Bahnsteuerung
{
  /// <summary>
  /// Konfigurationsformular
  /// </summary>
  public partial class fKonfig : Form
  {
    internal List<cLok> LokListe;


    public fKonfig() => InitializeComponent();

    private void bNLok_Click(object sender, EventArgs e)
    {
      cLok neue;
      neue = new cLok(tbName.Text, tbTyp.Text, pbBild.ImageLocation, pbBild.Image, tbAdresse.Text,
        tbF1.Text, tbF1Code.Text, tbF1a.Text, tbF1b.Text, tbF2.Text, tbF2Code.Text, tbF2a.Text, tbF2b.Text,
        tbS1.Text, tbS1Code.Text, tbS2.Text, tbS2Code.Text, tbS3.Text, tbS3Code.Text, tbS4.Text, tbS4Code.Text, tbS5.Text, tbS5Code.Text);
      if(neue.Gültig)
        LokListe.Add(neue);
      else
        neue.Dispose();
    }

    private void pbBild_Click(object sender, EventArgs e)
    {
      if(ofd1.ShowDialog() == DialogResult.OK)
      {
        pbBild.ImageLocation = ofd1.FileName;
      }
    }

    private void bKonfSpeich_Click(object sender, EventArgs e)
    {
      tslMeldung.Text = "speichern...";
      using(TextWriter writer = new StreamWriter(fMain.KONFIGDATEI))
        foreach(cLok lok in LokListe)
        {
          lok.Ausgeben(writer);
        }
      tslMeldung.Text = "...gespeichert";
    }

    private void tpLok_Click(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void bKonfLesen_Click(object sender, EventArgs e)
    {
      tslMeldung.Text = "lesen...";
      tslMeldung.Text = fMain.LokListeLesen(ref LokListe);
    }//bKonfLesen

  }
}