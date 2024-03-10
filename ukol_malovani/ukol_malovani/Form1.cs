using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ukol_malovani
{
    public partial class Form1 : Form
    {
        bool paint = false;
        public Point befloc;
        public Pen mypen = new Pen(Color.Black, 1);
        public SolidBrush mybrush = new SolidBrush(Color.Black);
        public Color lastcolor = Color.Black;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)              //nové plátno
        {
            panel1.BackColor = Color.Gray;
            panel1.ForeColor = Color.Gray;
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            befloc = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mypen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            mypen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            mypen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            if (paint)                                                      //pomoc z chatgpt   malování myší
            {
                using (Graphics g = panel1.CreateGraphics())
                {
                        g.DrawLine(mypen, befloc, e.Location);
                        befloc = e.Location;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();                           //výběr barev v color dialogu
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = mypen.Color;
            MyDialog.Color = mybrush.Color;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                mypen.Color = MyDialog.Color;
                mybrush.Color = MyDialog.Color;
                lastcolor = MyDialog.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mypen.Width = trackBar1.Value;                              //výběr tloušťky štětce
            label1.Text = trackBar1.Value.ToString();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();                       //elipsa
            int x = Convert.ToInt32(textBoxx.Text);
            int y = Convert.ToInt32(textBoxy.Text);
            int s = Convert.ToInt32(textBoxs.Text);
            int v = Convert.ToInt32(textBoxv.Text);
            if (checkBox1.Checked == false)
            {
                g.DrawEllipse(mypen, x, y, s, v);
            }
            else
            {
                g.FillEllipse(mybrush, x, y, s, v);
            }
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();                       //obdélník
            int x = Convert.ToInt32(textBoxx.Text);
            int y = Convert.ToInt32(textBoxy.Text);
            int s = Convert.ToInt32(textBoxs.Text);
            int v = Convert.ToInt32(textBoxv.Text);
            if (checkBox1.Checked == false)
            {
                g.DrawRectangle(mypen, x, y, s, v);
            }
            else
            {
                g.FillRectangle(mybrush, x, y, s, v);
            }
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();                               //čára
            int x = Convert.ToInt32(textBoxx.Text);
            int y = Convert.ToInt32(textBoxy.Text);
            int s = Convert.ToInt32(textBoxs.Text);
            int v = Convert.ToInt32(textBoxv.Text);
            g.DrawLine(mypen, x, y, s, v);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();                           //vložení obrázku
            int x = Convert.ToInt32(textBoxx.Text);
            int y = Convert.ToInt32(textBoxy.Text);
            int s = Convert.ToInt32(textBoxs.Text);
            int v = Convert.ToInt32(textBoxv.Text);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())            //pomoc z chatgpt
            {
                openFileDialog.Filter = "Pictures|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pathToPicture= openFileDialog.FileName;
                    Image obrazek = Image.FromFile(pathToPicture);
                    g.DrawImage(obrazek, x, y, s, v);
                }
            }        
        }

        private void buttonf_Click(object sender, EventArgs e)
        {
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            mypen.DashOffset = 0;
            mypen.Color = lastcolor;
        }

        private void buttont_Click(object sender, EventArgs e)
        {
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            mypen.DashOffset = 0.5F;
            mypen.Color = lastcolor;
        }

        private void buttong_Click(object sender, EventArgs e)
        {
            mypen.Color = panel1.BackColor;
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            mypen.DashOffset = 0;
        }
    }
}
