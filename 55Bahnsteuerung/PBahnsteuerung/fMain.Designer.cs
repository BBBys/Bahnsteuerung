namespace Borys.Bahn.Bahnsteuerung
{
  partial class fMain
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
      if (disposing )
      {if(CAN!=null)
        CAN.Dispose();
        if (components != null)
        {
          components.Dispose();
        }
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
      this.bClose = new System.Windows.Forms.Button();
      this.bStop = new System.Windows.Forms.Button();
      this.bInit = new System.Windows.Forms.Button();
      this.bConfig = new System.Windows.Forms.Button();
      this.bFahren = new System.Windows.Forms.Button();
      this.bSchalten = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // bClose
      // 
      this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.bClose.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.das_ende;
      this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bClose.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bClose.Location = new System.Drawing.Point(616, 278);
      this.bClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.bClose.Name = "bClose";
      this.bClose.Size = new System.Drawing.Size(150, 150);
      this.bClose.TabIndex = 1;
      this.bClose.Text = "Ende";
      this.bClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.bClose.UseVisualStyleBackColor = true;
      this.bClose.Click += new System.EventHandler(this.button1_Click);
      // 
      // bStop
      // 
      this.bStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.bStop.BackColor = System.Drawing.Color.Red;
      this.bStop.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.emergency_stop;
      this.bStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.bStop.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bStop.Location = new System.Drawing.Point(638, 13);
      this.bStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.bStop.Name = "bStop";
      this.bStop.Size = new System.Drawing.Size(150, 150);
      this.bStop.TabIndex = 9;
      this.bStop.Text = "Stop";
      this.bStop.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.bStop.UseVisualStyleBackColor = false;
      this.bStop.Click += new System.EventHandler(this.bStop_Click);
      // 
      // bInit
      // 
      this.bInit.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.leader;
      this.bInit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bInit.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bInit.Location = new System.Drawing.Point(170, 1);
      this.bInit.Name = "bInit";
      this.bInit.Size = new System.Drawing.Size(150, 150);
      this.bInit.TabIndex = 11;
      this.bInit.Text = "Init";
      this.bInit.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.bInit.UseVisualStyleBackColor = true;
      this.bInit.Click += new System.EventHandler(this.bInit_Click);
      // 
      // bConfig
      // 
      this.bConfig.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.konfig;
      this.bConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bConfig.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bConfig.Location = new System.Drawing.Point(-3, -8);
      this.bConfig.Name = "bConfig";
      this.bConfig.Size = new System.Drawing.Size(150, 150);
      this.bConfig.TabIndex = 12;
      this.bConfig.Text = "Konfig";
      this.bConfig.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.bConfig.UseVisualStyleBackColor = true;
      this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
      // 
      // bFahren
      // 
      this.bFahren.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.train;
      this.bFahren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.bFahren.Enabled = false;
      this.bFahren.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bFahren.Location = new System.Drawing.Point(33, 179);
      this.bFahren.Name = "bFahren";
      this.bFahren.Size = new System.Drawing.Size(150, 150);
      this.bFahren.TabIndex = 13;
      this.bFahren.Text = "fahren";
      this.bFahren.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.bFahren.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.bFahren.UseVisualStyleBackColor = true;
      this.bFahren.Click += new System.EventHandler(this.bFahren_Click);
      // 
      // bSchalten
      // 
      this.bSchalten.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources._switch;
      this.bSchalten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bSchalten.Enabled = false;
      this.bSchalten.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bSchalten.Location = new System.Drawing.Point(189, 179);
      this.bSchalten.Name = "bSchalten";
      this.bSchalten.Size = new System.Drawing.Size(150, 150);
      this.bSchalten.TabIndex = 14;
      this.bSchalten.Text = "schalten";
      this.bSchalten.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.bSchalten.UseVisualStyleBackColor = true;
      this.bSchalten.Click += new System.EventHandler(this.bSchalten_Click);
      // 
      // fMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.bClose;
      this.ClientSize = new System.Drawing.Size(800, 454);
      this.Controls.Add(this.bSchalten);
      this.Controls.Add(this.bFahren);
      this.Controls.Add(this.bConfig);
      this.Controls.Add(this.bInit);
      this.Controls.Add(this.bStop);
      this.Controls.Add(this.bClose);
      this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximumSize = new System.Drawing.Size(800, 454);
      this.Name = "fMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Bahnsteuerung";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
      this.Resize += new System.EventHandler(this.fMain_Resize);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button bClose;
    private System.Windows.Forms.Button bStop;
    private System.Windows.Forms.Button bInit;
    private System.Windows.Forms.Button bConfig;
    private System.Windows.Forms.Button bFahren;
    private System.Windows.Forms.Button bSchalten;
  }
}

