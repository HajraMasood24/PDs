using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1.UI
{
    internal class DegreeProgram
    {
        public void MenuDegree()
        {
            Subject subject = new Subject();

        }
            public static void EnterDegreeDetails()
            {
                Console.Clear();
                Console.Write("Enter Degree Name: ");
                string degreeName = Console.ReadLine();

                Console.Write("Enter Degree Duration (years): ");
                int degreeDuration = int.Parse(Console.ReadLine());

                Console.Write("Enter Seats for Degree: ");
                int degreeSeats = int.Parse(Console.ReadLine());

                List<Subject> tempList= new List<Subject>(); ;
                Console.Write("Enter how many Subjects to Enter: ");
                int subjectCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < subjectCount; i++)
                {
                    Console.Write("Enter Subject Code: ");
                    string subjectCode = Console.ReadLine();

                    Console.Write("Enter Subject Type: ");
                    string subjectType = Console.ReadLine();

                    Console.Write("Enter Subject Credit Hours: ");
                    int creditHours = int.Parse(Console.ReadLine());

                    Console.Write("Enter Subject Fees: ");
                    int subjectFees = int.Parse(Console.ReadLine());

                    tempList.Add(new Subject(subjectCode, creditHours, subjectType, subjectFees));
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        

    }
}

