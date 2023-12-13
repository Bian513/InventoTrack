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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                string connectionString = "Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT dbo.CheckUserLogin(@Username, @Password);";
                SqlCommand command = new SqlCommand(commandString, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);


                if ((bool)command.ExecuteScalar() == true)
                {
                    connection.Close();
                    throw new Exception("Account Has Been Created");

                }
                else
                {
                    string insertString = "INSERT INTO users (username, email, password) VALUES (@Username, @Email, @Password)";
                    SqlCommand insertCommand = new SqlCommand(insertString, connection);
                    insertCommand.Parameters.AddWithValue("@Username", username);
                    insertCommand.Parameters.AddWithValue("@Email", email);
                    insertCommand.Parameters.AddWithValue("@Password", password);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show($"Register Success, welcome {username}");
                    connection.Close();
                    LandingPage landingPage = new LandingPage();
                    landingPage.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
