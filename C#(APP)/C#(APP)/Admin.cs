using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C__APP_
{
    internal class Admin
    {
        string name, adminUser, record;
        int pin, adminPin;
        bool valid = false;
        int x = 15, y = 5;
        static List<string> coffee = new List<string> { "Espresso", "Cappuccino", "Latte", "Americano", "SpecialChai", "GreenTea", "ChaiLatte", "Brownies", "Cookies" };
        static List<int> price = new List<int> { 750, 650, 800, 500, 100, 150, 150, 650, 500 };
        public Admin()
        {

        }

        public void adminlogin(string path, string[] name, string[] password)
        {
            int x = 0;
            bool valid = false;
            
           Start:
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string userpassword = Console.ReadLine();
            if (File.Exists(path))
            {
                path = "C:\\2nd semester\\OOP\\PD\\C#(APP)\\admin.txt";
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    name[x] = getData(record, 1);
                    password[x] = getData(record, 2);

                    if (username == name[x] && userpassword == password[x])
                    {
                        valid = true;
                        Console.WriteLine("You have successfully logged in!");
                        break;

                    }
                    x++;

                }
                if (!valid)
                {
                    Console.WriteLine("Invalid username or pin!");
                    goto Start;
                }
                fileVariable.Close();

            }
        }
        static string getData(string record, int field)
        {
            int commaCount = 1;
            string item = "";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    item += record[x];
                }
            }
            return item;
        }



        
        public char op4b()
        {

            char option;

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("#####################################################################");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("                           GOLDEN CARD                               ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("#####################################################################");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("Press a to view current golden card holders");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("Press b to view card holder's information");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("Press c to update golden card holder information");
            Console.SetCursorPosition(x, y + 7);
            
            Console.WriteLine("Press e to return to main page");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("Enter option:");
            option = char.Parse(Console.ReadLine());
            return option;

        }
        public bool update()
        
        {
            string update = "";
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("************************UPDATE**********************************");
            string name, line;
            Console.WriteLine("Enter the Username:");
            name=Console.ReadLine();


            string path = "C:\\2nd semester\\OOP\\PD\\C#(APP)\\golden.txt";
            
            StreamReader fileVariable = new StreamReader(path);
            
            while ((line = fileVariable.ReadLine()) != null)
            {
                
                string[] info=new string[5];
                int commaCount = 0;
                string temp = "";
                for (int i = 0; i <= line.Length; i++)
                {
                    if (i == line.Length || line[i] == ',')
                    {
                        if (commaCount < 5)
                        {
                            info[commaCount] = temp;
                            temp = "";
                            commaCount++;
                        }
                    }
                    else
                    {
                        temp += line[i];
                    }
                }
                if (info[0] == name)
                {

                    Console.WriteLine("Enter updated information");
                    Console.WriteLine("Enter new PIN:");
                    info[1]=Console.ReadLine();
                    Console.WriteLine("Enter new username:");
                    info[0] = Console.ReadLine();
                    Console.WriteLine("Enter name:");
                    info[2] = Console.ReadLine();
                    Console.WriteLine("Enter phone number:");
                    info[3] = Console.ReadLine();
                    Console.WriteLine("Enter email address:");
                    info[4] = Console.ReadLine();

                }
                for (int i = 0; i < 5; i++)
                {
                    update += info[i];
                    if (i < 4)
                    {
                        update += ",";
                    }
                }
                update += "\n";
            }
            fileVariable.Close();

            
            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine( update);
            file.Close();
            Console.WriteLine("Enter 1 to go back");
            return true;
            
        }
        public void customers()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("**************************************************************");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("                    CUSTOMER LIST                        ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Customer name \t\t Phone number");
            
            string line;
            string path = "C:\\2nd semester\\OOP\\PD\\C#(APP)\\customers.txt";
            StreamReader fileVariable = new StreamReader(path);

            while ((line = fileVariable.ReadLine()) != null)

            {
                string name = getCustomerinfo(line, 1);
                string cell = getCustomerinfo(line, 2);
                Console.WriteLine(name + "\t\t\t" + cell );
            }
            Console.WriteLine("Enter 1 to go back");
            fileVariable.Close();
            


        }
        string getCustomerinfo(string record, int info)
        {
            int commaCount = 1;
            string item="";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == info)
                {
                    item += record[x];
                }
            }
            return item;
        }

        public bool list()
        {

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("**************************************************************");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("                    CARD HOLDERS                         ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("**************************************************************");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("List of golden card holders");
            string line;
            string path = "C:\\2nd semester\\OOP\\PD\\C#(APP)\\golden.txt";
            StreamReader fileVariable = new StreamReader(path);

            while ((line = fileVariable.ReadLine()) != null)
            {
                string[] info = new string[line.Length];
                int commaCount = 0;
                string temp = "";
                for (int i = 0; i <= line.Length; i++)
                {
                    if (i == line.Length || line[i] == ',')
                    {
                        if (commaCount < 5)
                        {
                            info[commaCount] = temp;
                            temp = "";
                            commaCount++;
                        }
                    }
                    else
                    {
                        temp += line[i];
                    }
                }
                Console.WriteLine("Username\t\t PIN");
                Console.WriteLine(info[0] + "\t\t\t" + info[1]);
            }
            Console.WriteLine("Enter 1 to go back");

            return true;
        }
        public void view()
        
        {
            Console.Clear();
            string searchName, line;
            bool found = false;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("************************CARD HOLDER DETAILS**********************************");

            Console.WriteLine("Enter your username to view your details: ");
            searchName=Console.ReadLine();
            string path = "C:\\2nd semester\\OOP\\PD\\C#(APP)\\golden.txt";
            StreamReader fileVariable= new StreamReader(path);
            

            while ((line = fileVariable.ReadLine()) != null)
            {
                string[] fields=new string[5];
                int commaCount = 0;
                string temp = "";

                for (int i = 0; i <= line.Length; i++)
                {
                    if (i == line.Length || line[i] == ',')
                    {
                        if (commaCount < 5)
                        {
                            fields[commaCount] = temp;
                            temp = "";
                            commaCount++;
                        }
                    }
                    else
                    {
                        temp += line[i];
                    }
                }

                if (fields[0] == searchName)
                {
                    found = true;

                    Console.WriteLine("\nDetails for " + searchName + ":\n");
                    Console.WriteLine("PIN: " + fields[1] );
                    Console.WriteLine("Name: " + fields[2]);
                    Console.WriteLine("Phone Number: " + fields[3]);
                    Console.WriteLine("Email Address: " + fields[4]);
                    break;
                }
            }

            fileVariable.Close();

            if (!found)
            {
                Console.WriteLine("No record found for username: " + searchName );
            }
            Console.WriteLine("Enter 1 to go back");
        }
        public char op4c()
        {

            Console.Clear();
            Console.SetCursorPosition(15, 5);
            Console.WriteLine("a.View menu");
            Console.SetCursorPosition(15, 6);
            Console.WriteLine("b.Add item");
            Console.SetCursorPosition(15, 7);
            Console.WriteLine("c.Update menu");
            Console.SetCursorPosition(15, 8);
            Console.WriteLine("d.Delete item");
            Console.SetCursorPosition(15, 9);
            Console.WriteLine("e.Return to Admin page");
            Console.Write("ENTER:");
            char op;
            op = char.Parse(Console.ReadLine());
            return op;

        }
        public void Viewmenu()
        {
            Console.Clear();
            Console.WriteLine("\nMenu:");
            for (int i = 0; i < coffee.Count; i++)
            {
                Console.WriteLine( coffee[i] + "         -           Rs." + price[i]);
            }
            Console.WriteLine("Enter 1 to go back");
        }
        public bool additem()

        {
            string newItem;
            int newPrice;
            Console.Clear();
            Console.WriteLine("Enter a new item:");
            newItem = Console.ReadLine();
            Console.WriteLine("Enter price of item:");
            newPrice = int.Parse(Console.ReadLine());
            coffee.Add(newItem);
            price.Add(newPrice);
            Console.WriteLine("Enter 1 to go back");
            return false;

        }
        public void Deleteitem()
        {
            Console.Clear();
            Console.WriteLine("Enter the item you want to delete from the menu");
            string item = Console.ReadLine();
            int index = coffee.IndexOf(item);
            if (index != -1)
            {
                coffee.RemoveAt(index);
                price.RemoveAt(index);
                Console.WriteLine("Item removed from menu.");

            }
            else
            {
                Console.WriteLine("\nItem not found! Unable to delete.");
            }
            Console.WriteLine("Enter 1 to go back");

        }
        public bool updatemenu()

        {
            Console.Clear();
            Console.Write("Enter the item you want to update: ");
            string item = Console.ReadLine();
            int index = coffee.IndexOf(item);
            if (index != -1)
            {
                Console.Write("Enter new item name: ");
                coffee[index] = Console.ReadLine();
                Console.Write("Enter new price: ");
                if (int.TryParse(Console.ReadLine(), out int newPrice))
                {
                    price[index] = newPrice;
                    Console.WriteLine("Menu updated successfully.");
                    return true;
                }
                Console.WriteLine("Invalid price input!");
                return false;
            }
            Console.WriteLine("Item not found on menu.");
            Console.WriteLine("Enter 1 to go back");
            return false;

        }

    }
}