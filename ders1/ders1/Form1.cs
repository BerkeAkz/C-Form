using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string istenilenMail = "Berkeakz67@gmail.com";
            string mail = textBox1.Text;
            if (istenilenMail == mail)
            {
                label2.Text = "Başarılı";
            }
            else
            {
                label2.Text = "Başarısız";
            }
        }
    }
}
