using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class CircularButton : Button {
            protected override void OnPaint(PaintEventArgs pevent)
            {
                GraphicsPath g = new GraphicsPath();
                g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(g);
                base.OnPaint(pevent);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        button1.BackColor = Color.Red;
                        elipseButton1.BackColor = Color.Red;
                        triangleButton1.BackColor = Color.Red;
                        elipseButton2.BackColor = Color.Red;
                        break;
                    }
                case 1:
                    {
                        button1.BackColor = Color.Black;
                        button1.ForeColor = Color.White;

                        elipseButton1.BackColor = Color.Black;
                        elipseButton1.ForeColor = Color.White;

                       triangleButton1.BackColor = Color.Black;
                       triangleButton1.ForeColor = Color.White;

                        elipseButton2.BackColor = Color.Black;
                        elipseButton2.ForeColor = Color.White;
                        break;
                    }
                case 2:
                    {
                        button1.BackColor = Color.Green;
                        elipseButton1.BackColor = Color.Green;
                        triangleButton1.BackColor = Color.Green;
                        elipseButton2.BackColor = Color.Green;
                        break;
                    }
                case 3:
                    {
                        button1.BackColor = Color.Yellow;
                        elipseButton1.BackColor = Color.Yellow;
                        triangleButton1.BackColor = Color.Yellow;
                        elipseButton2.BackColor = Color.Yellow;
                        break;
                    }
                case 4:
                    {
                        button1.BackColor = Color.Pink;
                        elipseButton1.BackColor = Color.Pink;
                        triangleButton1.BackColor = Color.Pink;
                        elipseButton2.BackColor = Color.Pink;
                        break;
                    }
                case 5:
                    {
                        button1.BackColor = Color.Orange;
                        elipseButton1.BackColor = Color.Orange;
                        triangleButton1.BackColor = Color.Orange;
                        elipseButton2.BackColor = Color.Orange;
                        break;
                    }
                case 6:
                    {
                        button1.BackColor = Color.Violet;
                        elipseButton1.BackColor = Color.Violet;
                        triangleButton1.BackColor = Color.Violet;
                        elipseButton2.BackColor = Color.Violet;
                        break;
                    }
            }
        }

       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox2.SelectedIndex) {
                case 0:
                    {
                        button1.Visible = true;
                        elipseButton1.Visible = false;
                        triangleButton1.Visible = false;
                        elipseButton2.Visible = false;
                        break;
                    }
                case 1:
                    {
                        elipseButton1.Visible = true;
                        button1.Visible = false;
                        triangleButton1.Visible = false;
                        elipseButton2.Visible = false;
                        break;
                    }
                case 2:
                    {
                        triangleButton1.Visible = true;
                        button1.Visible = false;
                        elipseButton1.Visible = false;
                        elipseButton2.Visible = false;
                        break;
                    }
                case 3:
                    {
                        elipseButton2.Visible = true;
                        triangleButton1.Visible = false;
                        button1.Visible = false;
                        elipseButton1.Visible = false;
                        break;
                    }
            }


        }
    }
    }


