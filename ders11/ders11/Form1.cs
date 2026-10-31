using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dersler = { "Görsel Programlama", "Ağ Temelleri", "Matematik", "Veri Tabanı", "Mesleki İngilizce" };
            derslerListBox.Items.AddRange(dersler);
        }

        private void eklebutton1_Click(object sender, EventArgs e)
        {
            string ders = textBox1.Text;

            derslerListBox.Items.Remove(ders);
            secilenDersler.Items.Add(ders);
        }

        private void cıkartbutton2_Click(object sender, EventArgs e)
        {
            string ders = textBox1.Text;

            derslerListBox.Items.Add(ders);
            secilenDersler.Items.Remove(ders);
        }
    }
}
