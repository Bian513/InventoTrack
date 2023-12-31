﻿using System;
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
        SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        string randomCode;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void sendotpButton_Click(object sender, EventArgs e)
        {
            string email = usernameTextBox.Text;
            try
            {
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                Person.sendOTP(email, randomCode);
            }
            catch
            {
                MessageBox.Show("Isi email terlebih dahulu");
            }
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
                        Person.openConnection(connection);
                        Person.updatePassword(email, password, connection);
                        Person.closeConnection(connection);
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
    }
}
