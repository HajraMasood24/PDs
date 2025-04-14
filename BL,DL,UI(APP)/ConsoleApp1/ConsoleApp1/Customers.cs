using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Customers
    {
        public string password;
        public string username;
        public string email;
        public string name;
        public List<Product> product;
        public Customers() { }
        public Customers(string username,string password)
        {
            this.username = username;
            this.password = password;
        }
        public Customers(string password, string username, string email, string name,List<Product> product)
        {
            this.password = password;
            this.username = username;
            this.email = email;
            this.name = name;
            this.product= new List<Product>();
    }
    }
}
