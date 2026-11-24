using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlar_arasi_gecis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string adin;

        public Form2(string adsoyad)
        {
            adin = adsoyad;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sonuc_lb.Text = "Başarılı " + adin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
