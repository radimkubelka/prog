using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public bool Elipse = false;
        public bool Rectangle = false;
        public bool Line = false;
        public bool picture = false;
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
        public int Loads()                                    //načte hodnoty z textboxů
        {
            if (textBoxs.Text == " ")
            {
                MessageBox.Show("Není zadaná šířka");
                return 0;
            }
            else
            {
                int s = Convert.ToInt32(textBoxs.Text);
                return s;
            }
        }
        public int Loadv()
        {
            if (textBoxv.Text == " ")
            {
                MessageBox.Show("Není zadaná výška");
                return 0;
            }
            else
            {
                int v = Convert.ToInt32(textBoxv.Text);
                return v;
            }
            
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            befloc = e.Location;
            using (Graphics g = panel1.CreateGraphics())
            {
                if (Elipse == true)                     //elipsa
                {
                    int s = Loads();
                    int v = Loadv();
                    if (checkBox1.Checked == false)
                    {
                        g.DrawEllipse(mypen, e.Location.X, e.Location.Y, s, v);
                    }
                    else
                    {
                        g.FillEllipse(mybrush, e.Location.X, e.Location.Y, s, v);
                    }
                }
                else if (Rectangle == true)                 //obdélník
                {
                    int s = Loads();
                    int v = Loadv();
                    if (checkBox1.Checked == false)
                    {
                        g.DrawRectangle(mypen, e.Location.X, e.Location.Y, s, v);
                    }
                    else
                    {
                        g.FillRectangle(mybrush, e.Location.X, e.Location.Y, s, v);
                    }

                }
                else if (Line == true)              //čára
                {
                    int s = Loads();
                    int v = Loadv();
                    g.DrawLine(mypen, e.Location.X, e.Location.Y, e.Location.X + s, e.Location.Y + v);

                }
                else if (picture == true)               //obrázek
                {
                    int s = Loads();
                    int v = Loadv();
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())            //pomoc z chatgpt
                    {
                        openFileDialog.Filter = "Pictures|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string pathToPicture = openFileDialog.FileName;
                            Image obrazek = Image.FromFile(pathToPicture);
                            g.DrawImage(obrazek, e.Location.X, e.Location.Y, s, v);
                        }
                    }
                }
            }
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
                    if (Elipse == false && Rectangle == false && Line == false && picture == false)
                    {
                        g.DrawLine(mypen, befloc, e.Location);
                        befloc = e.Location;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();                           //výběr barev v color dialogu
            MyDialog.FullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = mypen.Color;
            MyDialog.Color = mybrush.Color;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                mypen.Color = MyDialog.Color;
                mybrush.Color = MyDialog.Color;
                lastcolor = MyDialog.Color;
                textBoxColor.BackColor = mypen.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mypen.Width = trackBar1.Value;                              //výběr tloušťky štětce
            label1.Text = trackBar1.Value.ToString();
        }

        private void buttonE_Click(object sender, EventArgs e)          //tlačítko elipsa
        {
            Elipse = true;
            Rectangle = false;
            Line = false;
            picture = false;
        }

        private void buttonO_Click(object sender, EventArgs e)          //tlačítko obdélník
        {
            Elipse = false;
            Rectangle = true;
            Line = false;
            picture = false;
        }

        private void buttonU_Click(object sender, EventArgs e)          //tlačítko čára
        {
            Elipse = false;
            Rectangle = false;
            Line = true;
            picture = false;
        }

        private void button3_Click_1(object sender, EventArgs e)          //tlačítko obrázek
        {
            Elipse = false;
            Rectangle = false;
            Line = false;
            picture = true;
        }

        private void buttonf_Click(object sender, EventArgs e)                  //normální "fixa"
        {
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            mypen.DashOffset = 0;
            mypen.Color = lastcolor;
            Elipse = false;
            Rectangle = false;
            Line = false;
            picture = false;
        }

        private void buttont_Click(object sender, EventArgs e)                   //pokus o něco co vypadá jako tužka
        {
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            mypen.DashOffset = 0.5F;
            mypen.Color = lastcolor;
            Elipse = false;
            Rectangle = false;
            Line = false;
            picture = false;
        }

        private void buttong_Click(object sender, EventArgs e)                  //guma
        {
            mypen.Color = panel1.BackColor;
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            mypen.DashOffset = 0;
            Elipse = false;
            Rectangle = false;
            Line = false;
            picture = false;
        }
    }
}
