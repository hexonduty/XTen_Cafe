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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";

            if(loginPageUsername.Text == username && loginPagePassword.Text == password)
            {
                notifyIcon1.BalloonTipTitle = "Admin Information";
                notifyIcon1.BalloonTipText = "Administrator logged in to the system";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(30000);


                Form2 form2 = new Form2();

                form2.Show();

                this.Hide();
            
            }
        }
    }
}
