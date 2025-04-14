using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ali", "Lahore", "CS", 2, 50000);
            Staff t = new Staff("Sara", "Karachi", "FAST", 70000);

            Console.WriteLine(s);
            Console.WriteLine(t);
        }
    }
}
