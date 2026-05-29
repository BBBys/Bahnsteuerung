namespace PTest
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.bBeginReceive = new System.Windows.Forms.Button();
      this.end = new System.Windows.Forms.Button();
      this.bInit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.bStop = new System.Windows.Forms.Button();
      this.bGo = new System.Windows.Forms.Button();
      this.bL1 = new System.Windows.Forms.Button();
      this.bL2 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button9 = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.bDisc = new System.Windows.Forms.Button();
      this.bRicht = new System.Windows.Forms.Button();
      this.lSpeed = new System.Windows.Forms.Label();
      this.pBlink1 = new System.Windows.Forms.Panel();
      this.pBlink2 = new System.Windows.Forms.Panel();
      this.b30 = new System.Windows.Forms.Button();
      this.b50 = new System.Windows.Forms.Button();
      this.b100 = new System.Windows.Forms.Button();
      this.b80 = new System.Windows.Forms.Button();
      this.bmax = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button1.Location = new System.Drawing.Point(12, 298);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 27);
      this.button1.TabIndex = 0;
      this.button1.Text = "Close";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(255, 12);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "send";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(174, 12);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "receive";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // bBeginReceive
      // 
      this.bBeginReceive.Location = new System.Drawing.Point(93, 12);
      this.bBeginReceive.Name = "bBeginReceive";
      this.bBeginReceive.Size = new System.Drawing.Size(75, 23);
      this.bBeginReceive.TabIndex = 3;
      this.bBeginReceive.Text = "begin";
      this.bBeginReceive.UseVisualStyleBackColor = true;
      this.bBeginReceive.Click += new System.EventHandler(this.button4_Click);
      // 
      // end
      // 
      this.end.Location = new System.Drawing.Point(116, 302);
      this.end.Name = "end";
      this.end.Size = new System.Drawing.Size(75, 23);
      this.end.TabIndex = 4;
      this.end.Text = "button5";
      this.end.UseVisualStyleBackColor = true;
      this.end.Click += new System.EventHandler(this.end_Click);
      // 
      // bInit
      // 
      this.bInit.Location = new System.Drawing.Point(12, 12);
      this.bInit.Name = "bInit";
      this.bInit.Size = new System.Drawing.Size(75, 23);
      this.bInit.TabIndex = 6;
      this.bInit.Text = "init";
      this.bInit.UseVisualStyleBackColor = true;
      this.bInit.Click += new System.EventHandler(this.bInit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 15);
      this.label1.TabIndex = 7;
      this.label1.Text = "label1";
      // 
      // bStop
      // 
      this.bStop.BackColor = System.Drawing.Color.Red;
      this.bStop.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bStop.Location = new System.Drawing.Point(351, 1);
      this.bStop.Name = "bStop";
      this.bStop.Size = new System.Drawing.Size(87, 78);
      this.bStop.TabIndex = 8;
      this.bStop.Text = "Stop";
      this.bStop.UseVisualStyleBackColor = false;
      this.bStop.Click += new System.EventHandler(this.bStop_Click);
      // 
      // bGo
      // 
      this.bGo.BackColor = System.Drawing.Color.Lime;
      this.bGo.Location = new System.Drawing.Point(351, 85);
      this.bGo.Name = "bGo";
      this.bGo.Size = new System.Drawing.Size(75, 23);
      this.bGo.TabIndex = 9;
      this.bGo.Text = "Go";
      this.bGo.UseVisualStyleBackColor = false;
      this.bGo.Click += new System.EventHandler(this.bGo_Click);
      // 
      // bL1
      // 
      this.bL1.Location = new System.Drawing.Point(12, 85);
      this.bL1.Name = "bL1";
      this.bL1.Size = new System.Drawing.Size(75, 23);
      this.bL1.TabIndex = 10;
      this.bL1.Text = "Licht aus";
      this.bL1.UseVisualStyleBackColor = true;
      this.bL1.Click += new System.EventHandler(this.bL1_Click);
      // 
      // bL2
      // 
      this.bL2.Location = new System.Drawing.Point(93, 85);
      this.bL2.Name = "bL2";
      this.bL2.Size = new System.Drawing.Size(75, 23);
      this.bL2.TabIndex = 11;
      this.bL2.Text = "Licht ein";
      this.bL2.UseVisualStyleBackColor = true;
      this.bL2.Click += new System.EventHandler(this.bL2_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(255, 85);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 13;
      this.button4.Text = "Blink ein";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click_1);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(174, 85);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(75, 23);
      this.button5.TabIndex = 12;
      this.button5.Text = "Blink aus";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(93, 114);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(75, 23);
      this.button6.TabIndex = 15;
      this.button6.Text = "Wechsel";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(15, 144);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(75, 23);
      this.button7.TabIndex = 14;
      this.button7.Text = "lansam";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(93, 56);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(75, 23);
      this.button8.TabIndex = 16;
      this.button8.Text = "Halt";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // button9
      // 
      this.button9.Location = new System.Drawing.Point(96, 143);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(75, 23);
      this.button9.TabIndex = 17;
      this.button9.Text = "schnell";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new System.EventHandler(this.button9_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 500;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // bDisc
      // 
      this.bDisc.Location = new System.Drawing.Point(12, 269);
      this.bDisc.Name = "bDisc";
      this.bDisc.Size = new System.Drawing.Size(75, 23);
      this.bDisc.TabIndex = 18;
      this.bDisc.Text = "Discover";
      this.bDisc.UseVisualStyleBackColor = true;
      this.bDisc.Click += new System.EventHandler(this.bDisc_Click);
      // 
      // bRicht
      // 
      this.bRicht.Location = new System.Drawing.Point(15, 114);
      this.bRicht.Name = "bRicht";
      this.bRicht.Size = new System.Drawing.Size(75, 23);
      this.bRicht.TabIndex = 19;
      this.bRicht.Text = "Richtung?";
      this.bRicht.UseVisualStyleBackColor = true;
      this.bRicht.Click += new System.EventHandler(this.bRicht_Click);
      // 
      // lSpeed
      // 
      this.lSpeed.AutoSize = true;
      this.lSpeed.Location = new System.Drawing.Point(177, 147);
      this.lSpeed.Name = "lSpeed";
      this.lSpeed.Size = new System.Drawing.Size(98, 15);
      this.lSpeed.TabIndex = 20;
      this.lSpeed.Text = "Geschwindigkeit?";
      // 
      // pBlink1
      // 
      this.pBlink1.BackColor = System.Drawing.Color.Yellow;
      this.pBlink1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pBlink1.Location = new System.Drawing.Point(15, 56);
      this.pBlink1.Name = "pBlink1";
      this.pBlink1.Size = new System.Drawing.Size(10, 10);
      this.pBlink1.TabIndex = 21;
      // 
      // pBlink2
      // 
      this.pBlink2.BackColor = System.Drawing.Color.Lime;
      this.pBlink2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pBlink2.Location = new System.Drawing.Point(31, 56);
      this.pBlink2.Name = "pBlink2";
      this.pBlink2.Size = new System.Drawing.Size(10, 10);
      this.pBlink2.TabIndex = 22;
      // 
      // b30
      // 
      this.b30.BackColor = System.Drawing.Color.Gold;
      this.b30.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b30.Location = new System.Drawing.Point(15, 173);
      this.b30.Name = "b30";
      this.b30.Size = new System.Drawing.Size(37, 23);
      this.b30.TabIndex = 23;
      this.b30.Text = "30";
      this.b30.UseVisualStyleBackColor = false;
      this.b30.Click += new System.EventHandler(this.b30_Click);
      // 
      // b50
      // 
      this.b50.BackColor = System.Drawing.Color.Gold;
      this.b50.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b50.Location = new System.Drawing.Point(53, 173);
      this.b50.Name = "b50";
      this.b50.Size = new System.Drawing.Size(37, 23);
      this.b50.TabIndex = 24;
      this.b50.Text = "50";
      this.b50.UseVisualStyleBackColor = false;
      this.b50.Click += new System.EventHandler(this.b50_Click);
      // 
      // b100
      // 
      this.b100.BackColor = System.Drawing.Color.Gold;
      this.b100.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b100.Location = new System.Drawing.Point(134, 173);
      this.b100.Name = "b100";
      this.b100.Size = new System.Drawing.Size(37, 23);
      this.b100.TabIndex = 26;
      this.b100.Text = "100";
      this.b100.UseVisualStyleBackColor = false;
      this.b100.Click += new System.EventHandler(this.b100_Click);
      // 
      // b80
      // 
      this.b80.BackColor = System.Drawing.Color.Gold;
      this.b80.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b80.Location = new System.Drawing.Point(96, 173);
      this.b80.Name = "b80";
      this.b80.Size = new System.Drawing.Size(37, 23);
      this.b80.TabIndex = 25;
      this.b80.Text = "80";
      this.b80.UseVisualStyleBackColor = false;
      this.b80.Click += new System.EventHandler(this.b80_Click);
      // 
      // bmax
      // 
      this.bmax.BackColor = System.Drawing.Color.Gold;
      this.bmax.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bmax.Location = new System.Drawing.Point(180, 173);
      this.bmax.Name = "bmax";
      this.bmax.Size = new System.Drawing.Size(41, 23);
      this.bmax.TabIndex = 27;
      this.bmax.Text = "max";
      this.bmax.UseVisualStyleBackColor = false;
      this.bmax.Click += new System.EventHandler(this.bmax_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.button1;
      this.ClientSize = new System.Drawing.Size(438, 337);
      this.Controls.Add(this.bmax);
      this.Controls.Add(this.b100);
      this.Controls.Add(this.b80);
      this.Controls.Add(this.b50);
      this.Controls.Add(this.b30);
      this.Controls.Add(this.pBlink2);
      this.Controls.Add(this.pBlink1);
      this.Controls.Add(this.lSpeed);
      this.Controls.Add(this.bRicht);
      this.Controls.Add(this.bDisc);
      this.Controls.Add(this.button9);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.bL2);
      this.Controls.Add(this.bL1);
      this.Controls.Add(this.bGo);
      this.Controls.Add(this.bStop);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.bInit);
      this.Controls.Add(this.end);
      this.Controls.Add(this.bBeginReceive);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button bBeginReceive;
    private System.Windows.Forms.Button end;
    private System.Windows.Forms.Button bInit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button bStop;
    private System.Windows.Forms.Button bGo;
    private System.Windows.Forms.Button bL1;
    private System.Windows.Forms.Button bL2;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button bDisc;
    private System.Windows.Forms.Button bRicht;
    private System.Windows.Forms.Label lSpeed;
    private System.Windows.Forms.Panel pBlink1;
    private System.Windows.Forms.Panel pBlink2;
    private System.Windows.Forms.Button b30;
    private System.Windows.Forms.Button b50;
    private System.Windows.Forms.Button b100;
    private System.Windows.Forms.Button b80;
    private System.Windows.Forms.Button bmax;
  }
}

