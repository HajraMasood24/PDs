using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class AbsoluteGradedCourse
    {
        public string courseName;
        protected int marks;
        private string grade;
        public AbsoluteGradedCourse(string courseName, int marks)
        {
            this.courseName = courseName;
            this.marks = marks;
            
        }

        public string getGrade()
        {

            if (marks >= 90 && marks <= 100)
            {
                grade = "A+";
                return grade;

            }
            if (marks >= 80 && marks < 90)
            {

                return grade = "A";

            }
            if (marks >= 70 && marks <= 80)
            {

                return grade = "B";

            }
            if (marks >= 60 && marks < 70)
            {

                return grade = "C";

            }
            if (marks >= 50 && marks <= 60)
            {

                return grade = "D";

            }
            if (marks >= 0 && marks < 50)
            {

                return grade = "F";

            }
            return "is your grade";
        }

        public void setGrade(string grade)
        {
            this.grade = grade;

        }
        public string isPassed()
        {
            if (grade == "F")
            {
                return "Failed";
            }
            else
            {
                return "Passed";
            }
        }

    }
}
