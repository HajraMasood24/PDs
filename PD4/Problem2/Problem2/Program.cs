using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string name = "";
            int health, energy, armor;

            Player player = new Player(name, health, energy, armor);
            List<Player> p = new List<Player>();
        List<Stats> s = new List<Stats>();
        bool exit = false;
            while (!exit) { 
                Console.WriteLine("\n--- Magical Duel Menu ---");
                Console.WriteLine("1. Add Player");
                Console.WriteLine("2. Add Skill");
                Console.WriteLine("3. Display Player Info");
                Console.WriteLine("4. Teach Skill to Player");
                Console.WriteLine("5. Attack");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        AddPlayer();
                        break;
                    case "2":
                        AddSkill();
                        break;
                    case "3":
                        DisplayPlayerInfo(p);
                        break;
                    case "4":
                        TeachSkillToPlayer(p);
                        break;
                    case "5":
                        PerformAttack();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

        }
        static void AddPlayer()
        {
            Console.WriteLine("Enter player's name:");
            string name;
            name= Console.ReadLine();
            Console.WriteLine("Enter player's health:");
            int health=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter maximum health:");
            int maxHealth=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter player's energy:");
            int energy=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter player's Maximum energy");
            int maxEnergy=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter armor:");
            int armor=int.Parse(Console.ReadLine());
            p.Add(new Player(name,health,energy,armor));
        }
        static void AddSkill()
        {
            Console.WriteLine("Enter name:");
            string name= Console.ReadLine();
            Console.WriteLine("Enter damage:");
            int damage=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter penetration:");
            int penetration=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter healing power:");
            int heal=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cost:");
            int cost=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter decription:");
            string description=(Console.ReadLine());
            s.Add(new Stats(name, damage, description, penetration, cost, heal));
        }
        static void DisplayPlayerInfo(List<Player> p)
        {
            for (int i = 0; i < p.Count; i++)
            {
                Console.WriteLine("Player's name:" + p[i].name);
                Console.WriteLine("Player's Health:" + p[i].hp);
                Console.WriteLine("Player's Energy:" + p[i].Energy);
                Console.WriteLine("Player's armor:" + p[i].Armor);
            }
        }
        static void TeachSkillToPlayer(List<Player> p)
        {
            Console.WriteLine("Enter player's name:");
            string n = Console.ReadLine();
            Console.WriteLine("Enter skill:");
            string s = Console.ReadLine();

        }
        static void PerformAttack(List<Player> p)
        {

        }
    }
}
