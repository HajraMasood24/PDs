using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lab2;
using MySqlX.XDevAPI;
using C__APP_.BL;

namespace C__APP_.DL
{
    internal class AdminDL
    {
        
        public static void login(string username,string userpassword)
        {
            bool valid=false;
            string query = $"SELECT * FROM admin WHERE admin_name = '{username}' AND password = '{userpassword}'";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
               valid = true;
                Console.WriteLine("Login successful! Welcome, Admin.");

            }

            if (!valid)
            {
                Console.WriteLine("Invalid username or password. Please try again.\n");
                UI.AdminUI.adminlogin();
            }
        }
        public List<CardHolderBL> viewList()
        {
            List<CardHolderBL> holders = new List<CardHolderBL>();
            string query = "SELECT username FROM card_holder";

            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                holders.Add(new CardHolderBL(reader["username"].ToString()));

            }
          
            reader.Close();
            return holders;
        }
       

        public static void viewInfo(string username)
        {

            string query = $"SELECT * FROM card_holder WHERE username = '{username}'";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                Console.WriteLine("Username \t\t Name \t\t Email \t\t\t Phone Number");
                Console.WriteLine($"{reader["username"]} \t-{reader["name"]}\t- {reader["email"]} \t-{reader["cel"]}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
        public static void addInfo(string username, string name, string email, string cell, string password)
        {
            string query = $"INSERT INTO card_holder (username, name, pin, email, cel) VALUES ('{username}', '{name}','{password}','{email}','{cell}')";

            DatabaseHelper.Instance.Update(query);
            Console.WriteLine("Added successfully");
            Console.WriteLine("Enter 1 to go back");

        }
        public static void updateInfo(string username,string name,string email,string cell,string password) 
        {
            
            string query = $"UPDATE card_holder SET name = '{name}', pin = {password}, email = '{email}', cel = {cell} WHERE username = '{username}'";
            DatabaseHelper.Instance.Update(query);
            Console.WriteLine("Updated successfully");
            Console.WriteLine("Enter 1 to go back");
        }
        public static void delinfo(string username)
        {
            string query = $"DELETE FROM card_holder WHERE username = '{username}'";
            DatabaseHelper.Instance.Update(query);
            Console.WriteLine("Deleted successfully");
            Console.WriteLine("Enter 1 to go back");
        }
        public static void showMenu()
        {
            string query = "SELECT * FROM menu";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Console.WriteLine("Items\t\tPrice");
                Console.WriteLine($"{reader["item_name"]}\t\t {reader["price"]} ");
            }
            
        }
        public static void addMenu(string item, int price, int category) 
        {
            string query = $"INSERT INTO menu (item_name, price, category_id) VALUES ('{item}', '{price}','{category}')";

            DatabaseHelper.Instance.Update(query);
            Console.WriteLine("Added successfully");
           
        }
        public static void updateMenu(string item,int price)
        {
            string query = $"UPDATE menu SET price = {price} WHERE item_name = '{item}' ";
            DatabaseHelper.Instance.Update(query);
            Console.WriteLine("Updated successfully");
            
        }
        public static void deleteMenu(string item) 
        {
            string query = $"DELETE FROM menu WHERE item_name = '{item}'";
            DatabaseHelper.Instance.Update(query);
            Console.WriteLine("Deleted successfully");
            Console.WriteLine("Enter 1 to go back");
        }
        
        public List<CustomerBL> ShowCustomers()
        {
            List<CustomerBL> holders = new List<CustomerBL>();
            string query = "SELECT * FROM Customers";

            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                holders.Add(new CustomerBL(reader["customers_name"].ToString(), reader["customer_cell"].ToString()));

            }

            reader.Close();
            return holders;
        }
    }
}
