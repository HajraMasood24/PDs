using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using C__APP_.DL;
using Lab2;

namespace C__APP_.UI
{
    internal class AdminUI
    {
        public static void adminlogin()
        {
            Console.Clear();
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string userpassword = Console.ReadLine();
            DL.AdminDL.login(username, userpassword);

        }

        public char adpg()
        {
            int x = 15, y = 5;
            char option;
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("********************WELCOME TO ADMIN PAGE**************************");

            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("a. View Golden Card Holders");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("b. Menu");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("c. Customer list");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("d. Return main page");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("Enter option:");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        public char op4b()
        {
            int x = 15, y = 5;
            char option;

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("#####################################################################");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("                           GOLDEN CARD                               ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("#####################################################################");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("Press a to add golden card holder");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("Press b to view card holder's information");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("Press c to update golden card holder information");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine("Press d to delete golden card holder information");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine("Press e to view current golden card holders");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("Press f to return to main page");
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine("Enter option:");
            option = char.Parse(Console.ReadLine());
            return option;

        }
        public void add()
        {
            int x = 15, y = 5;

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("************************ADD**********************************");
            string username;
            Console.WriteLine("Enter the Username:");
            username = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Enter your information");
            Console.WriteLine("Enter PIN:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter phone number:");
            string cell = Console.ReadLine();
            Console.WriteLine("Enter email address:");
            string email = Console.ReadLine();
            DL.AdminDL.addInfo(username, name, email, cell, password);
           

        }
        public void list()
        {
            int x = 15, y = 5;
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("**************************************************************");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("                    CARD HOLDERS                         ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("**************************************************************");
            Console.SetCursorPosition(x, y + 5);
           
            AdminDL adminDL= new AdminDL();
            var viewList = adminDL.viewList();
            if (viewList.Count > 0)
            {
                Console.WriteLine("List of golden card holders");
                foreach (var view in viewList)
                {
                    Console.WriteLine($"{view.username} ");

                }
            }
            Console.WriteLine("Enter 1 to go back");

        }
        public void viewdetails()
        {
            int x = 15, y = 5;
            Console.Clear();
            string username;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("************************CARD HOLDER DETAILS**********************************");

            Console.WriteLine("Enter your username to view your details: ");
            username = Console.ReadLine();
            DL.AdminDL.viewInfo(username);
        }
        public bool update()
        {
            int x = 15, y = 5;

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("************************UPDATE**********************************");
            string username;
            Console.WriteLine("Enter the Username:");
            username = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Enter updated information");
            Console.WriteLine("Enter new PIN:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter phone number:");
            string cell = Console.ReadLine();
            Console.WriteLine("Enter email address:");
            string email = Console.ReadLine();
            DL.AdminDL.updateInfo(username, name, email, cell, password);
            return true;

        }
        public void deleteuser()
        {
            int x = 15, y = 5;

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("************************DELETE**********************************");
            string username;
            Console.WriteLine("Enter the Username:");
            username = Console.ReadLine();
            Console.Clear();
            DL.AdminDL.delinfo(username);

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
            DL.AdminDL.showMenu();
            Console.WriteLine("Enter 1 to go back");
        }
        public bool additem()
        {
            string Item;
            int Price,category;
            Console.Clear();
            Console.SetCursorPosition(15, 5);
            Console.WriteLine("Enter a new item:");
            Item = Console.ReadLine();
            Console.SetCursorPosition(15, 7);
            Console.WriteLine("Enter price of item:");
            Price = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(15, 9);
            Console.WriteLine("Select category");
            Console.SetCursorPosition(25, 11);
            Console.WriteLine("(1) for coffee and (2) for desserts");
            category = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(15, 13);
            DL.AdminDL.addMenu(Item,Price,category);
            Console.WriteLine("Enter 1 to go back");
            return false;

        }
        public bool updatemenu()
        {
            Console.Clear();
            Console.Write("Enter the item you want to update: ");
            string item = Console.ReadLine();
            Console.Write("Enter updated price:");
            int price = int.Parse(Console.ReadLine());
            DL.AdminDL.updateMenu(item,price);
            Console.WriteLine("Enter 1 to go back");
            return false;

        }
        public void Deleteitem()
        {
            Console.Clear();
            Console.WriteLine("Enter the item you want to delete from the menu");
            string item = Console.ReadLine();
            DL.AdminDL.deleteMenu(item);
            Console.WriteLine("Enter 1 to go back");
        }
        public void customers()
        {
            int x = 15, y = 5;
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("**************************************************************");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("                    CUSTOMER LIST                        ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("**************************************************************");
            
            AdminDL adminDL = new AdminDL();
            var viewList = adminDL.ShowCustomers();
            if (viewList.Count > 0)
            {
                Console.WriteLine("Customer name \t\t Phone number");
                foreach (var view in viewList)
                {
                    Console.WriteLine($"{view.username} \t\t {view.cell}");

                }
            }
            Console.WriteLine("Enter 1 to go back");

        }
    }
}


