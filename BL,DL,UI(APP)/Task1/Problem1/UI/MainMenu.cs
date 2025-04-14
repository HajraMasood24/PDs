using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.UI
{
    internal class MainMenu
    {
        public static void Menu()
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit");
            Console.WriteLine("4.View Registered Students");
            Console.WriteLine("5.View Students of a Specific Program ");
            Console.WriteLine("6.Register Subjects for a Specific Students ");
            Console.WriteLine("7.Calculate Fees for all REgistered Students ");
            Console.WriteLine("8.Exits ");
            Console.WriteLine(" ");
            Console.Write("Entered option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                UI.InputOutputStdUI.AddStudent();
            }
            else if (option == 2)
            {
                UI.DegreeProgram.EnterDegreeDetails();


            }
            else if (option == 3)
            {

            }
            else if (option == 4)
            {

            }
            else if (option == 5)
            {

            }
            else if (option == 6)
            {

            }
            else if (option == 7)
            {

            }
           
        }
    }
}
