namespace Borys.Bahn.Steuerprogramm
{
  partial class fBMeldung
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tbMeldungen = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // tbMeldungen
      // 
      this.tbMeldungen.BackColor = System.Drawing.SystemColors.Window;
      this.tbMeldungen.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbMeldungen.Location = new System.Drawing.Point(0, 0);
      this.tbMeldungen.Multiline = true;
      this.tbMeldungen.Name = "tbMeldungen";
      this.tbMeldungen.Size = new System.Drawing.Size(284, 261);
      this.tbMeldungen.TabIndex = 0;
      // 
      // fBMeldung
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.ControlBox = false;
      this.Controls.Add(this.tbMeldungen);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.Name = "fBMeldung";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Meldungen";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbMeldungen;
  }
}