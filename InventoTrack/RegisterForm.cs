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
        public RegisterForm()
        {
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

        }

        private void button_toMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoTrack inventoTrack = new InventoTrack();
            inventoTrack.Show();
        }
    }
}
