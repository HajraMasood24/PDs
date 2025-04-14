using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__APP_.BL
{
    internal class AdminBL
    {
        public string username;
        public string password;
        public string email;
        public string phone;
        public string name;
        public AdminBL() { }
        public AdminBL(string username, string password) 
        {
            this.username = username;
            this.password = password;
        }
       
    }
}
