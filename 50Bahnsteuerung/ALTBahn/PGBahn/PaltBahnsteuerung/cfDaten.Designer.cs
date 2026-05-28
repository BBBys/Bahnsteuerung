namespace Borys.Bahn.Bahnsteuerung
{
  partial class CfDaten
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
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Literale nicht als lokalisierte Parameter übergeben", MessageId = "System.Windows.Forms.ToolStripItem.set_Text(System.String)")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Literale nicht als lokalisierte Parameter übergeben", MessageId = "System.Windows.Forms.Control.set_Text(System.String)")]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.BClose = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.tbDaten = new System.Windows.Forms.TextBox();
      this.BLesen = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.CBauto = new System.Windows.Forms.CheckBox();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // BClose
      // 
      this.BClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BClose.Location = new System.Drawing.Point(713, 412);
      this.BClose.Name = "BClose";
      this.BClose.Size = new System.Drawing.Size(75, 23);
      this.BClose.TabIndex = 0;
      this.BClose.Text = "schließen";
      this.BClose.UseVisualStyleBackColor = true;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 438);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(800, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tssl1
      // 
      this.tssl1.Name = "tssl1";
      this.tssl1.Size = new System.Drawing.Size(12, 17);
      this.tssl1.Text = "?";
      // 
      // tbDaten
      // 
      this.tbDaten.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbDaten.Location = new System.Drawing.Point(12, 12);
      this.tbDaten.Multiline = true;
      this.tbDaten.Name = "tbDaten";
      this.tbDaten.Size = new System.Drawing.Size(776, 394);
      this.tbDaten.TabIndex = 3;
      this.tbDaten.Text = "noch\r\nkeine\r\nDaten";
      // 
      // BLesen
      // 
      this.BLesen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BLesen.Location = new System.Drawing.Point(632, 412);
      this.BLesen.Name = "BLesen";
      this.BLesen.Size = new System.Drawing.Size(75, 23);
      this.BLesen.TabIndex = 4;
      this.BLesen.Text = "lesen";
      this.BLesen.UseVisualStyleBackColor = true;
      this.BLesen.Click += new System.EventHandler(this.BLesenClick);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.TTimTick);
      // 
      // CBauto
      // 
      this.CBauto.AutoSize = true;
      this.CBauto.Checked = true;
      this.CBauto.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CBauto.Location = new System.Drawing.Point(576, 415);
      this.CBauto.Name = "CBauto";
      this.CBauto.Size = new System.Drawing.Size(50, 19);
      this.CBauto.TabIndex = 5;
      this.CBauto.Text = "auto";
      this.CBauto.UseVisualStyleBackColor = true;
      this.CBauto.CheckedChanged += new System.EventHandler(this.CBauto_CheckedChanged);
      // 
      // CfDaten
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.BClose;
      this.ClientSize = new System.Drawing.Size(800, 460);
      this.ControlBox = false;
      this.Controls.Add(this.CBauto);
      this.Controls.Add(this.BLesen);
      this.Controls.Add(this.tbDaten);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.BClose);
      this.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CfDaten";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Datenausgabe";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CfDaten_FormClosing);
      this.Shown += new System.EventHandler(this.CfDaten_Shown);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BClose;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tssl1;
    private System.Windows.Forms.TextBox tbDaten;
    private System.Windows.Forms.Button BLesen;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.CheckBox CBauto;
  }
}