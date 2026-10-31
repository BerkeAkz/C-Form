using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eklebutton1_Click(object sender, EventArgs e)
        {
            string isim;

            isim = textBox1.Text;

            ogrenciList.Items.Add(isim);

        }

        private void cikartbutton2_Click(object sender, EventArgs e)
        {
            string isim;

            isim = textBox1.Text;

            ogrenciList.Items.Remove(isim);
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            ogrenciList.Items.Clear();
        }
    }
}
