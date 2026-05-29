namespace Borys.Bahn.Bahnsteuerung
{
  partial class fFahren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFahren));
            this.pRechts = new System.Windows.Forms.Panel();
            this.pbLok = new System.Windows.Forms.PictureBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bGo = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.gbLoks = new System.Windows.Forms.GroupBox();
            this.tlpLoks = new System.Windows.Forms.TableLayoutPanel();
            this.pbLok1 = new System.Windows.Forms.PictureBox();
            this.pbLok2 = new System.Windows.Forms.PictureBox();
            this.pbLok3 = new System.Windows.Forms.PictureBox();
            this.gbSteuer = new System.Windows.Forms.GroupBox();
            this.pBlink2 = new System.Windows.Forms.Panel();
            this.pBlink1 = new System.Windows.Forms.Panel();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.tlpF = new System.Windows.Forms.TableLayoutPanel();
            this.bF2b = new System.Windows.Forms.Button();
            this.bF2a = new System.Windows.Forms.Button();
            this.bF1b = new System.Windows.Forms.Button();
            this.bF1a = new System.Windows.Forms.Button();
            this.lF1 = new System.Windows.Forms.Label();
            this.lF2 = new System.Windows.Forms.Label();
            this.lTyp = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tlpSpeed = new System.Windows.Forms.TableLayoutPanel();
            this.bHalt = new System.Windows.Forms.Button();
            this.bmax = new System.Windows.Forms.Button();
            this.b100 = new System.Windows.Forms.Button();
            this.b80 = new System.Windows.Forms.Button();
            this.b50 = new System.Windows.Forms.Button();
            this.b30 = new System.Windows.Forms.Button();
            this.bVorwärts = new System.Windows.Forms.Button();
            this.bWechsel = new System.Windows.Forms.Button();
            this.bRückwärts = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pRechts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLok)).BeginInit();
            this.gbLoks.SuspendLayout();
            this.tlpLoks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLok1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLok2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLok3)).BeginInit();
            this.gbSteuer.SuspendLayout();
            this.tlpF.SuspendLayout();
            this.tlpSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pRechts
            // 
            this.pRechts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pRechts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pRechts.Controls.Add(this.pbLok);
            this.pRechts.Controls.Add(this.bClose);
            this.pRechts.Controls.Add(this.bGo);
            this.pRechts.Controls.Add(this.bStop);
            this.pRechts.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRechts.Location = new System.Drawing.Point(650, 0);
            this.pRechts.Name = "pRechts";
            this.pRechts.Size = new System.Drawing.Size(150, 454);
            this.pRechts.TabIndex = 13;
            // 
            // pbLok
            // 
            this.pbLok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLok.InitialImage = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.train;
            this.pbLok.Location = new System.Drawing.Point(0, 200);
            this.pbLok.Name = "pbLok";
            this.pbLok.Size = new System.Drawing.Size(146, 88);
            this.pbLok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLok.TabIndex = 44;
            this.pbLok.TabStop = false;
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(-4, 300);
            this.bClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(150, 150);
            this.bClose.TabIndex = 13;
            this.bClose.Text = "zurück";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bGo
            // 
            this.bGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGo.BackColor = System.Drawing.Color.Lime;
            this.bGo.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGo.Location = new System.Drawing.Point(-4, 157);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(150, 41);
            this.bGo.TabIndex = 12;
            this.bGo.Text = "fahren";
            this.bGo.UseVisualStyleBackColor = false;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // bStop
            // 
            this.bStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bStop.BackColor = System.Drawing.Color.Red;
            this.bStop.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStop.Location = new System.Drawing.Point(-4, 0);
            this.bStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(150, 150);
            this.bStop.TabIndex = 11;
            this.bStop.Text = "alles\r\nStopp!";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // gbLoks
            // 
            this.gbLoks.BackColor = System.Drawing.Color.LightGray;
            this.gbLoks.Controls.Add(this.tlpLoks);
            this.gbLoks.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLoks.Location = new System.Drawing.Point(0, 0);
            this.gbLoks.Name = "gbLoks";
            this.gbLoks.Size = new System.Drawing.Size(650, 104);
            this.gbLoks.TabIndex = 14;
            this.gbLoks.TabStop = false;
            this.gbLoks.Text = "Loks";
            // 
            // tlpLoks
            // 
            this.tlpLoks.BackColor = System.Drawing.Color.LightGray;
            this.tlpLoks.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpLoks.ColumnCount = 3;
            this.tlpLoks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLoks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLoks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLoks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLoks.Controls.Add(this.pbLok1, 0, 0);
            this.tlpLoks.Controls.Add(this.pbLok2, 1, 0);
            this.tlpLoks.Controls.Add(this.pbLok3, 2, 0);
            this.tlpLoks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLoks.Location = new System.Drawing.Point(3, 19);
            this.tlpLoks.Name = "tlpLoks";
            this.tlpLoks.RowCount = 1;
            this.tlpLoks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLoks.Size = new System.Drawing.Size(644, 82);
            this.tlpLoks.TabIndex = 0;
            // 
            // pbLok1
            // 
            this.pbLok1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLok1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLok1.Enabled = false;
            this.pbLok1.Image = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.DHG700;
            this.pbLok1.InitialImage = null;
            this.pbLok1.Location = new System.Drawing.Point(5, 5);
            this.pbLok1.Name = "pbLok1";
            this.pbLok1.Size = new System.Drawing.Size(206, 72);
            this.pbLok1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLok1.TabIndex = 0;
            this.pbLok1.TabStop = false;
            this.pbLok1.Tag = "0";
            this.pbLok1.Click += new System.EventHandler(this.pbLok1_Click);
            // 
            // pbLok2
            // 
            this.pbLok2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLok2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLok2.Enabled = false;
            this.pbLok2.Image = global::Borys.Bahn.Bahnsteuerung.Properties.Resources.Roco_72478_BR_212_001_2_DR;
            this.pbLok2.InitialImage = null;
            this.pbLok2.Location = new System.Drawing.Point(219, 5);
            this.pbLok2.Name = "pbLok2";
            this.pbLok2.Size = new System.Drawing.Size(206, 72);
            this.pbLok2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLok2.TabIndex = 1;
            this.pbLok2.TabStop = false;
            this.pbLok2.Click += new System.EventHandler(this.pbLok1_Click);
            // 
            // pbLok3
            // 
            this.pbLok3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLok3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLok3.Enabled = false;
            this.pbLok3.Image = global::Borys.Bahn.Bahnsteuerung.Properties.Resources._2016_06_18_09_26_58;
            this.pbLok3.InitialImage = null;
            this.pbLok3.Location = new System.Drawing.Point(433, 5);
            this.pbLok3.Name = "pbLok3";
            this.pbLok3.Size = new System.Drawing.Size(206, 72);
            this.pbLok3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLok3.TabIndex = 2;
            this.pbLok3.TabStop = false;
            this.pbLok3.Click += new System.EventHandler(this.pbLok1_Click);
            // 
            // gbSteuer
            // 
            this.gbSteuer.BackColor = System.Drawing.Color.Silver;
            this.gbSteuer.Controls.Add(this.pBlink2);
            this.gbSteuer.Controls.Add(this.pBlink1);
            this.gbSteuer.Controls.Add(this.tbMsg);
            this.gbSteuer.Controls.Add(this.tlpF);
            this.gbSteuer.Controls.Add(this.lTyp);
            this.gbSteuer.Controls.Add(this.lName);
            this.gbSteuer.Controls.Add(this.tlpSpeed);
            this.gbSteuer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSteuer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbSteuer.Location = new System.Drawing.Point(0, 104);
            this.gbSteuer.Name = "gbSteuer";
            this.gbSteuer.Size = new System.Drawing.Size(650, 350);
            this.gbSteuer.TabIndex = 15;
            this.gbSteuer.TabStop = false;
            this.gbSteuer.Text = "steuern";
            // 
            // pBlink2
            // 
            this.pBlink2.BackColor = System.Drawing.Color.Yellow;
            this.pBlink2.Location = new System.Drawing.Point(443, 6);
            this.pBlink2.Name = "pBlink2";
            this.pBlink2.Size = new System.Drawing.Size(10, 10);
            this.pBlink2.TabIndex = 48;
            this.pBlink2.Visible = false;
            // 
            // pBlink1
            // 
            this.pBlink1.BackColor = System.Drawing.Color.Yellow;
            this.pBlink1.Location = new System.Drawing.Point(429, 6);
            this.pBlink1.Name = "pBlink1";
            this.pBlink1.Size = new System.Drawing.Size(10, 10);
            this.pBlink1.TabIndex = 47;
            this.pBlink1.Visible = false;
            // 
            // tbMsg
            // 
            this.tbMsg.Cursor = System.Windows.Forms.Cursors.No;
            this.tbMsg.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbMsg.Location = new System.Drawing.Point(429, 19);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(218, 228);
            this.tbMsg.TabIndex = 0;
            // 
            // tlpF
            // 
            this.tlpF.AutoSize = true;
            this.tlpF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tlpF.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpF.ColumnCount = 3;
            this.tlpF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpF.Controls.Add(this.bF2b, 2, 1);
            this.tlpF.Controls.Add(this.bF2a, 1, 1);
            this.tlpF.Controls.Add(this.bF1b, 2, 0);
            this.tlpF.Controls.Add(this.bF1a, 1, 0);
            this.tlpF.Controls.Add(this.lF1, 0, 0);
            this.tlpF.Controls.Add(this.lF2, 0, 1);
            this.tlpF.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpF.Location = new System.Drawing.Point(14, 79);
            this.tlpF.Name = "tlpF";
            this.tlpF.RowCount = 2;
            this.tlpF.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpF.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpF.Size = new System.Drawing.Size(244, 81);
            this.tlpF.TabIndex = 46;
            // 
            // bF2b
            // 
            this.bF2b.AutoSize = true;
            this.bF2b.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bF2b.Location = new System.Drawing.Point(156, 44);
            this.bF2b.Name = "bF2b";
            this.bF2b.Size = new System.Drawing.Size(84, 33);
            this.bF2b.TabIndex = 5;
            this.bF2b.Text = "button2";
            this.bF2b.UseVisualStyleBackColor = true;
            this.bF2b.Visible = false;
            this.bF2b.Click += new System.EventHandler(this.bF2b_Click);
            // 
            // bF2a
            // 
            this.bF2a.AutoSize = true;
            this.bF2a.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bF2a.Location = new System.Drawing.Point(69, 44);
            this.bF2a.Name = "bF2a";
            this.bF2a.Size = new System.Drawing.Size(80, 33);
            this.bF2a.TabIndex = 4;
            this.bF2a.Text = "button1";
            this.bF2a.UseVisualStyleBackColor = true;
            this.bF2a.Visible = false;
            this.bF2a.Click += new System.EventHandler(this.bF2a_Click);
            // 
            // bF1b
            // 
            this.bF1b.AutoSize = true;
            this.bF1b.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bF1b.Location = new System.Drawing.Point(156, 4);
            this.bF1b.Name = "bF1b";
            this.bF1b.Size = new System.Drawing.Size(84, 33);
            this.bF1b.TabIndex = 1;
            this.bF1b.Text = "button2";
            this.bF1b.UseVisualStyleBackColor = true;
            this.bF1b.Visible = false;
            this.bF1b.Click += new System.EventHandler(this.bF1b_Click);
            // 
            // bF1a
            // 
            this.bF1a.AutoSize = true;
            this.bF1a.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bF1a.Location = new System.Drawing.Point(69, 4);
            this.bF1a.Name = "bF1a";
            this.bF1a.Size = new System.Drawing.Size(80, 33);
            this.bF1a.TabIndex = 0;
            this.bF1a.Text = "button1";
            this.bF1a.UseVisualStyleBackColor = true;
            this.bF1a.Visible = false;
            this.bF1a.Click += new System.EventHandler(this.bF1a_Click);
            // 
            // lF1
            // 
            this.lF1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lF1.AutoSize = true;
            this.lF1.Location = new System.Drawing.Point(4, 1);
            this.lF1.Name = "lF1";
            this.lF1.Size = new System.Drawing.Size(58, 39);
            this.lF1.TabIndex = 2;
            this.lF1.Text = "label1";
            this.lF1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lF1.Visible = false;
            // 
            // lF2
            // 
            this.lF2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lF2.AutoSize = true;
            this.lF2.Location = new System.Drawing.Point(4, 41);
            this.lF2.Name = "lF2";
            this.lF2.Size = new System.Drawing.Size(58, 39);
            this.lF2.TabIndex = 3;
            this.lF2.Text = "label1";
            this.lF2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lF2.Visible = false;
            // 
            // lTyp
            // 
            this.lTyp.AutoSize = true;
            this.lTyp.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTyp.Location = new System.Drawing.Point(9, 53);
            this.lTyp.Name = "lTyp";
            this.lTyp.Size = new System.Drawing.Size(28, 23);
            this.lTyp.TabIndex = 45;
            this.lTyp.Text = "--";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(6, 19);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(232, 33);
            this.lName.TabIndex = 44;
            this.lName.Text = "keine Lok gewählt";
            // 
            // tlpSpeed
            // 
            this.tlpSpeed.BackColor = System.Drawing.Color.DarkGray;
            this.tlpSpeed.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpSpeed.ColumnCount = 6;
            this.tlpSpeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSpeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSpeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSpeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSpeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSpeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSpeed.Controls.Add(this.bHalt, 0, 1);
            this.tlpSpeed.Controls.Add(this.bmax, 5, 1);
            this.tlpSpeed.Controls.Add(this.b100, 4, 1);
            this.tlpSpeed.Controls.Add(this.b80, 3, 1);
            this.tlpSpeed.Controls.Add(this.b50, 2, 1);
            this.tlpSpeed.Controls.Add(this.b30, 1, 1);
            this.tlpSpeed.Controls.Add(this.bVorwärts, 4, 0);
            this.tlpSpeed.Controls.Add(this.bWechsel, 2, 0);
            this.tlpSpeed.Controls.Add(this.bRückwärts, 0, 0);
            this.tlpSpeed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpSpeed.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpSpeed.Location = new System.Drawing.Point(3, 247);
            this.tlpSpeed.Name = "tlpSpeed";
            this.tlpSpeed.RowCount = 2;
            this.tlpSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSpeed.Size = new System.Drawing.Size(644, 100);
            this.tlpSpeed.TabIndex = 40;
            // 
            // bHalt
            // 
            this.bHalt.AutoSize = true;
            this.bHalt.BackColor = System.Drawing.Color.OrangeRed;
            this.bHalt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHalt.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHalt.Location = new System.Drawing.Point(4, 53);
            this.bHalt.MinimumSize = new System.Drawing.Size(100, 40);
            this.bHalt.Name = "bHalt";
            this.bHalt.Size = new System.Drawing.Size(100, 43);
            this.bHalt.TabIndex = 42;
            this.bHalt.Text = "Halt";
            this.bHalt.UseVisualStyleBackColor = false;
            this.bHalt.Click += new System.EventHandler(this.b30_Click);
            // 
            // bmax
            // 
            this.bmax.AutoSize = true;
            this.bmax.BackColor = System.Drawing.Color.Gold;
            this.bmax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmax.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmax.Location = new System.Drawing.Point(519, 53);
            this.bmax.MinimumSize = new System.Drawing.Size(100, 40);
            this.bmax.Name = "bmax";
            this.bmax.Size = new System.Drawing.Size(121, 43);
            this.bmax.TabIndex = 41;
            this.bmax.Text = "max";
            this.bmax.UseVisualStyleBackColor = false;
            this.bmax.Click += new System.EventHandler(this.b30_Click);
            // 
            // b100
            // 
            this.b100.AutoSize = true;
            this.b100.BackColor = System.Drawing.Color.Gold;
            this.b100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b100.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b100.Location = new System.Drawing.Point(416, 53);
            this.b100.MinimumSize = new System.Drawing.Size(100, 40);
            this.b100.Name = "b100";
            this.b100.Size = new System.Drawing.Size(100, 43);
            this.b100.TabIndex = 39;
            this.b100.Text = "00";
            this.b100.UseVisualStyleBackColor = false;
            this.b100.Click += new System.EventHandler(this.b30_Click);
            // 
            // b80
            // 
            this.b80.AutoSize = true;
            this.b80.BackColor = System.Drawing.Color.Gold;
            this.b80.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b80.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b80.Location = new System.Drawing.Point(313, 53);
            this.b80.MinimumSize = new System.Drawing.Size(100, 40);
            this.b80.Name = "b80";
            this.b80.Size = new System.Drawing.Size(100, 43);
            this.b80.TabIndex = 38;
            this.b80.Text = "00";
            this.b80.UseVisualStyleBackColor = false;
            this.b80.Click += new System.EventHandler(this.b30_Click);
            // 
            // b50
            // 
            this.b50.AutoSize = true;
            this.b50.BackColor = System.Drawing.Color.Gold;
            this.b50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b50.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b50.ForeColor = System.Drawing.Color.Black;
            this.b50.Location = new System.Drawing.Point(210, 53);
            this.b50.MinimumSize = new System.Drawing.Size(100, 40);
            this.b50.Name = "b50";
            this.b50.Size = new System.Drawing.Size(100, 43);
            this.b50.TabIndex = 37;
            this.b50.Text = "00";
            this.b50.UseVisualStyleBackColor = false;
            this.b50.Click += new System.EventHandler(this.b30_Click);
            // 
            // b30
            // 
            this.b30.AutoSize = true;
            this.b30.BackColor = System.Drawing.Color.Gold;
            this.b30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b30.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b30.Location = new System.Drawing.Point(107, 53);
            this.b30.MinimumSize = new System.Drawing.Size(100, 40);
            this.b30.Name = "b30";
            this.b30.Size = new System.Drawing.Size(100, 43);
            this.b30.TabIndex = 36;
            this.b30.Text = "00";
            this.b30.UseVisualStyleBackColor = false;
            this.b30.Click += new System.EventHandler(this.b30_Click);
            // 
            // bVorwärts
            // 
            this.bVorwärts.BackColor = System.Drawing.Color.Lime;
            this.tlpSpeed.SetColumnSpan(this.bVorwärts, 2);
            this.bVorwärts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bVorwärts.Location = new System.Drawing.Point(416, 4);
            this.bVorwärts.Name = "bVorwärts";
            this.bVorwärts.Size = new System.Drawing.Size(224, 42);
            this.bVorwärts.TabIndex = 43;
            this.bVorwärts.Text = "vorwärts -->";
            this.bVorwärts.UseVisualStyleBackColor = false;
            this.bVorwärts.Click += new System.EventHandler(this.bVorwärts_Click);
            // 
            // bWechsel
            // 
            this.bWechsel.BackColor = System.Drawing.Color.Yellow;
            this.tlpSpeed.SetColumnSpan(this.bWechsel, 2);
            this.bWechsel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bWechsel.Location = new System.Drawing.Point(210, 4);
            this.bWechsel.Name = "bWechsel";
            this.bWechsel.Size = new System.Drawing.Size(199, 42);
            this.bWechsel.TabIndex = 44;
            this.bWechsel.Text = "<--   -->";
            this.bWechsel.UseVisualStyleBackColor = false;
            this.bWechsel.Click += new System.EventHandler(this.bWechsel_Click);
            // 
            // bRückwärts
            // 
            this.bRückwärts.BackColor = System.Drawing.Color.Orange;
            this.tlpSpeed.SetColumnSpan(this.bRückwärts, 2);
            this.bRückwärts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRückwärts.Location = new System.Drawing.Point(4, 4);
            this.bRückwärts.Name = "bRückwärts";
            this.bRückwärts.Size = new System.Drawing.Size(199, 42);
            this.bRückwärts.TabIndex = 45;
            this.bRückwärts.Text = "<-- rückwärts";
            this.bRückwärts.UseVisualStyleBackColor = false;
            this.bRückwärts.Click += new System.EventHandler(this.bRückwärts_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fFahren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.gbSteuer);
            this.Controls.Add(this.gbLoks);
            this.Controls.Add(this.pRechts);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(800, 454);
            this.Name = "fFahren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fahrpult";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fFahren_FormClosing);
            this.Shown += new System.EventHandler(this.fFahren_Shown);
            this.pRechts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLok)).EndInit();
            this.gbLoks.ResumeLayout(false);
            this.tlpLoks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLok1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLok2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLok3)).EndInit();
            this.gbSteuer.ResumeLayout(false);
            this.gbSteuer.PerformLayout();
            this.tlpF.ResumeLayout(false);
            this.tlpF.PerformLayout();
            this.tlpSpeed.ResumeLayout(false);
            this.tlpSpeed.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel pRechts;
    private System.Windows.Forms.Button bClose;
    private System.Windows.Forms.Button bGo;
    private System.Windows.Forms.Button bStop;
    private System.Windows.Forms.GroupBox gbLoks;
    private System.Windows.Forms.TableLayoutPanel tlpLoks;
    private System.Windows.Forms.GroupBox gbSteuer;
    private System.Windows.Forms.TableLayoutPanel tlpSpeed;
    private System.Windows.Forms.Button bHalt;
    private System.Windows.Forms.Button bmax;
    private System.Windows.Forms.Button b100;
    private System.Windows.Forms.Button b80;
    private System.Windows.Forms.Button b50;
    private System.Windows.Forms.Button b30;
    private System.Windows.Forms.PictureBox pbLok1;
    private System.Windows.Forms.PictureBox pbLok2;
    private System.Windows.Forms.PictureBox pbLok3;
    private System.Windows.Forms.Label lName;
    private System.Windows.Forms.Label lTyp;
    private System.Windows.Forms.TableLayoutPanel tlpF;
    private System.Windows.Forms.Button bF1b;
    private System.Windows.Forms.Button bF1a;
    private System.Windows.Forms.Label lF1;
    private System.Windows.Forms.Button bF2b;
    private System.Windows.Forms.Button bF2a;
    private System.Windows.Forms.Label lF2;
    private System.Windows.Forms.PictureBox pbLok;
    private System.Windows.Forms.Button bVorwärts;
    private System.Windows.Forms.Button bWechsel;
    private System.Windows.Forms.Button bRückwärts;
    private System.Windows.Forms.TextBox tbMsg;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Panel pBlink1;
    private System.Windows.Forms.Panel pBlink2;
  }
}