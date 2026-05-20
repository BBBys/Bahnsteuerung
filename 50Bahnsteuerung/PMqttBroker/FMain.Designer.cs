namespace PMqttBroker
{
  partial class FMain
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.bEnde = new System.Windows.Forms.Button();
      this.bStart = new System.Windows.Forms.Button();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.flowLayoutPanel1.Controls.Add(this.bEnde);
      this.flowLayoutPanel1.Controls.Add(this.bStart);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 319);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(782, 34);
      this.flowLayoutPanel1.TabIndex = 0;
      // 
      // bEnde
      // 
      this.bEnde.Location = new System.Drawing.Point(700, 3);
      this.bEnde.Name = "bEnde";
      this.bEnde.Size = new System.Drawing.Size(75, 23);
      this.bEnde.TabIndex = 0;
      this.bEnde.Text = "Ende";
      this.bEnde.UseVisualStyleBackColor = true;
      this.bEnde.Click += new System.EventHandler(this.bEnde_Click);
      // 
      // bStart
      // 
      this.bStart.Location = new System.Drawing.Point(619, 3);
      this.bStart.Name = "bStart";
      this.bStart.Size = new System.Drawing.Size(75, 23);
      this.bStart.TabIndex = 1;
      this.bStart.Text = "Start";
      this.bStart.UseVisualStyleBackColor = true;
      this.bStart.Click += new System.EventHandler(this.bStart_Click);
      // 
      // FMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(782, 353);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "FMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.flowLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button bEnde;
    private System.Windows.Forms.Button bStart;
  }
}

