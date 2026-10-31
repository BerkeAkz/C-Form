using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders8
{
    public partial class Form1 : Form
    {

       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] meslekler = { "Memur","Mühendis","Öğretmen","Avukat","Teknisyen" };
            comboBox1.Items.AddRange(meslekler);

            label3.Text = textBox1 + " " + comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] meslekler = { "Memur", "Mühendis", "Öğretmen", "Avukat", "Teknisyen" };
            comboBox1.Items.AddRange(meslekler);
        }
    }
}
