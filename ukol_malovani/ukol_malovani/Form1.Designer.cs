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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxs = new System.Windows.Forms.TextBox();
            this.textBoxv = new System.Windows.Forms.TextBox();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonf = new System.Windows.Forms.Button();
            this.buttont = new System.Windows.Forms.Button();
            this.buttong = new System.Windows.Forms.Button();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(204, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 615);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 36);
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
            this.button2.Location = new System.Drawing.Point(9, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Výběr barvy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(89, 24);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(110, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tloušťka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Šířka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Výška";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 89);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Výplň";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxs
            // 
            this.textBoxs.Location = new System.Drawing.Point(44, 110);
            this.textBoxs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxs.Name = "textBoxs";
            this.textBoxs.Size = new System.Drawing.Size(64, 20);
            this.textBoxs.TabIndex = 13;
            this.textBoxs.Text = " ";
            // 
            // textBoxv
            // 
            this.textBoxv.Location = new System.Drawing.Point(44, 134);
            this.textBoxv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxv.Name = "textBoxv";
            this.textBoxv.Size = new System.Drawing.Size(64, 20);
            this.textBoxv.TabIndex = 14;
            this.textBoxv.Text = " ";
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(56, 221);
            this.buttonO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(59, 21);
            this.buttonO.TabIndex = 17;
            this.buttonO.Text = "Obdélník";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(119, 221);
            this.buttonU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(56, 21);
            this.buttonU.TabIndex = 18;
            this.buttonU.Text = "Úsečka";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(3, 221);
            this.buttonE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(48, 21);
            this.buttonE.TabIndex = 19;
            this.buttonE.Text = "Elipsa";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 247);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 20);
            this.button3.TabIndex = 20;
            this.button3.Text = "Obrázek";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonf
            // 
            this.buttonf.Location = new System.Drawing.Point(8, 301);
            this.buttonf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonf.Name = "buttonf";
            this.buttonf.Size = new System.Drawing.Size(58, 21);
            this.buttonf.TabIndex = 22;
            this.buttonf.Text = "Fixa";
            this.buttonf.UseVisualStyleBackColor = true;
            this.buttonf.Click += new System.EventHandler(this.buttonf_Click);
            // 
            // buttont
            // 
            this.buttont.Location = new System.Drawing.Point(70, 299);
            this.buttont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttont.Name = "buttont";
            this.buttont.Size = new System.Drawing.Size(60, 23);
            this.buttont.TabIndex = 23;
            this.buttont.Text = "Tužka";
            this.buttont.UseVisualStyleBackColor = true;
            this.buttont.Click += new System.EventHandler(this.buttont_Click);
            // 
            // buttong
            // 
            this.buttong.Location = new System.Drawing.Point(135, 299);
            this.buttong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttong.Name = "buttong";
            this.buttong.Size = new System.Drawing.Size(60, 23);
            this.buttong.TabIndex = 24;
            this.buttong.Text = "Guma";
            this.buttong.UseVisualStyleBackColor = true;
            this.buttong.Click += new System.EventHandler(this.buttong_Click);
            // 
            // textBoxColor
            // 
            this.textBoxColor.BackColor = System.Drawing.Color.Black;
            this.textBoxColor.Location = new System.Drawing.Point(90, 56);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(25, 20);
            this.textBoxColor.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "návod na tvary: klikni na tlačítko,";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "zadej šířku a výšku a pak jen klikni";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "na panel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(959, 615);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.buttong);
            this.Controls.Add(this.buttont);
            this.Controls.Add(this.buttonf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.textBoxv);
            this.Controls.Add(this.textBoxs);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxs;
        private System.Windows.Forms.TextBox textBoxv;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonf;
        private System.Windows.Forms.Button buttont;
        private System.Windows.Forms.Button buttong;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

