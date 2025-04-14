using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__APP_.BL
{
    internal class CustomerBL
    {
        public string username { get; set; }
        public string cell { get; set; }
        public int total { get; set; }

        public CustomerBL()
        { }

        public CustomerBL(string username, string cell, int total)
        {
            this.username = username;
            this.cell = cell;
            this.total = total;
        }
        public CustomerBL(string username, string cell)
        {
            this.username = username;
            this.cell = cell;
          
        }


        public static bool ValidateName(string name)
        {
            foreach (char ltr in name)
            {
                if (!char.IsLetter(ltr) && ltr != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidatePhone(string phone)
        {
            return phone.Length == 11 && long.TryParse(phone, out _);
        }
    }
}
