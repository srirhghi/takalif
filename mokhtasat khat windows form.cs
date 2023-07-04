using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mokhtasatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox3.Text != "")
                    {
                        if (textBox3.Text != "")
                        {
                            double x1 = Convert.ToDouble(textBox1.Text);
                            double x2 = Convert.ToDouble(textBox2.Text);
                            double y1 = Convert.ToDouble(textBox3.Text);
                            double y2 = Convert.ToDouble(textBox4.Text);
                            double s = (x2 - x1);
                            double p = (y2 - y1);
                            double d = Math.Pow(s, 2);
                            double l = Math.Pow(p, 2);
                            double t = Math.Sqrt(d + l);
                            MessageBox.Show(t.ToString());

                        }
                        else
                        {
                            MessageBox.Show("y2");
                        }
                    }
                    else
                    {
                        MessageBox.Show("  y1");
                    }
                }
                else
                {
                    MessageBox.Show(" x2");
                }
            }
            else
            {
                MessageBox.Show("x1");
            }

        }
    }
}