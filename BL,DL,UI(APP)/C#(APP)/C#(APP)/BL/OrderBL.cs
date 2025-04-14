using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysqlx.Crud;

namespace C__APP_.BL
{
    internal class OrderBL
    {
        public string item {  get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        public OrderBL() { }
        public OrderBL(string item, string quantity, string price)
        {
            this.item = item;
            this.quantity = quantity;
            this.price = price;
        }

        public static bool ValidateItem(string item)
        {
            return !string.IsNullOrWhiteSpace(item);
        }

        public static bool ValidateQuantity(int quantity)
        {
            return quantity > 0;
        }

        public static double CalculateTotalBill(bool isGoldenCardHolder)
        {
            double total = DL.OrderDL.GetTotalBill();
            if (isGoldenCardHolder)
            {
                total -= total * 0.10;
            }
            return total;
        }
    }
}
