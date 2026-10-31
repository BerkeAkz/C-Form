using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tutar = 0;

            if (burgercheckBox1.Checked)
            {
                tutar += 200;
            }
            if (pizzacheckBox2.Checked)
            {
                tutar += 350;

            }
            if(donercheckBox3.Checked)
            {
                tutar += 80;
            }
            if(LahmacuncheckBox4.Checked)
            {
                tutar += 120;
            }


            if(ayrancheckBox1.Checked)
            {
                tutar += 15;
            }
            if (sodacheckBox2.Checked)
            {
                tutar += 15;

            }
            if (sucheckBox3.Checked)
            {
                tutar += 10;
            }
            if (SicakcheckBox4.Checked)
            {
                tutar += 80;
            }

            if(radioButton1.Checked)
            {
                tutar = tutar - (tutar/5);
                toplamTutar.Text = Convert.ToString(tutar) + " TL";
            }
            else
            {
                tutar = tutar - (tutar / 10);
                toplamTutar.Text = Convert.ToString(tutar) + " TL";
            }
        }
    }
}
