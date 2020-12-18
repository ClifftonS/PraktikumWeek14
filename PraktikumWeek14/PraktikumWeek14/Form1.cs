using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnreverse_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu!");
            }
            else
            {
                string s1, s2;
                s2 = "";
                s1 = txtboxinput.Text;
                for (int i = s1.Length-1; i >= 0; i--)
                {
                    s2 = s2 + s1[i];
                }
                lbloutput.Text = s2;
                txtboxinput.Text = "";
            }
        }

        private void btnurutkan_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu!");
            }
            else
            {
                string s1;
                char s3;
                s1 = txtboxinput.Text;
                char[] index = s1.ToCharArray();
                for (int i = 0; i <= s1.Length - 1; i++)
                {
                    for(int j = 0; j < i; j++)
                    {
                        if (index[i] < index[j])
                        {
                            s3 = index[i];
                            index[i] = index[j];
                            index[j] = s3;
                        }
                    }
                }
                string hasil = new string(index);
                lbloutput.Text = hasil;


                txtboxinput.Text = "";
            }
        }
    }
}
