using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================Result====================================");
            Console.WriteLine("Enter your COURSE NAME and MARKS to get result");
            Console.WriteLine("Enter Project Name:");
            string project=Console.ReadLine();
            Console.WriteLine("Enter name of course:");
            string course1=Console.ReadLine();
            Console.WriteLine("Enter marks:");
            int marks1=int.Parse(Console.ReadLine());
            AbsoluteGradedCourse a1 = new AbsoluteGradedCourse(course1, marks1);
            Console.WriteLine("Enter name of course:");
            string course2 = Console.ReadLine();
            Console.WriteLine("Enter marks:");
            int marks2 = int.Parse(Console.ReadLine());
            AbsoluteGradedCourse a2 = new AbsoluteGradedCourse(course2, marks2);
            Console.WriteLine("Enter name of course:");
            string course3 = Console.ReadLine();
            Console.WriteLine("Enter marks:");
            int marks3 = int.Parse(Console.ReadLine());
            GradedCourse g1 = new GradedCourse(course3, marks3);
            Console.WriteLine("Enter name of course:");
            string course4 = Console.ReadLine();
            Console.WriteLine("Enter marks:");
            int marks4 = int.Parse(Console.ReadLine());
            GradedCourse g2 = new GradedCourse(course4, marks4);
            List<Course> courseList = new List<Course> { a1, a2, g1, g2 };
            Project project1 = new Project(project, a1, a2, g1, g2);
            project1.Passed();

           


        }
    }
}

