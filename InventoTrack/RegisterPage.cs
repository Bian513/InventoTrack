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
    public partial class RegisterPage : Form
    {
        String randomCode;
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
            string otp = textBox_otp.Text;
            if(randomCode == otp)
            {
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
                        MessageBox.Show($"Register Success, welcome {username} Please Login");
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
            else
            {
                MessageBox.Show("Kode OTP salah");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            
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
                MessageBox.Show("Kode OTP Berhasil dikirimkan, silahkan cek email anda");
            }
            catch
            {
                MessageBox.Show("Isi email terlebih dahulu");
            }
        }
    }
}
