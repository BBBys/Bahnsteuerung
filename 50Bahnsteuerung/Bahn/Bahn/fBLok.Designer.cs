namespace Borys.Bahn.Steuerprogramm
{
  partial class fBLok
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.lAddresse = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lLokName = new System.Windows.Forms.Label();
      this.pbBild = new System.Windows.Forms.PictureBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.bLicht = new System.Windows.Forms.Label();
      this.bBlinklicht = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbBild)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lAddresse);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.lLokName);
      this.panel1.Controls.Add(this.pbBild);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(318, 100);
      this.panel1.TabIndex = 2;
      // 
      // lAddresse
      // 
      this.lAddresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lAddresse.Location = new System.Drawing.Point(215, 20);
      this.lAddresse.Name = "lAddresse";
      this.lAddresse.Size = new System.Drawing.Size(63, 23);
      this.lAddresse.TabIndex = 4;
      this.lAddresse.Text = "Adresse:";
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(156, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 23);
      this.label1.TabIndex = 3;
      this.label1.Text = "Adresse:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // lLokName
      // 
      this.lLokName.AutoSize = true;
      this.lLokName.Dock = System.Windows.Forms.DockStyle.Top;
      this.lLokName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lLokName.Location = new System.Drawing.Point(150, 0);
      this.lLokName.Name = "lLokName";
      this.lLokName.Size = new System.Drawing.Size(90, 20);
      this.lLokName.TabIndex = 2;
      this.lLokName.Text = "Lok-Name";
      this.lLokName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // pbBild
      // 
      this.pbBild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBild.Dock = System.Windows.Forms.DockStyle.Left;
      this.pbBild.Image = global::Borys.Bahn.Steuerprogramm.Properties.Resources.Farm_Fresh_train;
      this.pbBild.InitialImage = global::Borys.Bahn.Steuerprogramm.Properties.Resources.Farm_Fresh_train;
      this.pbBild.Location = new System.Drawing.Point(0, 0);
      this.pbBild.Name = "pbBild";
      this.pbBild.Size = new System.Drawing.Size(150, 100);
      this.pbBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbBild.TabIndex = 1;
      this.pbBild.TabStop = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.flowLayoutPanel1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBox1.Location = new System.Drawing.Point(0, 100);
      this.groupBox1.MinimumSize = new System.Drawing.Size(0, 74);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(150, 75);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Funktionen";
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.bLicht);
      this.flowLayoutPanel1.Controls.Add(this.bBlinklicht);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
      this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 60);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(144, 60);
      this.flowLayoutPanel1.TabIndex = 0;
      // 
      // bLicht
      // 
      this.bLicht.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.bLicht.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.bLicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bLicht.Location = new System.Drawing.Point(3, 0);
      this.bLicht.Name = "bLicht";
      this.bLicht.Size = new System.Drawing.Size(50, 50);
      this.bLicht.TabIndex = 0;
      this.bLicht.Text = "Licht";
      this.bLicht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.bLicht.Click += new System.EventHandler(this.bLicht_Click);
      // 
      // bBlinklicht
      // 
      this.bBlinklicht.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.bBlinklicht.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.bBlinklicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bBlinklicht.Location = new System.Drawing.Point(59, 0);
      this.bBlinklicht.Name = "bBlinklicht";
      this.bBlinklicht.Size = new System.Drawing.Size(82, 50);
      this.bBlinklicht.TabIndex = 1;
      this.bBlinklicht.Text = "Blinklicht";
      this.bBlinklicht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.bBlinklicht.Click += new System.EventHandler(this.bBlinklicht_Click);
      // 
      // fBLok
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(318, 175);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximumSize = new System.Drawing.Size(320, 175);
      this.MinimumSize = new System.Drawing.Size(0, 175);
      this.Name = "fBLok";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "fBLok";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbBild)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.flowLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lLokName;
    private System.Windows.Forms.PictureBox pbBild;
    private System.Windows.Forms.Label lAddresse;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Label bLicht;
    private System.Windows.Forms.Label bBlinklicht;
  }
}