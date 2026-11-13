using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            elemansayisilb.Text = listBox1.Items.Count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            secilielemanlb.Text = listBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            siralb.Text = listBox1.SelectedIndex.ToString();
        }

       

        

        private void button8_Click(object sender, EventArgs e)
        {
            string aranankisi = textBox2.Text;

            if(listBox1.Items.Contains(aranankisi))
            {
                varyoklb.Text = "Aradığınız Kişi Listede Vardır";
            }
            else
            {
                varyoklb.Text = "Aradığınız Kişi Listede Yoktur.";
            }
        }
    }
}
