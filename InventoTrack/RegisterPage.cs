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
                    SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
                    Person.openConnection(connection);
                    bool isCanRegist = Person.checkUserLogin(username, password, connection);


                    if (isCanRegist == true)
                    {
                        Person.closeConnection(connection);
                        throw new Exception("Account Has Been Created");

                    }
                    else
                    {
                        Person.registUser(username, email, password, connection);
                        Person.closeConnection(connection);
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

        private void sendotpButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
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

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
