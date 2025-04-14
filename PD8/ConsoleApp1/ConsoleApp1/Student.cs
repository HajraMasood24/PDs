using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student:Person
    {
        private string program;
        private int year;
        private double fee;
        public Student(string name, string address, string program, int year, double fee): base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string getProgram()
        {
            return this.program;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public int getYear() 
        {
            return this.year;
        }
        public void setYear(int year) 
        {
            this.year=year;
        }
        public double getFee()
        {
            return this.fee; 
        }
        public void setFee(double fee)
        { 
            this.fee = fee;
        }
        public override string ToString()
        {
            return $"Student[{base.ToString()},program={program},year={year},fee={fee}]";
        }
    }
}
