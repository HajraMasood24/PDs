using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__APP_.BL;
using C__APP_.DL;
using Lab2;

namespace C__APP_.UI
{
    internal class OrderUI
    {
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("                           Main Menu                             ");
            Console.WriteLine("-----------------------------------------------------------------");

            string query = "SELECT item_name, price FROM menu";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    Console.WriteLine("- {0} _______________________ Rs.{1}", reader["item_name"], reader["price"]);
                }
            }
        }

        public void PlaceOrder()
        {
            Console.Write("Enter the number of items you want to order: ");
            int itemCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < itemCount; i++)
            {
                Console.Write("Item: ");
                string itemName = Console.ReadLine();
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                if (OrderBL.ValidateItem(itemName) && OrderBL.ValidateQuantity(quantity))
                {
                    double price = OrderDL.GetItemPrice(itemName);
                    if (price != -1)
                    {
                        OrderDL.SaveOrder(itemName, quantity, price * quantity);
                        Console.WriteLine("Order placed successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Item not found in menu.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid item or quantity.");
                }
            }
        }

        public void CalculateTotalBill()
        {
            Console.Write("Choose a payment method (a. Credit card  b. Cash): ");
            Console.ReadLine();

            Console.Write("ARE YOU A GOLDEN CARD HOLDER? (a. Yes  b. No): ");
            char goldenCardHolder = Console.ReadLine()[0];
            bool isGoldenCardHolder = false;

            if (goldenCardHolder == 'a')
            {
                Console.Write("Enter your username: ");
                string name = Console.ReadLine();
                Console.Write("Enter your pin: ");
                string pin = Console.ReadLine();
                isGoldenCardHolder = OrderDL.ValidateGoldenCard(name, pin);
            }

            double finalBill = OrderBL.CalculateTotalBill(isGoldenCardHolder);
            Console.WriteLine("Final bill: Rs. {0}", finalBill);
            Console.WriteLine("Press enter key to go back to main page");
            Console.ReadLine();
        }
    }
}

