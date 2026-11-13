using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonuclb.Text = textBox1.Text + " " + comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] meslekler = { "İşçi","Memur","Mühendis","Programcı","Teknisyen"};
            comboBox1.Items.AddRange(meslekler);
        }
    }
}
