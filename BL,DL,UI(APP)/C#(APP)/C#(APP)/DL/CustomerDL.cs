using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace C__APP_.DL
{
    internal class CustomerDL
    {
        
        public static void SaveCustomer(string name, string phone)
        {
            string query = $"INSERT INTO customers (customers_name, customer_cell) VALUES ('{name}', '{phone}')";
            DatabaseHelper.Instance.Update(query);
        }

    }
}
