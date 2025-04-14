using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Problem2
{
    internal class Player
    {
        public string name,sname;
        public int hp, maxHp;
        public int Energy,maxEnergy;
        public int Armor;
        static int damage,penetration,cost,heal;
        public Stats skillStatistics;

       

        public Player() 
        { }
        public Player(string name, int health, int energy, int armor)
        {
            name = this.name;
            hp = health;
            Energy = energy;
            Armor = armor;

        }
        public void UpadteHealth(int num)
        {
            hp += num;
            if (hp < 0)
            {
                hp = 0;
            }
            if (hp > maxHp)
            {
                hp -= maxHp;
            }
        }

        public void UpdateEnergy(int num)
        {
            Energy += num;
            if (Energy < 0)
            {
                Energy = 0;
            }
            if (Energy > maxEnergy)
            {
                Energy = maxEnergy;
            }
        }

        public void UpdateArmor(int num)
        {
            Armor += num;
            if (Armor < 0)
            {
                Armor = 0;
            }
            if (Armor > 100)
            {
                Armor = 100;
            }
        }
        public void learnSkill(Stats skillStat)
        {
            skillStatistics = skillStat;
        }

        public string Attack(Player target)
        {
            string result = "";
            if (skillStatistics == null)
            {
                result = name + "has no skill to attack.";
                return result;
            }
            if (Energy < skillStatistics.Cost)
            {
                result = name + " attempted to use " + skillStatistics.skillName + " but didn't have enough energy!.";
                return result;
            }
            UpdateEnergy(skillStatistics.Cost);
            float effectiveArmor = target.Armor - skillStatistics.Penetration;
            if (effectiveArmor < 0)
            {
                effectiveArmor = 0;
            }
            if (effectiveArmor > 100)
            {
                effectiveArmor = 100;
            }
            float damage = skillStatistics.Damage * ((100 - effectiveArmor) / 100);

            target.UpadteHealth(damage);
            if (skillStatistics.Heal > 0)
            {
                result += $" {target.name} died.";

            }
            else
            {
                float health = (target.hp / target.maxHp) * 100;
                result += $" {target.name} is at {health} % health.";
            }
            return result;
        }
    }
}
