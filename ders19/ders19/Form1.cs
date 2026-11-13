using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Ayakkabı");
            checkedListBox1.Items.Add("Ceket");
            checkedListBox1.Items.Add("Gömlek");
            checkedListBox1.Items.Add("Tişört");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i= 0; i<checkedListBox1.Items.Count;i++)
            {
                if(checkedListBox1.GetItemChecked(i)==true)
                {
                    listBox1.Items.Add(checkedListBox1.Items[i]);
                }
            }
        }
    }
}
