using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eklebutton1_Click(object sender, EventArgs e)
        {
            string katogori = kategoritextBox1.Text;
            checkedListBox1.Items.Add(katogori);
            kategoritextBox1.Clear();

        }

        private void gosterbutton1_Click(object sender, EventArgs e)
        {
            
            int sayi = checkedListBox1.Items.Count;

            for(int i=0;i<sayi;i++)
            {
                if (checkedListBox1.GetItemChecked(i) ==true)
                {
                    listBox1.Items.Add(checkedListBox1.Items[i]);
                    

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
