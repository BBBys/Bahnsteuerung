namespace Borys.Bahn.Bahnsteuerung.PTouch
{
  partial class FTMain
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.button1 = new System.Windows.Forms.Button();
      this.bUmwelt = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.bExit = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tslZeit = new System.Windows.Forms.ToolStripStatusLabel();
      this.tableLayoutPanel1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.bUmwelt, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.bExit, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 450);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button1.Location = new System.Drawing.Point(3, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(397, 219);
      this.button1.TabIndex = 0;
      this.button1.Text = "Loks";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // bUmwelt
      // 
      this.bUmwelt.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bUmwelt.Location = new System.Drawing.Point(406, 3);
      this.bUmwelt.Name = "bUmwelt";
      this.bUmwelt.Size = new System.Drawing.Size(397, 219);
      this.bUmwelt.TabIndex = 1;
      this.bUmwelt.Text = "Umwelt";
      this.bUmwelt.UseVisualStyleBackColor = true;
      this.bUmwelt.Click += new System.EventHandler(this.bUmwelt_Click);
      // 
      // button3
      // 
      this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button3.Location = new System.Drawing.Point(3, 228);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(397, 219);
      this.button3.TabIndex = 2;
      this.button3.Text = "Anlage";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // bExit
      // 
      this.bExit.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bExit.Location = new System.Drawing.Point(406, 228);
      this.bExit.Name = "bExit";
      this.bExit.Size = new System.Drawing.Size(397, 219);
      this.bExit.TabIndex = 3;
      this.bExit.Text = "Exit";
      this.bExit.UseVisualStyleBackColor = true;
      this.bExit.Click += new System.EventHandler(this.button4_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslZeit});
      this.statusStrip1.Location = new System.Drawing.Point(0, 424);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(806, 26);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tslZeit
      // 
      this.tslZeit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tslZeit.Name = "tslZeit";
      this.tslZeit.Size = new System.Drawing.Size(44, 20);
      this.tslZeit.Text = "00:00";
      // 
      // FTMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(806, 450);
      this.ControlBox = false;
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FTMain";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Steuerung";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.tableLayoutPanel1.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button bUmwelt;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button bExit;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tslZeit;
  }
}

