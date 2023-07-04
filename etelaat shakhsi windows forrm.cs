using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formmehr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Dk_Click(object sender, EventArgs e)
        {
            if (text_name.Text != "")
            {
                if (text_family.Text != "")
                {
                    if (text_Age.Text != "")
                    {
                        if (text_Address.Text != "")
                        {
                            string txt = text_name.Text + " " + text_family.Text + " " + text_Age.Text + " " + text_Address.Text;
                            MessageBox.Show(txt);
                        }
                        else
                        {
                            MessageBox.Show("آدرس وارد نشده");
                        }
                    }
                    else
                    {
                        MessageBox.Show("  سن وارد نشده");
                    }
                }
                else
                {
                    MessageBox.Show(" فامیلی راوارد نشده");
                }
            }
            else
            {
                MessageBox.Show(" اسم وارد نشده");
            }
        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {

        }

    }
}