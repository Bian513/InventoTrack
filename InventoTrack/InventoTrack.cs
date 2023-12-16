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
    public partial class InventoTrack : Form
    {
        DataTable inventory = new DataTable();
        public InventoTrack()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Quantity");

            dataGridView1.DataSource = inventory;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                nameTextBox.Text = inventory.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceNUD.Text = inventory.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[3].ToString();
                quantityNUD.Text = inventory.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[4].ToString();
                String itemToLookFor = inventory.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[2].ToString();
                categoryComboBox.SelectedIndex = categoryComboBox.Items.IndexOf(itemToLookFor);
            }
            catch (Exception err)
            {
                Console.WriteLine("There has been an error: " + err);
            }

        }

        //NEW BUTTON
        private void button1_Click(object sender, EventArgs e)
        {       
            nameTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
            priceNUD.Text = "0";
            quantityNUD.Text = "0";
        }

        //SAVE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String category = categoryComboBox.Text;
            String price = priceNUD.Text;    
            String quantity = quantityNUD.Text;

            

            if (nameTextBox.Text== "")
            {
                MessageBox.Show("Please enter a name for the item");
            }
            else if (categoryComboBox.Text == "")
            {
                MessageBox.Show("Please enter a category for the item");
            }
            else if (priceNUD.Text == "")
            {
                MessageBox.Show("Please enter a price for the item");
            }
            else if (quantityNUD.Text == "")
            {
                MessageBox.Show("Please enter a quantity for the item");
            }
            else
            {
                inventory.Rows.Add(name, category, price, quantity);
                button1_Click(sender, e);
            }



        }

        //DELETE BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button_toLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button_toRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void priceNumericUpdown_Click(object sender, EventArgs e)
        {

        }

        private void quantityNUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void quantityNumericUpDown_Click(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LandingPage landingpage = new LandingPage();
            landingpage.Show();
        }
    }
}
