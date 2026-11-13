using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] islemler = { "Toplama", "Çıkartma", "Çarpma", "Bölme" };
            comboBox1.Items.AddRange(islemler);
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);

            double sayi2 = Convert.ToDouble(textBox3.Text);

            double sonuc;

            if(comboBox1.Text=="Toplama")
            {
                sonuc = sayi1 + sayi2;
                sonuclb.Text = sonuc + "";
            }
            if(comboBox1.Text=="Çıkartma")
            {
                if(sayi1>sayi2)
                {
                  sonuc = sayi1 - sayi2;
                    sonuclb.Text = sonuc + "";
                }
                else
                {
                  sonuc = sayi2 - sayi1;
                    sonuclb.Text = sonuc + "";
                }
            }
            if(comboBox1.Text=="Çarpma")
            {
                sonuc = sayi1 * sayi2;
                sonuclb.Text = sonuc + "";
            }
            if(comboBox1.Text=="Bölme")
            {
                if (sayi1 == 0 && sayi2 == 0)
                {
                    sonuclb.Text = "0 Girilmez.";
                }
                sonuc = sayi1 / sayi2;
                sonuclb.Text = sonuc + "";
            }
            if(comboBox1.Text==null)
            {
                sonuclb.Text = "İşlem Seçilmedi";
            }



        }
    }
}
