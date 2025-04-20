using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class GradedCourse:Course
    {
       
        private int gradePoint;
        
        public GradedCourse(string courseName, int marks):base (courseName,marks) 
        {
            this.courseName = courseName;
            this.marks = marks;
        }
        public int getGradePoint()
        {

            if (marks >= 90 && marks <= 100)
            {
                return gradePoint = 12;

            }
            if (marks >= 80 && marks < 90)
            {
                return gradePoint = 10;

            }
            if (marks >= 70 && marks <= 80)
            {
                return gradePoint = 7;

            }
            if (marks >= 60 && marks < 70)
            {
                return gradePoint = 4;

            }
            if (marks >= 50 && marks <= 60)
            {
                return gradePoint = 02;

            }
            if (marks >= 40 && marks < 50)
            {
                return gradePoint = 0;

            }
            else
            {
                return gradePoint = -3;

            }

        }
        public void setGradePoint(int gradePoint)
        {
            this.gradePoint = gradePoint;

        }
        public override string IsPassed()
        {
            if (gradePoint == 0 || gradePoint == -3)
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
