using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Stats
    {
       
            public string skillName;
            public int Damage;
            public string Description;
            public int Penetration;
            public int Cost;
            public int Heal;
        public Stats()
        {
        }
        public Stats(string sname,int damage,string description,int penetration,int cost, int heal)
        {
            skillName = sname;    
            Damage = damage;
            Description = description;
            Penetration = penetration;
            Cost = cost;
            Heal = heal;
        }
    }
    
}
