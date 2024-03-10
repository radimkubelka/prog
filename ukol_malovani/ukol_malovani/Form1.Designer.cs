namespace ukol_malovani
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxx = new System.Windows.Forms.TextBox();
            this.textBoxy = new System.Windows.Forms.TextBox();
            this.textBoxs = new System.Windows.Forms.TextBox();
            this.textBoxv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonf = new System.Windows.Forms.Button();
            this.buttont = new System.Windows.Forms.Button();
            this.buttong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(272, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 757);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nové plátno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Výběr barvy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(119, 61);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(146, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tloušťka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Souřadnice X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Šířka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Výška";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Výplň";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxx
            // 
            this.textBoxx.Location = new System.Drawing.Point(119, 134);
            this.textBoxx.Name = "textBoxx";
            this.textBoxx.Size = new System.Drawing.Size(84, 22);
            this.textBoxx.TabIndex = 11;
            // 
            // textBoxy
            // 
            this.textBoxy.Location = new System.Drawing.Point(119, 168);
            this.textBoxy.Name = "textBoxy";
            this.textBoxy.Size = new System.Drawing.Size(84, 22);
            this.textBoxy.TabIndex = 12;
            // 
            // textBoxs
            // 
            this.textBoxs.Location = new System.Drawing.Point(119, 200);
            this.textBoxs.Name = "textBoxs";
            this.textBoxs.Size = new System.Drawing.Size(84, 22);
            this.textBoxs.TabIndex = 13;
            // 
            // textBoxv
            // 
            this.textBoxv.Location = new System.Drawing.Point(119, 233);
            this.textBoxv.Name = "textBoxv";
            this.textBoxv.Size = new System.Drawing.Size(84, 22);
            this.textBoxv.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Souřasnice Y";
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(74, 272);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(79, 26);
            this.buttonO.TabIndex = 17;
            this.buttonO.Text = "Obdélník";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(159, 272);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(74, 26);
            this.buttonU.TabIndex = 18;
            this.buttonU.Text = "Úsečka";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(4, 272);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(64, 26);
            this.buttonE.TabIndex = 19;
            this.buttonE.Text = "Elipsa";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 24);
            this.button3.TabIndex = 20;
            this.button3.Text = "Obrázek";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonf
            // 
            this.buttonf.Location = new System.Drawing.Point(11, 370);
            this.buttonf.Name = "buttonf";
            this.buttonf.Size = new System.Drawing.Size(77, 26);
            this.buttonf.TabIndex = 22;
            this.buttonf.Text = "Fixa";
            this.buttonf.UseVisualStyleBackColor = true;
            this.buttonf.Click += new System.EventHandler(this.buttonf_Click);
            // 
            // buttont
            // 
            this.buttont.Location = new System.Drawing.Point(94, 368);
            this.buttont.Name = "buttont";
            this.buttont.Size = new System.Drawing.Size(80, 28);
            this.buttont.TabIndex = 23;
            this.buttont.Text = "Tužka";
            this.buttont.UseVisualStyleBackColor = true;
            this.buttont.Click += new System.EventHandler(this.buttont_Click);
            // 
            // buttong
            // 
            this.buttong.Location = new System.Drawing.Point(180, 368);
            this.buttong.Name = "buttong";
            this.buttong.Size = new System.Drawing.Size(80, 28);
            this.buttong.TabIndex = 24;
            this.buttong.Text = "Guma";
            this.buttong.UseVisualStyleBackColor = true;
            this.buttong.Click += new System.EventHandler(this.buttong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1279, 757);
            this.Controls.Add(this.buttong);
            this.Controls.Add(this.buttont);
            this.Controls.Add(this.buttonf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxv);
            this.Controls.Add(this.textBoxs);
            this.Controls.Add(this.textBoxy);
            this.Controls.Add(this.textBoxx);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxx;
        private System.Windows.Forms.TextBox textBoxy;
        private System.Windows.Forms.TextBox textBoxs;
        private System.Windows.Forms.TextBox textBoxv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonf;
        private System.Windows.Forms.Button buttont;
        private System.Windows.Forms.Button buttong;
    }
}

