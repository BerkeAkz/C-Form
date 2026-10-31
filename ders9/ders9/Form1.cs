using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders9
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

        private void button1_Click(object sender, EventArgs e)
        { int sayi1;
            int sayi2;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text); 

            if(comboBox1.SelectedItem=="Toplama")
            {
                label5.Text = Convert.ToString(sayi1 + sayi2);
            }
            else if(comboBox1.SelectedItem=="Çıkartma")
            {
                if(sayi1>sayi2)
                {
                    label5.Text = Convert.ToString(sayi1 - sayi2);
                }
                else if(sayi2>sayi1)
                {
                    label5.Text = Convert.ToString(sayi2 - sayi1);
                }
                else
                {
                    label5.Text = "0";
                }

            }
            else if(comboBox1.SelectedItem=="Çarpma")
            {
                label5.Text = Convert.ToString(sayi1 * sayi2);
            }
            else if(comboBox1.SelectedItem=="Bölme")
            {
                if(sayi1==0&&sayi2==0)
                {
                    label5.Text = "Lütfen Sıfır Girmeyiniz";
                }
                else
                {
                    label5.Text = Convert.ToString(sayi1 / sayi2);
                }
            }
            else
            {
                label5.Text = "Lütfen İşlem Seçimi Yapın";
            }
        }
    }
}
