namespace Borys.Bahn.Bahnsteuerung
{
  partial class fMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.speichernunterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.seitenansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tsmiEnde = new System.Windows.Forms.ToolStripMenuItem();
      this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rückgängigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.wiederholenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.ausschneidenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.kopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.einfügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.alleauswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.MIserielleSchnittstelle = new System.Windows.Forms.ToolStripMenuItem();
      this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.anpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inhaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.suchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.bTest = new System.Windows.Forms.Button();
      this.bDaten = new System.Windows.Forms.Button();
      this.bEnde = new System.Windows.Forms.Button();
      this.bWeichen = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lArduino = new System.Windows.Forms.Label();
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // statusStrip1
      // 
      this.statusStrip1.Font = new System.Drawing.Font("Noto Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 438);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
      this.statusStrip1.Size = new System.Drawing.Size(914, 22);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tssl1
      // 
      this.tssl1.Name = "tssl1";
      this.tssl1.Size = new System.Drawing.Size(159, 17);
      this.tssl1.Text = "nichts zu vermelden";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("Noto Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.extrasToolStripMenuItem,
            this.hilfeToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(914, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MS1_ItemClicked);
      // 
      // dateiToolStripMenuItem
      // 
      this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.toolStripSeparator,
            this.speichernToolStripMenuItem,
            this.speichernunterToolStripMenuItem,
            this.toolStripSeparator1,
            this.druckenToolStripMenuItem,
            this.seitenansichtToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsmiEnde});
      this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
      this.dateiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
      this.dateiToolStripMenuItem.Text = "&Datei";
      // 
      // neuToolStripMenuItem
      // 
      this.neuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neuToolStripMenuItem.Image")));
      this.neuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
      this.neuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.neuToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
      this.neuToolStripMenuItem.Text = "&Neu";
      // 
      // öffnenToolStripMenuItem
      // 
      this.öffnenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öffnenToolStripMenuItem.Image")));
      this.öffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
      this.öffnenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
      this.öffnenToolStripMenuItem.Text = "Ö&ffnen";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(198, 6);
      // 
      // speichernToolStripMenuItem
      // 
      this.speichernToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("speichernToolStripMenuItem.Image")));
      this.speichernToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
      this.speichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.speichernToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
      this.speichernToolStripMenuItem.Text = "&Speichern";
      // 
      // speichernunterToolStripMenuItem
      // 
      this.speichernunterToolStripMenuItem.Name = "speichernunterToolStripMenuItem";
      this.speichernunterToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
      this.speichernunterToolStripMenuItem.Text = "Speichern &unter";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
      // 
      // druckenToolStripMenuItem
      // 
      this.druckenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("druckenToolStripMenuItem.Image")));
      this.druckenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
      this.druckenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.druckenToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
      this.druckenToolStripMenuItem.Text = "&Drucken";
      // 
      // seitenansichtToolStripMenuItem
      // 
      this.seitenansichtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seitenansichtToolStripMenuItem.Image")));
      this.seitenansichtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.seitenansichtToolStripMenuItem.Name = "seitenansichtToolStripMenuItem";
      this.seitenansichtToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
      this.seitenansichtToolStripMenuItem.Text = "&Seitenansicht";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
      // 
      // tsmiEnde
      // 
      this.tsmiEnde.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsmiEnde.Name = "tsmiEnde";
      this.tsmiEnde.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.tsmiEnde.Size = new System.Drawing.Size(201, 22);
      this.tsmiEnde.Text = "&Beenden";
      this.tsmiEnde.Click += new System.EventHandler(this.TsmiEnde_Click);
      // 
      // bearbeitenToolStripMenuItem
      // 
      this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rückgängigToolStripMenuItem,
            this.wiederholenToolStripMenuItem,
            this.toolStripSeparator3,
            this.ausschneidenToolStripMenuItem,
            this.kopierenToolStripMenuItem,
            this.einfügenToolStripMenuItem,
            this.toolStripSeparator4,
            this.alleauswählenToolStripMenuItem});
      this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
      this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
      this.bearbeitenToolStripMenuItem.Text = "&Bearbeiten";
      // 
      // rückgängigToolStripMenuItem
      // 
      this.rückgängigToolStripMenuItem.Name = "rückgängigToolStripMenuItem";
      this.rückgängigToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.rückgängigToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
      this.rückgängigToolStripMenuItem.Text = "&Rückgängig";
      // 
      // wiederholenToolStripMenuItem
      // 
      this.wiederholenToolStripMenuItem.Name = "wiederholenToolStripMenuItem";
      this.wiederholenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.wiederholenToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
      this.wiederholenToolStripMenuItem.Text = "Wiede&rholen";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
      // 
      // ausschneidenToolStripMenuItem
      // 
      this.ausschneidenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ausschneidenToolStripMenuItem.Image")));
      this.ausschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ausschneidenToolStripMenuItem.Name = "ausschneidenToolStripMenuItem";
      this.ausschneidenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.ausschneidenToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
      this.ausschneidenToolStripMenuItem.Text = "&Ausschneiden";
      // 
      // kopierenToolStripMenuItem
      // 
      this.kopierenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopierenToolStripMenuItem.Image")));
      this.kopierenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
      this.kopierenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.kopierenToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
      this.kopierenToolStripMenuItem.Text = "&Kopieren";
      // 
      // einfügenToolStripMenuItem
      // 
      this.einfügenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("einfügenToolStripMenuItem.Image")));
      this.einfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
      this.einfügenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.einfügenToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
      this.einfügenToolStripMenuItem.Text = "&Einfügen";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(222, 6);
      // 
      // alleauswählenToolStripMenuItem
      // 
      this.alleauswählenToolStripMenuItem.Name = "alleauswählenToolStripMenuItem";
      this.alleauswählenToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
      this.alleauswählenToolStripMenuItem.Text = "&Alle auswählen";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIserielleSchnittstelle});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 20);
      this.toolStripMenuItem1.Text = "Einstellungen";
      // 
      // MIserielleSchnittstelle
      // 
      this.MIserielleSchnittstelle.Name = "MIserielleSchnittstelle";
      this.MIserielleSchnittstelle.Size = new System.Drawing.Size(250, 22);
      this.MIserielleSchnittstelle.Text = "serielle Schnittstelle";
      this.MIserielleSchnittstelle.Click += new System.EventHandler(this.MIserielleSchnittstelle_Click);
      // 
      // extrasToolStripMenuItem
      // 
      this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anpassenToolStripMenuItem,
            this.optionenToolStripMenuItem});
      this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
      this.extrasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.extrasToolStripMenuItem.Text = "E&xtras";
      // 
      // anpassenToolStripMenuItem
      // 
      this.anpassenToolStripMenuItem.Name = "anpassenToolStripMenuItem";
      this.anpassenToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
      this.anpassenToolStripMenuItem.Text = "&Anpassen";
      // 
      // optionenToolStripMenuItem
      // 
      this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
      this.optionenToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
      this.optionenToolStripMenuItem.Text = "&Optionen";
      // 
      // hilfeToolStripMenuItem
      // 
      this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inhaltToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.suchenToolStripMenuItem,
            this.toolStripSeparator5,
            this.infoToolStripMenuItem});
      this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
      this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
      this.hilfeToolStripMenuItem.Text = "&Hilfe";
      // 
      // inhaltToolStripMenuItem
      // 
      this.inhaltToolStripMenuItem.Name = "inhaltToolStripMenuItem";
      this.inhaltToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.inhaltToolStripMenuItem.Text = "I&nhalt";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // suchenToolStripMenuItem
      // 
      this.suchenToolStripMenuItem.Name = "suchenToolStripMenuItem";
      this.suchenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.suchenToolStripMenuItem.Text = "&Suchen";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(127, 6);
      // 
      // infoToolStripMenuItem
      // 
      this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
      this.infoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.infoToolStripMenuItem.Text = "Inf&o...";
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.AutoSize = true;
      this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.flowLayoutPanel1.Controls.Add(this.bTest);
      this.flowLayoutPanel1.Controls.Add(this.bDaten);
      this.flowLayoutPanel1.Controls.Add(this.bEnde);
      this.flowLayoutPanel1.Controls.Add(this.bWeichen);
      this.flowLayoutPanel1.Controls.Add(this.groupBox1);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(914, 414);
      this.flowLayoutPanel1.TabIndex = 2;
      // 
      // bTest
      // 
      this.bTest.Location = new System.Drawing.Point(3, 3);
      this.bTest.Name = "bTest";
      this.bTest.Size = new System.Drawing.Size(86, 23);
      this.bTest.TabIndex = 0;
      this.bTest.Text = "Test";
      this.bTest.UseVisualStyleBackColor = true;
      this.bTest.Click += new System.EventHandler(this.BTest_Click);
      // 
      // bDaten
      // 
      this.bDaten.Location = new System.Drawing.Point(95, 3);
      this.bDaten.Name = "bDaten";
      this.bDaten.Size = new System.Drawing.Size(86, 23);
      this.bDaten.TabIndex = 2;
      this.bDaten.Text = "Daten";
      this.bDaten.UseVisualStyleBackColor = true;
      this.bDaten.Click += new System.EventHandler(this.BDaten_Click);
      // 
      // bEnde
      // 
      this.bEnde.AutoSize = true;
      this.bEnde.Location = new System.Drawing.Point(187, 3);
      this.bEnde.Name = "bEnde";
      this.bEnde.Size = new System.Drawing.Size(86, 23);
      this.bEnde.TabIndex = 1;
      this.bEnde.Text = "Ende";
      this.bEnde.UseVisualStyleBackColor = true;
      this.bEnde.Click += new System.EventHandler(this.BEnde_Click);
      // 
      // bWeichen
      // 
      this.bWeichen.Location = new System.Drawing.Point(279, 3);
      this.bWeichen.Name = "bWeichen";
      this.bWeichen.Size = new System.Drawing.Size(86, 23);
      this.bWeichen.TabIndex = 3;
      this.bWeichen.Text = "Weichen";
      this.bWeichen.UseVisualStyleBackColor = true;
      this.bWeichen.Click += new System.EventHandler(this.bWeichen_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lArduino);
      this.groupBox1.Location = new System.Drawing.Point(371, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 100);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Status";
      // 
      // lArduino
      // 
      this.lArduino.AutoSize = true;
      this.lArduino.BackColor = System.Drawing.Color.Blue;
      this.lArduino.Location = new System.Drawing.Point(6, 16);
      this.lArduino.Name = "lArduino";
      this.lArduino.Size = new System.Drawing.Size(63, 13);
      this.lArduino.TabIndex = 0;
      this.lArduino.Text = "Arduino";
      // 
      // fMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(914, 460);
      this.ControlBox = false;
      this.Controls.Add(this.flowLayoutPanel1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Noto Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "fMain";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "fMain";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
      this.Shown += new System.EventHandler(this.FMainShown);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem speichernunterToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem druckenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem seitenansichtToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem tsmiEnde;
    private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rückgängigToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wiederholenToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem ausschneidenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem kopierenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem einfügenToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem alleauswählenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem anpassenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inhaltToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem suchenToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button bTest;
    private System.Windows.Forms.Button bEnde;
    private System.Windows.Forms.Button bDaten;
    private System.Windows.Forms.ToolStripStatusLabel tssl1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem MIserielleSchnittstelle;
    private System.Windows.Forms.Button bWeichen;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lArduino;
  }
}