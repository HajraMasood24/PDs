using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1.DL
{
    internal class StoringDegProgramDL
    {
        static List<DegreeProgramBL> degreeList = new List<DegreeProgramBL>();
        public static void AddDegree(DegreeProgramBL degree)
        {
            degreeList.Add(degree);
        }
    }
}
