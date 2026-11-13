using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float ayakkabi = 50;
        float ceket = 90;
        float gomlek = 40;
        float sweatshirt = 40;
        float corap = 10;
        float toplamsonuc;

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Ayakkabı");
            checkedListBox1.Items.Add("Ceket");
            checkedListBox1.Items.Add("Gömlek");
            checkedListBox1.Items.Add("Sweatshirt");


        }



        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(kategoriTb.Text);

        }

        private void checkedListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                toplamsonuc = 0;
                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    if (checkedListBox1.SelectedItem.ToString() == "Ayakkabı")
                    {
                        toplamsonuc += ayakkabi;
                    }
                    if (checkedListBox1.SelectedItem.ToString() == "Ceket")
                    {
                        toplamsonuc += ceket;
                    }
                    if (checkedListBox1.SelectedItem.ToString() == "Gömlek")
                    {
                        toplamsonuc += gomlek;
                    }
                    if (checkedListBox1.SelectedItem.ToString() == "sweatshirt")
                    {
                        toplamsonuc += sweatshirt;
                    }
                    if (checkedListBox1.SelectedItem.ToString() == "Corap")
                    {
                        toplamsonuc += corap;
                    }

                    toplamsonucLb.Text = toplamsonuc.ToString();
                }
            }
        }
    }
}
