namespace Borys.Bahn.Bahnsteuerung
{
    partial class CfTest
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
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.bStart = new System.Windows.Forms.ToolStripButton();
      this.bEnde = new System.Windows.Forms.ToolStripButton();
      this.bSenden = new System.Windows.Forms.ToolStripButton();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.lPch = new System.Windows.Forms.Label();
      this.lDaten = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.button1 = new System.Windows.Forms.Button();
      this.flpCmd = new System.Windows.Forms.FlowLayoutPanel();
      this.flpLoks = new System.Windows.Forms.FlowLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.toolStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bStart,
            this.bEnde,
            this.bSenden});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(800, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // bStart
      // 
      this.bStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.bStart.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.bStart.Name = "bStart";
      this.bStart.Size = new System.Drawing.Size(35, 22);
      this.bStart.Text = "Start";
      this.bStart.Click += new System.EventHandler(this.BStart_Click);
      // 
      // bEnde
      // 
      this.bEnde.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.bEnde.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.bEnde.Name = "bEnde";
      this.bEnde.Size = new System.Drawing.Size(37, 22);
      this.bEnde.Text = "Ende";
      this.bEnde.Click += new System.EventHandler(this.BEnde_Click);
      // 
      // bSenden
      // 
      this.bSenden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.bSenden.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.bSenden.Name = "bSenden";
      this.bSenden.Size = new System.Drawing.Size(49, 22);
      this.bSenden.Text = "senden";
      this.bSenden.Click += new System.EventHandler(this.BSenden_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1,
            this.tsslVersion});
      this.statusStrip1.Location = new System.Drawing.Point(0, 458);
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
      // tsslVersion
      // 
      this.tsslVersion.Name = "tsslVersion";
      this.tsslVersion.Size = new System.Drawing.Size(44, 17);
      this.tsslVersion.Text = "V0.0.00";
      // 
      // lPch
      // 
      this.lPch.AutoSize = true;
      this.lPch.Location = new System.Drawing.Point(12, 43);
      this.lPch.Name = "lPch";
      this.lPch.Size = new System.Drawing.Size(29, 15);
      this.lPch.TabIndex = 2;
      this.lPch.Text = "lPch";
      // 
      // lDaten
      // 
      this.lDaten.AutoSize = true;
      this.lDaten.Location = new System.Drawing.Point(12, 69);
      this.lDaten.Name = "lDaten";
      this.lDaten.Size = new System.Drawing.Size(41, 15);
      this.lDaten.TabIndex = 3;
      this.lDaten.Text = "lDaten";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.flpCmd);
      this.groupBox1.Controls.Add(this.flpLoks);
      this.groupBox1.Location = new System.Drawing.Point(298, 88);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(350, 328);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Bedienung";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(269, 294);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 27);
      this.button1.TabIndex = 2;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // flpCmd
      // 
      this.flpCmd.Location = new System.Drawing.Point(97, 22);
      this.flpCmd.Name = "flpCmd";
      this.flpCmd.Size = new System.Drawing.Size(247, 265);
      this.flpCmd.TabIndex = 1;
      // 
      // flpLoks
      // 
      this.flpLoks.Location = new System.Drawing.Point(6, 22);
      this.flpLoks.Name = "flpLoks";
      this.flpLoks.Size = new System.Drawing.Size(85, 299);
      this.flpLoks.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.panel1.BackgroundImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.maerklin_schatten;
      this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.panel1.Location = new System.Drawing.Point(0, 395);
      this.panel1.MinimumSize = new System.Drawing.Size(146, 60);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(146, 60);
      this.panel1.TabIndex = 5;
      // 
      // CfTest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 480);
      this.ControlBox = false;
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.lDaten);
      this.Controls.Add(this.lPch);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.toolStrip1);
      this.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CfTest";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Start";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CfTest_FormClosing);
      this.Shown += new System.EventHandler(this.CfTest_Shown);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
        private System.Windows.Forms.ToolStripButton bEnde;
        private System.Windows.Forms.ToolStripButton bSenden;
        private System.Windows.Forms.Label lPch;
        private System.Windows.Forms.Label lDaten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpLoks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpCmd;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.Panel panel1;
    }
}

