using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace InventoTrack
{
    public partial class LoginForm : Form
    {
        private NpgsqlConnection conn;
        string connString = "Host=127.0.0.1;Port=5432;Username=postgres;Password=12345678;Database=person";
        string query = "";
        NpgsqlCommand cmd;

        public LoginForm()
        {
            conn = new NpgsqlConnection(connString);
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
