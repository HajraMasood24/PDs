using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Problem1.UI;

namespace Problem1.BL
{
    internal class Student
    {
        public string Name;
        public int age;
        public float FSCMarks;
        public float EcatMarks;
        public float merit;
        List<DegreeProgram> prefrences;
        public List<Subject> RegisteredSubjects;
        public Student(string Name, int age, float FSCMarks, double EcatMarks)
        {
            this.Name = Name;
            this.age = age;
            this.FSCMarks = FSCMarks;
            EcatMarks = this.EcatMarks;
        
        }
        public Student() { }

        public float calculateMerit()
        {
           float merit= (FSCMarks / 1100) * 60 + (EcatMarks / 400) * 40;
            return merit;
        }
        public void regStudentSubject(Subject s)
        {
            if (!RegisteredSubjects.Contains(s))
            {
                RegisteredSubjects.Add(s);
            }
        }
        public int getCreditHours()
        {
            return 0;
        }
        public float calculateFee() 
        {
            int totalFee = 0;
            foreach (var subject in RegisteredSubjects)
            {
                totalFee +=subject.subjectFee;
            }
            return totalFee;
        }
    }
}
