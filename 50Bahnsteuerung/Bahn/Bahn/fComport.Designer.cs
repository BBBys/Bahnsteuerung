namespace Borys.Bahn.Steuerprogramm
{
    partial class fComport
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
      this.components = new System.ComponentModel.Container();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.lOpen = new System.Windows.Forms.Label();
      this.lClosed = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cbPort = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cbSpeed = new System.Windows.Forms.ComboBox();
      this.bVerbinden = new System.Windows.Forms.Button();
      this.bTrennen = new System.Windows.Forms.Button();
      this.bSchliessen = new System.Windows.Forms.Button();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.stStrip = new System.Windows.Forms.StatusStrip();
      this.lMeldung = new System.Windows.Forms.ToolStripStatusLabel();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.stStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.85965F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.14035F));
      this.tableLayoutPanel1.Controls.Add(this.lOpen, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.lClosed, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.cbPort, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.cbSpeed, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.bVerbinden, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.bTrennen, 1, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 119);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // lOpen
      // 
      this.lOpen.AutoSize = true;
      this.lOpen.BackColor = System.Drawing.Color.Lime;
      this.lOpen.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lOpen.ForeColor = System.Drawing.Color.Black;
      this.lOpen.Location = new System.Drawing.Point(5, 91);
      this.lOpen.Name = "lOpen";
      this.lOpen.Size = new System.Drawing.Size(61, 26);
      this.lOpen.TabIndex = 11;
      this.lOpen.Text = "verbunden";
      this.lOpen.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.lOpen.Visible = false;
      // 
      // lClosed
      // 
      this.lClosed.AutoSize = true;
      this.lClosed.BackColor = System.Drawing.Color.Black;
      this.lClosed.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lClosed.ForeColor = System.Drawing.Color.White;
      this.lClosed.Location = new System.Drawing.Point(5, 64);
      this.lClosed.Name = "lClosed";
      this.lClosed.Size = new System.Drawing.Size(61, 25);
      this.lClosed.TabIndex = 9;
      this.lClosed.Text = "getrennt";
      this.lClosed.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.lClosed.Visible = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Right;
      this.label1.Location = new System.Drawing.Point(37, 2);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 29);
      this.label1.TabIndex = 0;
      this.label1.Text = "Port:";
      // 
      // cbPort
      // 
      this.cbPort.Dock = System.Windows.Forms.DockStyle.Top;
      this.cbPort.FormattingEnabled = true;
      this.cbPort.Location = new System.Drawing.Point(74, 5);
      this.cbPort.Name = "cbPort";
      this.cbPort.Size = new System.Drawing.Size(208, 21);
      this.cbPort.TabIndex = 1;
      this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Right;
      this.label2.Location = new System.Drawing.Point(13, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 29);
      this.label2.TabIndex = 2;
      this.label2.Text = "Baudrate:";
      // 
      // cbSpeed
      // 
      this.cbSpeed.Dock = System.Windows.Forms.DockStyle.Top;
      this.cbSpeed.FormattingEnabled = true;
      this.cbSpeed.Items.AddRange(new object[] {
            "110",
            "150",
            "300",
            "562",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "115200"});
      this.cbSpeed.Location = new System.Drawing.Point(74, 36);
      this.cbSpeed.Name = "cbSpeed";
      this.cbSpeed.Size = new System.Drawing.Size(208, 21);
      this.cbSpeed.TabIndex = 3;
      this.cbSpeed.SelectedIndexChanged += new System.EventHandler(this.cbSpeed_SelectedIndexChanged);
      // 
      // bVerbinden
      // 
      this.bVerbinden.Location = new System.Drawing.Point(74, 67);
      this.bVerbinden.Name = "bVerbinden";
      this.bVerbinden.Size = new System.Drawing.Size(75, 19);
      this.bVerbinden.TabIndex = 10;
      this.bVerbinden.Text = "verbinden";
      this.bVerbinden.UseVisualStyleBackColor = true;
      this.bVerbinden.Click += new System.EventHandler(this.bVerbinden_Click);
      // 
      // bTrennen
      // 
      this.bTrennen.Location = new System.Drawing.Point(74, 94);
      this.bTrennen.Name = "bTrennen";
      this.bTrennen.Size = new System.Drawing.Size(75, 20);
      this.bTrennen.TabIndex = 12;
      this.bTrennen.Text = "trennen";
      this.bTrennen.UseVisualStyleBackColor = true;
      this.bTrennen.Click += new System.EventHandler(this.bTrennen_Click);
      // 
      // bSchliessen
      // 
      this.bSchliessen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.bSchliessen.Location = new System.Drawing.Point(207, 126);
      this.bSchliessen.Name = "bSchliessen";
      this.bSchliessen.Size = new System.Drawing.Size(75, 23);
      this.bSchliessen.TabIndex = 3;
      this.bSchliessen.Text = "schließen";
      this.bSchliessen.UseVisualStyleBackColor = true;
      this.bSchliessen.Click += new System.EventHandler(this.bSchliessen_Click);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // stStrip
      // 
      this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lMeldung});
      this.stStrip.Location = new System.Drawing.Point(0, 152);
      this.stStrip.Name = "stStrip";
      this.stStrip.Size = new System.Drawing.Size(287, 22);
      this.stStrip.TabIndex = 4;
      this.stStrip.Text = "statusStrip1";
      // 
      // lMeldung
      // 
      this.lMeldung.Name = "lMeldung";
      this.lMeldung.Size = new System.Drawing.Size(272, 17);
      this.lMeldung.Spring = true;
      this.lMeldung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // fComport
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(287, 174);
      this.Controls.Add(this.stStrip);
      this.Controls.Add(this.bSchliessen);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "fComport";
      this.Text = "fComport";
      this.Activated += new System.EventHandler(this.fComport_Activated);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fComport_FormClosing);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.stStrip.ResumeLayout(false);
      this.stStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSpeed;
        private System.Windows.Forms.Button bSchliessen;
    private System.Windows.Forms.Label lOpen;
    private System.Windows.Forms.Label lClosed;
    private System.Windows.Forms.Button bVerbinden;
    private System.Windows.Forms.Button bTrennen;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.StatusStrip stStrip;
    private System.Windows.Forms.ToolStripStatusLabel lMeldung;
  }
}