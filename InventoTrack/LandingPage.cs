using System;
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
        SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
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
                Person.openConnection(connection);
                bool isCanLogin = Person.checkUserLogin(username, password, connection);
                if (isCanLogin != true)
                {
                    throw new Exception("Error Loggin in");
                }
                string email = Person.getEmail(username, password, connection);
                int id = Person.getUserId(email, connection);
                Person.closeConnection(connection);
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
