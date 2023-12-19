using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoTrack
{
    public partial class InventoTrack : Form
    {
        
        SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        public InventoTrack()
        {
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
                newButton_Click.Show();
            }
            else
            {
                dataGridView1.DataSource = null;
                deleteButton_Click.Hide();
                newButton_Click.Hide();
            }
            
            connection.Close();
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }
            catch (Exception err)
            {
                Console.WriteLine("There has been an error: " + err);
            }

        }

        //EDIT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = nameTextBox.Text;
                String category = categoryComboBox.Text;
                string price = priceNUD.Text;
                string quantity = quantityNUD.Text;
                int id = int.Parse(dataGridView1.Rows[int.Parse(dataGridView1.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
                connection.Open();
                SqlCommand editCmd = new SqlCommand("UPDATE items SET name = @name, category = @category, price = @price, quantity = @quantity WHERE id = @id;", connection);
                editCmd.Parameters.AddWithValue("@name", name);
                editCmd.Parameters.AddWithValue("@category", category);
                editCmd.Parameters.AddWithValue("@price", int.Parse(price));
                editCmd.Parameters.AddWithValue("@quantity", int.Parse(quantity));
                editCmd.Parameters.AddWithValue("@id", id);
                editCmd.ExecuteNonQuery();
                connection.Close();
                Form1_Load(sender, e);
                nameTextBox.Text = "";
                categoryComboBox.Text = "";
                priceNUD.Text = "0";
                quantityNUD.Text = "0";
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
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
                Form1_Load(sender, e);
                nameTextBox.Text = "";
                categoryComboBox.Text = "";
                priceNUD.Text = "0";
                quantityNUD.Text = "0";
            }
        }

        //DELETE BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.Rows[int.Parse(dataGridView1.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
                connection.Open();
                SqlCommand deleteCmd = new SqlCommand("DELETE FROM items WHERE id = @id;", connection);
                deleteCmd.Parameters.AddWithValue("@id", id);
                deleteCmd.ExecuteNonQuery();
                connection.Close();
                Form1_Load(sender, e);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand selectAll = new SqlCommand("SELECT * FROM items;", connection);
                SqlDataReader reader = selectAll.ExecuteReader();
                string pathFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fileName = "InventoTrack.csv";
                string filePath = Path.Combine(pathFolder, fileName);
                StreamWriter file = new StreamWriter(filePath);
                file.WriteLine("id,name,category,price,quantity");
                while (reader.Read())
                {
                    file.WriteLine("{0},{1},{2},{3},{4}", reader["id"], reader["name"], reader["category"], reader["price"], reader["quantity"]);
                }
                file.Close();
                connection.Close();
                MessageBox.Show("Report berhasil disimpan di folder Document dengan nama file InventoTrack.csv");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

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
            MessageBox.Show("Berhasil Keluar");
            this.Hide();
            LandingPage landingpage = new LandingPage();
            landingpage.Show();
        }
    }
}
