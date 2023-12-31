﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.CompilerServices;

namespace InventoTrack

{
    internal class Person
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Person(int id, string username, string email, string password)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
        }
        public static void openConnection(SqlConnection connection)
        {
            connection.Open();
        }
        public static void closeConnection(SqlConnection connection)
        {
            connection.Close();
        }
        public static void sendOTP(string email, string randomCode)
        {
            String from, pass, messageBody;
            from = "inventotrack@gmail.com";
            pass = "nrig zldn uoge jwhc";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            MailMessage message = new MailMessage();
            messageBody = "Terimakasih telah mencoba mendaftar di aplikasi InventoTrack, berikut merupakan kode OTP: " + randomCode;
            message.To.Add(email);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Kode Verifikasi OTP";
            smtp.Send(message);
            MessageBox.Show("Kode OTP Berhasil dikirimkan");
        }
        public static void updatePassword(string email, string password, SqlConnection connection)
        {
            SqlCommand updatePasswordCmd = new SqlCommand("UPDATE users SET password = @password WHERE email = @email;", connection);
            updatePasswordCmd.Parameters.AddWithValue("@email", email);
            updatePasswordCmd.Parameters.AddWithValue("@Password", password);
            updatePasswordCmd.ExecuteNonQuery();
            MessageBox.Show("Password has been reset, Please Login again");
        }
        public static string getEmail(string username, string password, SqlConnection connection)
        {
            SqlCommand selectEmail = new SqlCommand("SELECT email FROM users WHERE username = @username AND password = @password;", connection);
            selectEmail.Parameters.AddWithValue("@username", username);
            selectEmail.Parameters.AddWithValue("@password", password);
            string email = (string)selectEmail.ExecuteScalar();
            return email;
        }
        public static int getUserId(string email, SqlConnection connection)
        {
            SqlCommand selectId = new SqlCommand("SELECT id FROM users WHERE email= @email;", connection);
            selectId.Parameters.AddWithValue("@email", email);
            int id = (int)selectId.ExecuteScalar();
            return id;
        }
        public static bool checkUserLogin(string username, string password, SqlConnection connection)
        {
            SqlCommand cul = new SqlCommand("SELECT dbo.CheckUserLogin(@Username, @Password);", connection);
            cul.Parameters.AddWithValue("@Username", username);
            cul.Parameters.AddWithValue("@Password", password);
            bool isCanLogin = (bool)cul.ExecuteScalar();
            return isCanLogin;
        }
        public static void registUser(string username, string email, string password, SqlConnection connection)
        {
            string insertString = "INSERT INTO users (username, email, password) VALUES (@Username, @Email, @Password)";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);
            insertCommand.Parameters.AddWithValue("@Username", username);
            insertCommand.Parameters.AddWithValue("@Email", email);
            insertCommand.Parameters.AddWithValue("@Password", password);
            insertCommand.ExecuteNonQuery();
            MessageBox.Show($"Register Success, welcome {username} Please Login");
        }
    }
    internal class Users
    {
        public Person personDetail { get; set; }
        public Users() { }
        public Users(int id, string username, string email, string password)
        {
            personDetail = new Person(id, username, email, password);
        }
        public SqlDataReader selectAllItems(SqlConnection connection)
        {
            SqlCommand selectAll = new SqlCommand("SELECT * FROM items", connection);
            selectAll.ExecuteNonQuery();
            return selectAll.ExecuteReader();
        }
        
        
        public int checkItem(string name)
        {
            SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            connection.Open();
            SqlCommand checkNameCmd = new SqlCommand("SELECT COUNT(*) FROM items WHERE name = @name;", connection);
            checkNameCmd.Parameters.AddWithValue("@name", name);
            int count = (int)checkNameCmd.ExecuteScalar();
            connection.Close();
            return count;
        }
        public void addItem(string name, string category, string price, string quantity, int count)
        {
            SqlConnection connection = new SqlConnection("Server=tcp:inventotrackserver.database.windows.net,1433;Initial Catalog=inventotrackDB;Persist Security Info=False;User ID=admin1;Password=It123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            if (count > 0)
            {
                MessageBox.Show("Product has already exist, you can edit the product or change the name of product");
            }
            else
            {
                connection.Open();
                SqlCommand insertItemCmd = new SqlCommand("INSERT INTO items (name, category, price, quantity) VALUES (@name, @category, @price, @quantity);", connection);
                insertItemCmd.Parameters.AddWithValue("@name", name);
                insertItemCmd.Parameters.AddWithValue("@category", category);
                insertItemCmd.Parameters.AddWithValue("@price", int.Parse(price));
                insertItemCmd.Parameters.AddWithValue("@quantity", int.Parse(quantity));
                insertItemCmd.ExecuteNonQuery();
                connection.Close();
            }
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
