using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Ship
    {

        public Angle lattitude = new Angle();
        public string shipNum;
        public Angle longitude = new Angle();
        public Ship(string shipNum, Angle lattitude, Angle longitude)
        {
            this.shipNum = shipNum;
            this.lattitude = lattitude;
            this.longitude = longitude;
        }
        public void PrintLocation(List<Ship> ships)
        {
            Console.Write("Enter Ship SerialNumber to find its position:");
            string serialNumber = Console.ReadLine();
            for (int i = 0; i < ships.Count; i++)
            {
                if (serialNumber == ships[i].shipNum)
                {
                    Console.WriteLine("Ship is at " + ships[i].lattitude.degree + "\u00b0" + ships[i].lattitude.min + "'" + ships[i].lattitude.direction + " and" + ships[i].longitude.degree + "\u00b0" + ships[i].longitude.min + "'" + ships[i].longitude.direction);
                }
            }
            Console.Write("Enter 1 to go back to menu:");
        }
        public void PrintSerialNum(List<Ship> ships)
        {
            Console.WriteLine("Enter Lattitude: ");
            Console.Write("Enter Lattitude Degrees: ");
            int Deg = int.Parse(Console.ReadLine());
            Console.Write("Enter Lattitude Minutes: ");
            float Min = float.Parse(Console.ReadLine());
            Console.Write("Enter Lattitude Direction: ");
            char Dir = char.Parse(Console.ReadLine());
            Console.Write("Enter Longitude: ");
            Console.Write("Enter Longitude Degrees: ");
            int DegLon = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Minutes: ");
            float MinLon = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Direction: ");
            char DirLon = char.Parse(Console.ReadLine());
            for (int i = 0; i < ships.Count; i++)
            {
                if (Deg == ships[i].lattitude.degree && Min == ships[i].lattitude.min && Dir == ships[i].lattitude.direction && DegLon == ships[i].longitude.degree && MinLon == ships[i].longitude.min && DirLon == ships[i].longitude.direction)
                {
                    Console.WriteLine("Ship's serial number is " + ships[i].shipNum);
                }
                else
                {
                    Console.WriteLine("Not Found");
                }


            }
            Console.Write("Enter 1 to go back to menu:");

        }
        public void ChangePosition(List<Ship> ships)
        {
            Console.Write("Enter Ship’s serial number whose position you want to change:");
            string serialNumber = Console.ReadLine();
            
            for (int i = 0; i < ships.Count; i++)
            {
                if (serialNumber == ships[i].shipNum)
                {
                    Console.WriteLine("Enter Ship Latitude:");
                    Console.Write("Enter Latitude’s Degree:");
                    ships[i].lattitude.degree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude’s Minute:");
                    ships[i].lattitude.min = float.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude’s Direction:");
                    ships[i].lattitude.direction = char.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Ship Longitude:");
                    Console.Write("Enter Longitude’s Degree:");
                    ships[i].longitude.degree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude’s Minute:");
                    ships[i].longitude.min = float.Parse(Console.ReadLine());
                    Console.Write("Enter Longitudw’s Direction:");
                    ships[i].longitude.direction = char.Parse(Console.ReadLine());
                }
            }
            Console.Write("Enter 1 to go back to menu:");
        }
    }
}
