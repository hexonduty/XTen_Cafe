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
    public partial class Form2 : Form
    {

        private int totalExpense = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.totalIndex;  i++)
            {

                if (Form1.totalPrices[i] == 0)
                {
                    richTextBox.Text = "You didn't spend anything today";
                }
                else
                {
                    richTextBox.Text = $"Total spending today : {Form1.totalPrices[i]}";
                }

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int expense = Convert.ToInt32(expenseTextBox.Text);
            for(int i = 0; i<  Form1.totalIndex;i++){
                totalExpense += Form1.totalPrices[i]  -  (expense);
            }
        }
    }
}
