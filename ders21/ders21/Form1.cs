using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {

                var item = listBox1.SelectedItems[0];


                listBox2.Items.Add(item);


                listBox1.Items.Remove(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (listBox2.SelectedItems.Count > 0)
            {

                var item = listBox2.SelectedItems[0];


                listBox1.Items.Add(item);


                listBox2.Items.Remove(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dersler = { "Matematik", "Fizik", "Programlama", "İngilizce", "Mantık Devreleri" };

            listBox1.Items.AddRange(dersler);
        }
    }
}
