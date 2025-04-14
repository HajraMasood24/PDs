using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1.DL
{
    internal class StoringSubject
    {
        public List<Subject> subjects = new List<Subject>();
        public bool isSubjectExists(Subject sub)
        {
            return false;
        }
        public void AddSubject(Subject s)
        {
            subjects.Add(s);
        }
        public int calculateCreditHours()
        {
            return 0;
        }
    }
}
