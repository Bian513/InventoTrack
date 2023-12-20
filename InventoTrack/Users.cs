using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoTrack
{
    internal class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Users() { }
        public Users(int id, string username, string email, string password)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
        }

        public static void sendOTP(string email, string randomCode)
        {
            String from, pass, messageBody, to;
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
            smtp.Send(message);
            MessageBox.Show("Kode OTP Berhasil dikirimkan");
        }


        public void addItem(string name, string category, string price, string quantity)
        {
            SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            connection.Open();
            SqlCommand checkName = new SqlCommand("SELECT COUNT(*) FROM items WHERE name = @name;", connection);
            checkName.Parameters.AddWithValue("@name", name);
            int count = (int)checkName.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Product has already exist, you can edit the product or change the name of product");
            }
            else
            {
                string commandString = "INSERT INTO items (name, category, price, quantity) VALUES (@name, @category, @price, @quantity);";
                SqlCommand command = new SqlCommand(commandString, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@price", int.Parse(price));
                command.Parameters.AddWithValue("@quantity", int.Parse(quantity));
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void updateItem(int id, string name, string category, string price, string quantity)
        {
            SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            connection.Open();
            SqlCommand editCmd = new SqlCommand("UPDATE items SET name = @name, category = @category, price = @price, quantity = @quantity WHERE id = @id;", connection);
            editCmd.Parameters.AddWithValue("@name", name);
            editCmd.Parameters.AddWithValue("@category", category);
            editCmd.Parameters.AddWithValue("@price", int.Parse(price));
            editCmd.Parameters.AddWithValue("@quantity", int.Parse(quantity));
            editCmd.Parameters.AddWithValue("@id", id);
            editCmd.ExecuteNonQuery();
            connection.Close();
        }
        public void deleteItem(int id)
        {
            SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            connection.Open();
            SqlCommand deleteCmd = new SqlCommand("DELETE FROM items WHERE id = @id;", connection);
            deleteCmd.Parameters.AddWithValue("@id", id);
            deleteCmd.ExecuteNonQuery();
            connection.Close();
        }
        public void exportItems()
        {
            SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
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
        }
        
    }
}
