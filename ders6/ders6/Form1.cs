using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders6
{
    public partial class Form1 : Form
    { 

        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void islembutton1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2= Convert.ToInt32(textBox3.Text);
             textBox2.Text= Convert.ToString(sayi1 + sayi2);



        }

        private void cikisbutton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
