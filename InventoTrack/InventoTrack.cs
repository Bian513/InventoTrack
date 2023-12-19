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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoTrack
{
    public partial class InventoTrack : Form
    {
        DataTable inventory = new DataTable();
        
        SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

        public InventoTrack()
        {
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Quantity");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand selectAll = new SqlCommand("SELECT * FROM items", connection);
            selectAll.ExecuteNonQuery();
            SqlDataReader reader = selectAll.ExecuteReader();
            if (reader.HasRows)
            {
                BindingSource source = new BindingSource();
                source.DataSource = reader;
                dataGridView1.DataSource = source;
                deleteButton_Click.Show();
            }
            else
            {
                dataGridView1.DataSource = null;
                deleteButton_Click.Hide();
            }
            
            connection.Close();
            
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
            categoryBox.Text = "";
            priceNUD.Text = "0";
            quantityNUD.Text = "0";
        }

        //SAVE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String category = categoryComboBox.Text;
            string price = priceNUD.Text;    
            string quantity = quantityNUD.Text;

            

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
                connection.Open();
                string commandString = "INSERT INTO items (name, category, price, quantity) VALUES (@name, @category, @price, @quantity);";
                SqlCommand command = new SqlCommand(commandString, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@price", int.Parse(price));
                command.Parameters.AddWithValue("@quantity", int.Parse(quantity));
                command.ExecuteNonQuery();
                connection.Close();
                inventory.Rows.Add(name, category, price, quantity);
                button1_Click(sender, e);
                Form1_Load(sender, e);
            }
        }

        //DELETE BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.Rows[int.Parse(dataGridView1.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
                if(id != null)
                {
                    //MessageBox.Show(id.ToString());
                    connection.Open();
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM items WHERE id = @id;", connection);
                    deleteCmd.Parameters.AddWithValue("@id", id);
                    deleteCmd.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("tidak ada yang dipilih");
                }
                Form1_Load(sender, e);
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
