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
        Users users;
        public InventoTrack(int userId, string userName, string userEmail, string userPassword)
        {
            InitializeComponent();
            users = new Users(userId,userName, userEmail, userPassword);
        }

        private void InventoTrack_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataReader reader = users.selectAllItems(connection);
            if (reader.HasRows)
            {
                BindingSource source = new BindingSource();
                source.DataSource = reader;
                dataGridView.DataSource = source;
                deleteButton.Show();
                editButton.Show();
                downloadreportButton.Show();

            }
            else
            {
                dataGridView.DataSource = null;
                deleteButton.Hide();
                editButton.Hide();
                downloadreportButton.Hide();
            }
            connection.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception err)
            {
                Console.WriteLine("There has been an error: " + err);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string category = categoryComboBox.Text;
                string price = priceNUD.Text;
                string quantity = quantityNUD.Text;
                int id = int.Parse(dataGridView.Rows[int.Parse(dataGridView.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
                users.updateItem(id, name, category, price, quantity);
                InventoTrack_Load(sender, e);
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            String category = categoryComboBox.Text;
            string price = priceNUD.Text;
            string quantity = quantityNUD.Text;



            if (nameTextBox.Text == "")
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
                int count = users.checkItem(name);
                users.addItem(name, category, price, quantity, count);
                InventoTrack_Load(sender, e);
                nameTextBox.Text = "";
                categoryComboBox.Text = "";
                priceNUD.Text = "0";
                quantityNUD.Text = "0";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView.Rows[int.Parse(dataGridView.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());
                users.deleteItem(id);
                InventoTrack_Load(sender, e);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        private void downloadreportButton_Click(object sender, EventArgs e)
        {
            try
            {
                users.exportItems();
                MessageBox.Show("Report berhasil disimpan di folder Document dengan nama file InventoTrack.csv");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berhasil Keluar");
            this.Hide();
            LandingPage landingpage = new LandingPage();
            landingpage.Show();
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
    }
}
