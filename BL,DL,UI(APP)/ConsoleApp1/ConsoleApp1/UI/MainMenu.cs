using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UI
{
    internal class MainMenu
    {
        public static string Menu()
        {
            Console.WriteLine("1.Sign up\n2.Sign in\n3.Admin\n4.Exit\n");
            return Console.ReadLine();
        }
        public static void PressAnyKeyToContinue(string message)
        {
            Console.WriteLine(message)
        }
    }
}
