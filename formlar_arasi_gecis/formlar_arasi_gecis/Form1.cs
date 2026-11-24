using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlar_arasi_gecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyadi = textBox2.Text;
            string kayityili = textBox3.Text;
            string adres = richTextBox1.Text;
            string medeni_durum;
            string egitim;
            string sehir = comboBox1.Text;

            if(radioButton1.Checked)
            {
                medeni_durum = "Evli";
            }
            else
            {
                medeni_durum = "Bekar";
            }

            if(radioButton3.Checked)
            {
                egitim = "İlkÖğretim";
            }
            if(radioButton4.Checked)
            {
                egitim = "Lise";
            }
            if (radioButton5.Checked)
            {
                egitim = "Önlisans";

            }
            if (radioButton6.Checked)
            {
                egitim = "Lisans";
            }



            Form form2 = new Form2(ad);
           
            form2.Show();
        }
    }
}
