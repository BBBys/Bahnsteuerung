namespace Borys.Bahsteuerung.PTouch
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
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
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
      this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.button4, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 433);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button1.Location = new System.Drawing.Point(3, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(385, 210);
      this.button1.TabIndex = 0;
      this.button1.Text = "Loks";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button2.Location = new System.Drawing.Point(394, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(385, 210);
      this.button2.TabIndex = 1;
      this.button2.Text = "Umwelt";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button3.Location = new System.Drawing.Point(3, 219);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(385, 211);
      this.button3.TabIndex = 2;
      this.button3.Text = "Anlage";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button4.Location = new System.Drawing.Point(394, 219);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(385, 211);
      this.button4.TabIndex = 3;
      this.button4.Text = "Exit";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslZeit});
      this.statusStrip1.Location = new System.Drawing.Point(0, 407);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(782, 26);
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
      this.ClientSize = new System.Drawing.Size(782, 433);
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
      this.tableLayoutPanel1.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tslZeit;
  }
}

