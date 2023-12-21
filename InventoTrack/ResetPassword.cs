using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace InventoTrack
{
    public partial class ResetPassword : Form
    {
        string randomCode;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void sendotpButton_Click(object sender, EventArgs e)
        {
            string email = usernameTextBox.Text;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            Users.sendOTP(email, randomCode);
        }

        private void resetpasswordButton_Click(object sender, EventArgs e)
        {
            string email = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string otp = textBox_otp.Text;

            if (randomCode == otp)
            {
                if (email != "")
                {
                    try
                    {
                        Users.updatePassword(email, password);
                        LandingPage landingPage = new LandingPage();
                        landingPage.Show();
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Isi email terlebih dahulu");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kode OTP salah");
            }
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

    }
}
