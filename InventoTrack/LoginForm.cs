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
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string query = $"DECLARE @Username VARCHAR(50) = '{username}';DECLARE @Password VARCHAR(50) = '{password}';SELECT dbo.CheckUserLogin(@Username, @Password);";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);


                if ((bool)cmd.ExecuteScalar() != true)
                {
                    throw new Exception("Error Loggin in");
                }
                conn.Close();
                MessageBox.Show($"Log in Success, welcome {username}");
                this.Close();
                InventoTrack inventoTrack = new InventoTrack();
                inventoTrack.Show();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
            /*
            try
            {
                conn.Open();
                query = $"select login_user('{username}', '{password}')";
                cmd = new NpgsqlCommand(query, conn);
                if ((bool)cmd.ExecuteScalar() == false)
                {
                    throw new Exception("Error logging in");
                }
                conn.Close();
                MessageBox.Show($"Login success, welcome {username}");
                this.Hide();
                InventoTrack inventoTrack = new InventoTrack();
                inventoTrack.Show();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void button_backToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoTrack inventoTrack = new InventoTrack();
            inventoTrack.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPage landingpage = new LandingPage();
            landingpage.Show();
        }
    }
}
