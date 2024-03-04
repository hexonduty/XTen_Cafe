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

        public static int[] totalPrices = new int[120];
        public static int totalIndex    = 0;

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
            totalPrices[totalIndex] = (totalPrice);
            totalIndex++;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            totalPrice += cupcake;
            cardListBox.Items.Add("Cupcake");
            totalPrices[totalIndex] = (totalPrice);

            totalIndex++;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            totalPrice += hamburger;
            cardListBox.Items.Add("Hamburger");
            totalPrices[totalIndex] = (totalPrice);

            totalIndex++;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            totalPrice += pizza;
            cardListBox.Items.Add("Pizza");
            totalPrices[totalIndex] = (totalPrice);

            totalIndex++;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            totalPrice += hotdog;
            cardListBox.Items.Add("Hotdog");
            totalPrices[totalIndex] = (totalPrice);

            totalIndex++;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            totalPrice += pancake;
            cardListBox.Items.Add("Pancake");
            totalPrices[totalIndex] = (totalPrice);

            totalIndex++;

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

                cardListBox.Items.Clear();

                if(money < 0)
                {
                    moneyLabel.Text = "0TL";
                }
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

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();

            loginPage.Show();

            this.Hide();
        }
    }
}
