using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void veriEkleButton_Click(object sender, EventArgs e)
        {
            string baslik = baslikTextBox.Text;
            string konu = konuTextBox.Text;
            string icerik = icerikRichTextBox.Text;

            dataGridView1.Rows.Add(baslik,konu,icerik);

            MessageBox.Show("İçerik Eklendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
