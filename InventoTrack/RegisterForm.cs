using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoTrack
{
    public partial class RegisterForm : Form
    {
        private NpgsqlConnection conn;
        string connString = "Host=127.0.0.1;Port=5432;Username=postgres;Password=12345678;Database=person";
        string query = "";
        NpgsqlCommand cmd;
        public RegisterForm()
        {
            conn = new NpgsqlConnection(connString);
            InitializeComponent();
        }

        private void textBox_username_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string username = textBox1_username.Text;
            string password = textBox_password.Text;
            string email = textBox_email.Text;
            try
            {
                conn.Open();
                query = $"select register_user('{username}', '{email}', '{password}')";
                cmd = new NpgsqlCommand(query, conn);
                if ((bool)cmd.ExecuteScalar() == true)
                {
                    throw new Exception("email has been used");
                }
                conn.Close();
                MessageBox.Show($"Register success, welcome {username}");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button_toMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoTrack inventoTrack = new InventoTrack();
            inventoTrack.Show();
        }
    }
}
