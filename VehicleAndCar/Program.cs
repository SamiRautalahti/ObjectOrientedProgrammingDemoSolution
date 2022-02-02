using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAndCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle, car and truck Exercise!");
            Console.WriteLine("***********************************************************************************************\n");

            //Vehicles are here (not available as vehicle is abstract class now):
            /*Vehicle vehicleA = new Vehicle("Ford", "Mustang", 1967, 36500);
            Vehicle vehicleB = new Vehicle("Ford", "Mustang", 1969, 39400);
            Vehicle vehicleC = new Vehicle("Dodge", "Charger", 1971, 52500);
            Vehicle vehicleD = new Vehicle("Dodge", "Challenger", 1970, 68000);*/

            //Cars are here:
            Car carA = new Car("Toyota", "Corolla", 2009, 6500, "1.4L", "Hatchback", 4);
            Car carB = new Car("Toyota", "Celica", 2012, 7500, "1.6L", "Sedan", 4);
            Car carC = new Car("Toyota", "Carina II", 1990, 3000, "1.6L", "Sedan", 4);

            //Trucks are here:
            Truck truck1 = new Truck("Mercedes-Benz", "Actros", 2013, 25000, "12.9L", "Truck", 2, 27000, 5000);
            Truck truck2 = new Truck("Volvo", "FM7", 1999, 16740, "7.0L", "Truck", 2, 18000, 3000);
            Truck truck3 = new Truck("Scania", "R560", 2008, 19840, "16L", "Truck", 2, 14000, 2000);


            //vehicleA.PrintInfo();
            Console.WriteLine("***********************************************************************************************\n");
            //vehicleB.PrintInfo();
            Console.WriteLine("***********************************************************************************************\n");
            //vehicleC.PrintInfo();
            Console.WriteLine("***********************************************************************************************\n");
            Console.WriteLine(carA.ToString());
            Console.WriteLine("***********************************************************************************************\n");
            Console.WriteLine(carB.ToString());
            Console.WriteLine("***********************************************************************************************\n");
            Console.WriteLine(carC.ToString());
            Console.WriteLine("***********************************************************************************************\n");

            //Object.Equals Method:
            if (carA.Equals(carB) == true)
            {
                Console.WriteLine($"The cars are same brand and model");
            }
            else
            {
                Console.WriteLine($"The cars aren't the same brand or model at all");
            }

            //Truck printinfo:
            Console.WriteLine("***********************************************************************************************\n");
            truck1.PrintInfo();
            Console.WriteLine("***********************************************************************************************\n");
            truck2.PrintInfo();
            Console.WriteLine("***********************************************************************************************\n");
            truck3.PrintInfo();
            Console.WriteLine("***********************************************************************************************\n");

            Console.ReadLine();

        }
    }
}
