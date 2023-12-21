﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoTrack
{
    public partial class LandingPage : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LandingPage()
        {
            InitializeComponent();
        }


        private void LandingPage_Load(object sender, EventArgs e)
        {

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                bool isCanLogin = Users.checkUserLogin(username, password);
                if (isCanLogin != true)
                {
                    throw new Exception("Error Loggin in");
                }
                string email = Users.getEmail(username, password);
                int id = Users.getUserId(email);
                MessageBox.Show($"Log in Success, welcome {username}");
                this.Hide();
                InventoTrack inventoTrack = new InventoTrack(id, username, email, password);
                inventoTrack.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createaccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage registerpage = new RegisterPage();
            registerpage.Show();
        }

        private void resetpasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ResetPassword resetpassword = new ResetPassword();
            resetpassword.Show();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
