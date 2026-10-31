using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totelkredi = 0;

            if(checkBox1.Checked )
            {
                totelkredi += 4;
            }
            if(checkBox2.Checked )
            {
                totelkredi += 5;
            }
            if(checkBox3.Checked )
            { totelkredi += 2; }
            if(checkBox4.Checked)
            {
                totelkredi += 3;
            }
            if (checkBox5.Checked)
            {
                totelkredi += 4;
            }

            label1.Text = "Toplam Kredi: " + Convert.ToString(totelkredi);
        }
    }
}
