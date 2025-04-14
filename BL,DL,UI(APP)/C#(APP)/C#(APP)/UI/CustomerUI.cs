using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__APP_.BL;
using C__APP_.DL;

namespace C__APP_.UI
{
    internal class CustomerUI
    {
        public static string customerName;
        public string customerCell;
        public int customerMenu()
        {
            int op=0;
            int x = 15, y = 5;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("###################################################################");

            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("\t\t@@");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("\t\t@@");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("\t\t@@      @@@  @@@@ @@@@ @@@@");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("\t\t@@     @   @  @@   @@  @");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("\t\t@@  @@ @@@@@  @@   @@  @@@");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("\t@@     @@@@@@ @   @  @@   @@  @@@@@");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine("\t@@");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine("\t@@       @@@  @  @ @@@@  @@@   @@@");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("\t@@      @   @ @  @ @  @ @   @ @   @");
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine("\t@@      @   @ @  @ @  @ @   @ @@@@");
            Console.SetCursorPosition(x, y + 11);
            Console.WriteLine("\t@@@@@@@  @@@   @@  @  @  @@ @  @@@@@");
            Console.SetCursorPosition(x, y + 12);
            Console.WriteLine("\t\t\t@\n");
            Console.SetCursorPosition(x, y + 13);
            Console.WriteLine("\t\t @@");
            Console.SetCursorPosition(x, y + 14);
            Console.WriteLine("*****************************************************************");
            Console.SetCursorPosition(x, y + 15);
            Console.WriteLine("* \t\tWhere every sip tells a story     *");
            Console.SetCursorPosition(x, y + 16);
            Console.WriteLine("* \tCoffee  •  Comfort  •  Community       *");
            Console.SetCursorPosition(x, y + 17);
            Console.WriteLine("*****************************************************************");

            Console.SetCursorPosition(x + 4, y + 18);
            Console.WriteLine("CUSTOMER");
            Console.SetCursorPosition(x + 4, y + 19);
            Console.WriteLine("*******************************************************************");
            Console.SetCursorPosition(x + 4, y + 20);
            Console.WriteLine("1. Menu");
            Console.SetCursorPosition(x + 4, y + 21);
            Console.WriteLine("2. Feedback");
            Console.SetCursorPosition(x + 4, y + 22);
            Console.WriteLine("3. Golden Card");
            Console.SetCursorPosition(x + 4, y + 23);
            Console.WriteLine("4. Return to main page");
            Console.SetCursorPosition(x + 4, y + 24);
            Console.WriteLine("##################################################################");

            Console.SetCursorPosition(x + 4, y + 25);
            Console.Write("Select an option: ");

            return op;
        }
        public void Info()
        {
            Console.Clear();
            

            while (true)
            {
                Console.Write("Enter your name: ");
                customerName = Console.ReadLine();

                if (CustomerBL.ValidateName(customerName))
                    break;
                else
                    Console.WriteLine("Invalid name. Please use alphabets only.");
            }

            while (true)
            {
                Console.Write("Enter your phone number: ");
                customerCell = Console.ReadLine();

                if (CustomerBL.ValidatePhone(customerCell))
                    break;
                else
                    Console.WriteLine("Invalid phone number. It must be 11 digits.");
            }

            CustomerDL.SaveCustomer(customerName, customerCell);
            Console.WriteLine("Customer information saved successfully.");
        }
    }
}
