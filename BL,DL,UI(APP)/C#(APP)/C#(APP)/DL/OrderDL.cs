using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lab2;

namespace C__APP_.DL
{
    internal class OrderDL
    {
        public static void SaveOrder(string itemName, int quantity, double price)
        {
            string name = UI.CustomerUI.customerName;

            string query = $"INSERT INTO orders (item_id, customers_id, quantity, price) " +
                          $"SELECT (SELECT item_id FROM menu WHERE item_name='{itemName}'), " +
                          $"(SELECT customers_id FROM customers WHERE customers_name='{name}'), {quantity}, {price}";

            string query1 = $@"UPDATE customers c
                  JOIN (SELECT customers_id, SUM(price) as new_total 
                        FROM orders 
                        WHERE customers_id = (SELECT customers_id FROM customers WHERE customers_name = '{name}')
                        GROUP BY customers_id) o
                  ON c.customers_id = o.customers_id
                  SET c.total = o.new_total
                  WHERE c.customers_name = '{name}'";

            DatabaseHelper.Instance.Update(query);
            DatabaseHelper.Instance.Update(query1);
        }
        

        public static double GetItemPrice(string itemName)
        {
            string query = $"SELECT price FROM menu WHERE item_name = '{itemName}'";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                {
                    return Convert.ToDouble(reader["price"]);
                }
            }
            return -1;
        }

        public static double GetTotalBill()
        {
            string name = UI.CustomerUI.customerName;
            string query = $"SELECT SUM(price) AS new_total FROM orders WHERE customers_id = (SELECT customers_id FROM customers WHERE customers_name = '{name}')";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                {
                    return Convert.ToDouble(reader["new_total"]);
                }
            }
            return 0;
        }

        public static bool ValidateGoldenCard(string name, string pin)
        {
            string query = $"SELECT * FROM card_holder WHERE username = '{name}' AND pin = '{pin}'";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                return reader.Read();
            }
        }
    }
}
