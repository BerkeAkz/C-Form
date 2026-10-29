using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders2
{
    public partial class Form1 : Form
    {
        string totalString = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                totalString += "Cinsiyet= Erkek ";
            }
            else if (radioButton2.Checked)
            {
                totalString += "Cinsiyet= kadın ";

            }
            else 
            {
                totalString += "Cinsiyet= Belirtilmemiş ";
            }

            totalString += "Hobi/Hobiler=";

            if (checkBox1.Checked)
            {
                totalString += "Futbol Oynamak ";
            }


            if (checkBox2.Checked)
            {
                totalString += "Müzik Dinlemek ";

            }


            if (checkBox3.Checked)
            {
                totalString += "Spora Gitmek ";
            }

            MessageBox.Show(totalString,"Genel Bilgilendirme");
        }
    }
}
