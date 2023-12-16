using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoTrack
{
    public partial class LandingPage : Form
    {
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
                connection.Close();
                MessageBox.Show($"Log in Success, welcome {username}");
                this.Hide();
                InventoTrack inventoTrack = new InventoTrack();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterPage registerpage = new RegisterPage();
            registerpage.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
