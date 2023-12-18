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
        String randomCode;
        string connectionString = "Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public ResetPassword()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string email = usernameTextBox.Text;

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

            try
            {
                smtp.Send(message);
                MessageBox.Show("Kode OTP Berhasil dikirimkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string otp = textBox_otp.Text;

            if (randomCode == otp)
            {
                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string commandString = "UPDATE users SET password = @password WHERE email = @email;";
                    SqlCommand command = new SqlCommand(commandString, connection);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Password has been reset");
                    connection.Close();
                    LandingPage landingPage = new LandingPage();
                    landingPage.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Isi email terlebih dahulu");
                }
            }
            else
            {
                MessageBox.Show("Kode OTP salah");
            }
            

        }
    }
}
