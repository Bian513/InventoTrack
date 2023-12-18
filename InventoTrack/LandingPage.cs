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
        String randomCode;
        public LandingPage()
        {
            InitializeComponent();
        }


        private void LandingPage_Load(object sender, EventArgs e)
        {

        }

        private void newButton(object sender, EventArgs e)
        {
            string otp = textBox_otp.Text;
            //if (randomCode == otp)
            //{
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
            //}
            //else
            //{
                //MessageBox.Show("Kode OTP Salah");
            //}
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

        private void button2_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string connectionString = "Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string commandString = "SELECT email FROM users WHERE username = @username AND password = @password;";
            SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            string email = (string)command.ExecuteScalar();

            try
            {
                String from, pass, messageBody, to;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                to = email;
                from = "inventotrack@gmail.com";
                pass = "nrig zldn uoge jwhc";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                MailMessage message = new MailMessage();
                messageBody = "Terimakasih telah mencoba mendaftar di aplikasi InventoTrack, berikut merupakan kode OTP: " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Kode Verifikasi OTP";
                smtp.Send(message);
                MessageBox.Show("Kode OTP Berhasil dikirimkan");
            }
            catch
            {
                MessageBox.Show("Isi username dan password terlebih dahulu");
            }
        }
    }
}
