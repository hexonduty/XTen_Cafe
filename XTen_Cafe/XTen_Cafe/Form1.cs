using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XTen_Cafe
{
    public partial class Form1 : Form
    {

        int money = 1000;


        int cheese = 170;
        int cupcake = 100;
        int hamburger = 120;
        int hotdog = 45;
        int pancake = 60;
        int pizza = 200;

        int totalPrice = 0;
        public Form1()
        {
            InitializeComponent();
        }

    

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            totalPrice += cheese;
            cardListBox.Items.Add("Cheese");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            totalPrice += cupcake;
            cardListBox.Items.Add("Cupcake");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            totalPrice += hamburger;
            cardListBox.Items.Add("Hamburger");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            totalPrice += pizza;
            cardListBox.Items.Add("Pizza");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            totalPrice += hotdog;
            cardListBox.Items.Add("Hotdog");
        }
        
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            totalPrice += pancake;
            cardListBox.Items.Add("Pancake");
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (totalPrice <= 1000)
            {
                /* Mathematical Part */
                money = money - totalPrice;

                /* Writing Part */
                moneyLabel.Text = money.ToString() + "TL";

                /* Information */
                MessageBox.Show("Thanks for your shopping..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insufficient Balance!", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            {
                moneyLabel.Text = money.ToString() + "TL";
            }
        }
    }
}
