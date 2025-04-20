using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Course
    {
        protected string courseName;
        protected int marks;
        public Course(string courseName, int marks)
        {
            this.courseName = courseName;
            this.marks = marks;
        }
       
        public virtual string IsPassed()
        {
            return "" ;
        }
    }
}
