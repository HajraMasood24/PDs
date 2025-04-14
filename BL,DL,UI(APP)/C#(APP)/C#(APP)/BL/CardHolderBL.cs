using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__APP_.BL
{
    internal class CardHolderBL
    {
        public string username {  get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string email {  get; set; }
        public string cell {  get; set; }

        public CardHolderBL() { }
        public CardHolderBL(string username, string password, string name, string email, string cell)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.email = email;
            this.cell = cell;
        }
        public CardHolderBL(string username)
        {
            this.username = username;
        }
    }

}
