using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            List <Ship> ships=new List <Ship> ();

            string shipNum ="";
            Angle lattitude = new Angle();
            Angle longitude = new Angle();
            Ship ship = new Ship(shipNum, lattitude, longitude);
            Start:
            int option = Menu();
            if(option == 1)
            {
                Console.Write("Enter Ship Number:");
                ship.shipNum = Console.ReadLine();
                Console.WriteLine("Enter Ship Latitude:");
                Console.Write("Enter Latitude’s Degree:");
                ship.lattitude.degree = int.Parse(Console.ReadLine());
                Console.Write("Enter Latitude’s Minute:");
                ship.lattitude.min= float.Parse(Console.ReadLine());
                Console.Write("Enter Latitude’s Direction:");
                ship.lattitude.direction = char.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter Ship Longitude:");
                Console.Write("Enter Longitude’s Degree:");
                ship.longitude.degree = int.Parse(Console.ReadLine());
                Console.Write("Enter Longitude’s Minute:");
                ship.longitude.min = float.Parse(Console.ReadLine());
                Console.Write("Enter Longitudw’s Direction:");
                ship.longitude.direction = char.Parse(Console.ReadLine());
                ships.Add(ship);
                
               goto Start;
                
            }
            if (option == 2) 
            {
                ship.PrintLocation(ships);
                int op=int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    goto Start;
                }
            }
            if (option == 3)
            {
                ship.PrintSerialNum(ships);

                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    goto Start;
                }
            }
            if (option == 4)
            {
                ship.ChangePosition(ships);
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    goto Start;
                }
            }
            
        }
        static int Menu()
        {
            int op = 0;
            Console.Clear();
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship Position");
            Console.WriteLine("3.View Ship Serial Number");
            Console.WriteLine("4.Change Ship Position");
            Console.WriteLine("5.Exit");
            Console.Write("Enter option:");
            op=int.Parse(Console.ReadLine());
            return op;

        }
    }
}
