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
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tslZeit = new System.Windows.Forms.ToolStripStatusLabel();
      this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
      this.bHäuser = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.bClose = new System.Windows.Forms.Button();
      this.bStop = new System.Windows.Forms.Button();
      this.bSchalten = new System.Windows.Forms.Button();
      this.bConfig = new System.Windows.Forms.Button();
      this.bFahren = new System.Windows.Forms.Button();
      this.bInit = new System.Windows.Forms.Button();
      this.tslAZeit = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusStrip1.SuspendLayout();
      this.tlp1.SuspendLayout();
      this.SuspendLayout();
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslZeit,
            this.tslAZeit});
      this.statusStrip1.Location = new System.Drawing.Point(0, 428);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(800, 26);
      this.statusStrip1.TabIndex = 15;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tslZeit
      // 
      this.tslZeit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tslZeit.Name = "tslZeit";
      this.tslZeit.Size = new System.Drawing.Size(44, 20);
      this.tslZeit.Text = "00:00";
      // 
      // tlp1
      // 
      this.tlp1.ColumnCount = 4;
      this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlp1.Controls.Add(this.bHäuser, 2, 0);
      this.tlp1.Controls.Add(this.button4, 2, 1);
      this.tlp1.Controls.Add(this.bClose, 3, 1);
      this.tlp1.Controls.Add(this.bStop, 3, 0);
      this.tlp1.Controls.Add(this.bSchalten, 1, 1);
      this.tlp1.Controls.Add(this.bConfig, 0, 1);
      this.tlp1.Controls.Add(this.bFahren, 1, 0);
      this.tlp1.Controls.Add(this.bInit, 0, 0);
      this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlp1.Location = new System.Drawing.Point(0, 0);
      this.tlp1.Name = "tlp1";
      this.tlp1.RowCount = 2;
      this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlp1.Size = new System.Drawing.Size(800, 428);
      this.tlp1.TabIndex = 16;
      // 
      // bHäuser
      // 
      this.bHäuser.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.steuerungHäuser;
      this.bHäuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bHäuser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bHäuser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bHäuser.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bHäuser.Location = new System.Drawing.Point(403, 4);
      this.bHäuser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.bHäuser.Name = "bHäuser";
      this.bHäuser.Size = new System.Drawing.Size(194, 206);
      this.bHäuser.TabIndex = 25;
      this.bHäuser.Text = " ";
      this.bHäuser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.bHäuser.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.einstellung;
      this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button4.Enabled = false;
      this.button4.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.Location = new System.Drawing.Point(403, 217);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(194, 208);
      this.button4.TabIndex = 24;
      this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.bSchalten_Click);
      // 
      // bClose
      // 
      this.bClose.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.das_ende;
      this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bClose.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bClose.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bClose.Location = new System.Drawing.Point(603, 218);
      this.bClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.bClose.Name = "bClose";
      this.bClose.Size = new System.Drawing.Size(194, 206);
      this.bClose.TabIndex = 22;
      this.bClose.Text = " ";
      this.bClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.bClose.UseVisualStyleBackColor = true;
      this.bClose.Click += new System.EventHandler(this.bCloseClick);
      // 
      // bStop
      // 
      this.bStop.BackColor = System.Drawing.Color.Red;
      this.bStop.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.emergency_stop;
      this.bStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.bStop.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bStop.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bStop.Location = new System.Drawing.Point(603, 4);
      this.bStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.bStop.Name = "bStop";
      this.bStop.Size = new System.Drawing.Size(194, 206);
      this.bStop.TabIndex = 20;
      this.bStop.Text = "Stop";
      this.bStop.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.bStop.UseVisualStyleBackColor = false;
      this.bStop.Click += new System.EventHandler(this.bStop_Click);
      // 
      // bSchalten
      // 
      this.bSchalten.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources._switch;
      this.bSchalten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bSchalten.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bSchalten.Enabled = false;
      this.bSchalten.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bSchalten.Location = new System.Drawing.Point(203, 217);
      this.bSchalten.Name = "bSchalten";
      this.bSchalten.Size = new System.Drawing.Size(194, 208);
      this.bSchalten.TabIndex = 17;
      this.bSchalten.Text = "schalten";
      this.bSchalten.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.bSchalten.UseVisualStyleBackColor = true;
      this.bSchalten.Click += new System.EventHandler(this.bSchalten_Click);
      // 
      // bConfig
      // 
      this.bConfig.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.konfig;
      this.bConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bConfig.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bConfig.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bConfig.Location = new System.Drawing.Point(3, 217);
      this.bConfig.Name = "bConfig";
      this.bConfig.Size = new System.Drawing.Size(194, 208);
      this.bConfig.TabIndex = 16;
      this.bConfig.Text = "Konfig";
      this.bConfig.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.bConfig.UseVisualStyleBackColor = true;
      this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
      // 
      // bFahren
      // 
      this.bFahren.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.train;
      this.bFahren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.bFahren.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bFahren.Enabled = false;
      this.bFahren.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bFahren.Location = new System.Drawing.Point(203, 3);
      this.bFahren.Name = "bFahren";
      this.bFahren.Size = new System.Drawing.Size(194, 208);
      this.bFahren.TabIndex = 14;
      this.bFahren.Text = " ";
      this.bFahren.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.bFahren.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.bFahren.UseVisualStyleBackColor = true;
      this.bFahren.Click += new System.EventHandler(this.bFahren_Click);
      // 
      // bInit
      // 
      this.bInit.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.leader;
      this.bInit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bInit.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bInit.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bInit.Location = new System.Drawing.Point(3, 3);
      this.bInit.Name = "bInit";
      this.bInit.Size = new System.Drawing.Size(194, 208);
      this.bInit.TabIndex = 12;
      this.bInit.Text = "Init";
      this.bInit.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.bInit.UseVisualStyleBackColor = true;
      this.bInit.Click += new System.EventHandler(this.bInit_Click);
      // 
      // tslAZeit
      // 
      this.tslAZeit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tslAZeit.Name = "tslAZeit";
      this.tslAZeit.Size = new System.Drawing.Size(40, 20);
      this.tslAZeit.Text = "??:??";
      // 
      // fMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(800, 454);
      this.Controls.Add(this.tlp1);
      this.Controls.Add(this.statusStrip1);
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
      this.Shown += new System.EventHandler(this.fMain_Shown);
      this.Resize += new System.EventHandler(this.fMain_Resize);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.tlp1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tslZeit;
    private System.Windows.Forms.TableLayoutPanel tlp1;
    private System.Windows.Forms.Button bSchalten;
    private System.Windows.Forms.Button bConfig;
    private System.Windows.Forms.Button bFahren;
    private System.Windows.Forms.Button bInit;
    private System.Windows.Forms.Button bClose;
    private System.Windows.Forms.Button bStop;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button bHäuser;
    private System.Windows.Forms.ToolStripStatusLabel tslAZeit;
  }
}

