namespace Borys.Bahn.Steuerprogramm
{
  partial class fBSystem
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
      this.bStrom = new System.Windows.Forms.Label();
      this.lStopp = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // bStrom
      // 
      this.bStrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.bStrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.bStrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bStrom.Location = new System.Drawing.Point(12, 9);
      this.bStrom.Name = "bStrom";
      this.bStrom.Size = new System.Drawing.Size(50, 50);
      this.bStrom.TabIndex = 1;
      this.bStrom.Text = "Strom";
      this.bStrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.bStrom.Click += new System.EventHandler(this.bStrom_Click);
      // 
      // lStopp
      // 
      this.lStopp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lStopp.BackColor = System.Drawing.Color.Red;
      this.lStopp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lStopp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.lStopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lStopp.ForeColor = System.Drawing.Color.White;
      this.lStopp.Location = new System.Drawing.Point(67, 11);
      this.lStopp.Name = "lStopp";
      this.lStopp.Size = new System.Drawing.Size(91, 50);
      this.lStopp.TabIndex = 2;
      this.lStopp.Text = "STOPP";
      this.lStopp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lStopp.Click += new System.EventHandler(this.lStopp_Click);
      // 
      // fBSystem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(170, 70);
      this.ControlBox = false;
      this.Controls.Add(this.lStopp);
      this.Controls.Add(this.bStrom);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximumSize = new System.Drawing.Size(170, 70);
      this.MinimumSize = new System.Drawing.Size(170, 70);
      this.Name = "fBSystem";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "System";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label bStrom;
    private System.Windows.Forms.Label lStopp;
  }
}