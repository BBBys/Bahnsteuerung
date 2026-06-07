namespace Borys.Bahn.Bahnsteuerung
{
  partial class fSchalten
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSchalten));
      this.bClose = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tslZeit = new System.Windows.Forms.ToolStripStatusLabel();
      this.tslAZeit = new System.Windows.Forms.ToolStripStatusLabel();
      this.groupBox1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // bClose
      // 
      this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bClose.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bClose.Location = new System.Drawing.Point(647, 304);
      this.bClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.bClose.Name = "bClose";
      this.bClose.Size = new System.Drawing.Size(150, 150);
      this.bClose.TabIndex = 3;
      this.bClose.Text = "zurück";
      this.bClose.UseVisualStyleBackColor = true;
      this.bClose.Click += new System.EventHandler(this.bClose_Click);
      this.bClose.Resize += new System.EventHandler(this.bClose_Resize);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tableLayoutPanel1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(800, 100);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Szenario";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 5;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.Controls.Add(this.button1, 4, 0);
      this.tableLayoutPanel1.Controls.Add(this.button2, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.button4, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.button5, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 44);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 53);
      this.tableLayoutPanel1.TabIndex = 0;
      this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(25)))), ((int)(((byte)(155)))));
      this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(635, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(156, 47);
      this.button1.TabIndex = 0;
      this.button1.Text = "Nacht";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(28)))), ((int)(((byte)(150)))));
      this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button2.ForeColor = System.Drawing.Color.White;
      this.button2.Location = new System.Drawing.Point(477, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(152, 47);
      this.button2.TabIndex = 1;
      this.button2.Text = "Abend";
      this.button2.UseVisualStyleBackColor = false;
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(32)))));
      this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button3.Location = new System.Drawing.Point(319, 3);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(152, 47);
      this.button3.TabIndex = 2;
      this.button3.Text = "Mittag";
      this.button3.UseVisualStyleBackColor = false;
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(32)))));
      this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button4.ForeColor = System.Drawing.Color.Black;
      this.button4.Location = new System.Drawing.Point(161, 3);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(152, 47);
      this.button4.TabIndex = 3;
      this.button4.Text = "Morgen";
      this.button4.UseVisualStyleBackColor = false;
      // 
      // button5
      // 
      this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button5.Location = new System.Drawing.Point(3, 3);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(152, 47);
      this.button5.TabIndex = 4;
      this.button5.Text = "Echtzeit";
      this.button5.UseVisualStyleBackColor = true;
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
      this.statusStrip1.TabIndex = 16;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tslZeit
      // 
      this.tslZeit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tslZeit.Name = "tslZeit";
      this.tslZeit.Size = new System.Drawing.Size(44, 20);
      this.tslZeit.Text = "00:00";
      // 
      // tslAZeit
      // 
      this.tslAZeit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tslAZeit.Name = "tslAZeit";
      this.tslAZeit.Size = new System.Drawing.Size(40, 20);
      this.tslAZeit.Text = "??:??";
      // 
      // fSchalten
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(800, 454);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.bClose);
      this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximumSize = new System.Drawing.Size(800, 454);
      this.Name = "fSchalten";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "fSchalten";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Shown += new System.EventHandler(this.fSchalten_Shown);
      this.groupBox1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button bClose;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tslZeit;
    private System.Windows.Forms.ToolStripStatusLabel tslAZeit;
  }
}