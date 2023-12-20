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
        string randomCode;
        public LandingPage()
        {
            InitializeComponent();
        }


        private void LandingPage_Load(object sender, EventArgs e)
        {

        }

        private void newButton(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string query = $"DECLARE @Username VARCHAR(50) = '{username}';DECLARE @Password VARCHAR(50) = '{password}';SELECT dbo.CheckUserLogin(@Username, @Password);";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if ((bool)cmd.ExecuteScalar() != true)
                {
                    throw new Exception("Error Loggin in");
                }
                SqlCommand selectEmail = new SqlCommand ("SELECT email FROM users WHERE username = @username AND password = @password;", connection);
                selectEmail.Parameters.AddWithValue("@username", username);
                selectEmail.Parameters.AddWithValue("@password", password);
                string email = (string)selectEmail.ExecuteScalar();
                SqlCommand selectId = new SqlCommand("SELECT id FROM users WHERE email= @email;", connection);
                selectId.Parameters.AddWithValue("@email", email);
                int id = (int)selectId.ExecuteScalar();
                connection.Close();
                MessageBox.Show($"Log in Success, welcome {id},{username},{email},{password}");
                this.Hide();
                InventoTrack inventoTrack = new InventoTrack(id, username, email, password);
                inventoTrack.Show();
                }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ResetPassword resetpassword = new ResetPassword();
            resetpassword.Show();
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

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage registerpage = new RegisterPage();
            registerpage.Show();
        }
    }
}
