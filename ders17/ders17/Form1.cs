using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sehir = { "Bursa","İstanbul","Ankara","İzmir" };
            listBox1.Items.AddRange(sehir);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçilen Şehir:" + listBox1.Text + "", "Şehir", MessageBoxButtons.OKCancel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçilen Sıra:" + listBox1.SelectedIndex.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eleman Sayısı:" + listBox1.Items.Count.ToString());
        }
    }
}
