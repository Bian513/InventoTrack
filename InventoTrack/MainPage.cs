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
    public partial class MainPage : Form
    {
        DataTable inventory = new DataTable();
        public MainPage()
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

        private void button1_Click(object sender, EventArgs e)
        {       
            nameTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
            priceNUD.Text = "0";
            quantityNUD.Text = "0";
        }

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
    }
}
