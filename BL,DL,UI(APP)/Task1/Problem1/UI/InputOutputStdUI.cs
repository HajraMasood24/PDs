using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1.UI
{
    internal class InputOutputStdUI
    {

        public static void AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter FSC Marks: ");
            int FSCMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Ecat Marks: ");
            int EcatMarks = int.Parse(Console.ReadLine());

            Student newStudent = new Student(Name, age, FSCMarks, EcatMarks);
        }
        
    }
}
