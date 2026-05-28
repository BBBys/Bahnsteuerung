namespace Borys.Bahn.Bahnsteuerung
{
  partial class FSchnittstelle
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
      this.BVerbergen = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.cbPort = new System.Windows.Forms.ComboBox();
      this.Bsuchen = new System.Windows.Forms.Button();
      this.Böffnen = new System.Windows.Forms.Button();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // BVerbergen
      // 
      this.BVerbergen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BVerbergen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BVerbergen.Location = new System.Drawing.Point(220, 38);
      this.BVerbergen.Name = "BVerbergen";
      this.BVerbergen.Size = new System.Drawing.Size(75, 23);
      this.BVerbergen.TabIndex = 0;
      this.BVerbergen.Text = "OK";
      this.BVerbergen.UseVisualStyleBackColor = true;
      this.BVerbergen.Click += new System.EventHandler(this.BVerbergen_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 68);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(307, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tssl1
      // 
      this.tssl1.Name = "tssl1";
      this.tssl1.Size = new System.Drawing.Size(113, 17);
      this.tssl1.Text = "nichts zu vermelden";
      // 
      // cbPort
      // 
      this.cbPort.FormattingEnabled = true;
      this.cbPort.Location = new System.Drawing.Point(93, 9);
      this.cbPort.Name = "cbPort";
      this.cbPort.Size = new System.Drawing.Size(121, 23);
      this.cbPort.TabIndex = 2;
      this.cbPort.SelectedIndexChanged += new System.EventHandler(this.CbPort_SelectedIndexChanged);
      // 
      // Bsuchen
      // 
      this.Bsuchen.Location = new System.Drawing.Point(12, 8);
      this.Bsuchen.Name = "Bsuchen";
      this.Bsuchen.Size = new System.Drawing.Size(75, 23);
      this.Bsuchen.TabIndex = 3;
      this.Bsuchen.Text = "suchen";
      this.Bsuchen.UseVisualStyleBackColor = true;
      this.Bsuchen.Click += new System.EventHandler(this.Bsuchen_Click);
      // 
      // Böffnen
      // 
      this.Böffnen.Location = new System.Drawing.Point(220, 8);
      this.Böffnen.Name = "Böffnen";
      this.Böffnen.Size = new System.Drawing.Size(75, 23);
      this.Böffnen.TabIndex = 4;
      this.Böffnen.Text = "öffnen";
      this.Böffnen.UseVisualStyleBackColor = true;
      this.Böffnen.Click += new System.EventHandler(this.Böffnen_Click);
      // 
      // FSchnittstelle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.BVerbergen;
      this.ClientSize = new System.Drawing.Size(307, 90);
      this.Controls.Add(this.Böffnen);
      this.Controls.Add(this.Bsuchen);
      this.Controls.Add(this.cbPort);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.BVerbergen);
      this.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(800, 456);
      this.MinimizeBox = false;
      this.Name = "FSchnittstelle";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "serielle Schnittstelle";
      this.TopMost = true;
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BVerbergen;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tssl1;
    private System.Windows.Forms.ComboBox cbPort;
    private System.Windows.Forms.Button Bsuchen;
    private System.Windows.Forms.Button Böffnen;
  }
}