using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Uygulaması
{
    public partial class Form1 : Form
    {
        int money = 1000;

        int cheese = 150;
        int cupcake = 50;
        int hamburger = 150;
        int pizza = 150;
        int hotdog = 80;
        int pancake = 70;


        int totelPrice = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moneyLabel.Text = money.ToString()+"TL";
        }

        private void cheesePicture_Click(object sender, EventArgs e)
        {
            totelPrice += cheese;
            cartListBox.Items.Add("Cheese");
        }

        private void cupcakePicture_Click(object sender, EventArgs e)
        {
            totelPrice += cupcake;
            cartListBox.Items.Add("Cupcake");
        }
        

        private void hamburgerPicture_Click(object sender, EventArgs e)
        {
            totelPrice += hamburger;
            cartListBox.Items.Add("Burger");
        
        }

        private void pizzaPicture_Click(object sender, EventArgs e)
        {
            totelPrice += pizza;
            cartListBox.Items.Add("Pizza");
        }

        private void hotdogPicture_Click(object sender, EventArgs e)
        {
            totelPrice += hotdog;
            cartListBox.Items.Add("hotdog");
        }

        private void pancakePicture_Click(object sender, EventArgs e)
        {
            totelPrice += pancake;
            cartListBox.Items.Add("Pancake");
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if(money>=totelPrice)
            {
                money = money - totelPrice;

                moneyLabel.Text = money.ToString() + "Tl";

                MessageBox.Show("İşlem Başarılı Teşekkürler...","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cartListBox.Items.Clear();
                
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
