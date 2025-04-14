using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1.DL
{
    internal class ListOFstudentsDL
    {
        static List<Student> sList = new List<Student>();
        public static List<Student> ListofStudents()
        {
            return sList;
        }
        public static void registerStudents()
        {
            foreach (Student student in sList)
            {
            }
        }
        
        
    }
}
