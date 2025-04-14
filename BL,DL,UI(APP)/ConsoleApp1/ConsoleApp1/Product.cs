using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        public string productId;
        public string productName;
        public string productDescription;
        public string productType;
        public Product() { }
        public Product(string productId, string productName, string productDescription, string productType)
        {
            this.productId = productId;
            this.productName = productName;
            this.productDescription = productDescription;
            this.productType = productType;
        }
    }
    
}
