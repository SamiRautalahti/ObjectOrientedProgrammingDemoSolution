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
            Console.WriteLine("*******************\n");
            /*Vehicle vehicleA = new Vehicle("Ford", "Mustang", 1967, 36500);
            Vehicle vehicleB = new Vehicle("Ford", "Mustang", 1969, 39400);
            Vehicle vehicleC = new Vehicle("Dodge", "Charger", 1971, 52500);
            Vehicle vehicleD = new Vehicle("Dodge", "Challenger", 1970, 68000);*/

            Car carA = new Car("Toyota", "Corolla", 2009, 6500, "1.4L", "Hatchback", 4);
            Car carB = new Car("Toyota", "Celica", 2012, 7500, "1.6L", "Sedan", 4);
            Car carC = new Car("Toyota", "Carina II", 1990, 3000, "1.6L", "Sedan", 4);

            Truck truck1 = new Truck("Toyota", "Carina II", 1990, 3000, "1.6L", "Sedan", 4);

            //vehicleA.PrintInfo();
            Console.WriteLine("*******************\n");
            //vehicleB.PrintInfo();
            Console.WriteLine("*******************\n");
            //vehicleC.PrintInfo();
            Console.WriteLine("*******************\n");
            Console.WriteLine(carA.ToString());
            Console.WriteLine("*******************\n");
            Console.WriteLine(carB.ToString());
            Console.WriteLine("*******************\n");
            Console.WriteLine(carC.ToString());
            Console.WriteLine("*******************\n");

            if (carA.Equals(carB) == true)
            {
                Console.WriteLine($"The cars are same brand and model");
            }
            else
            {
                Console.WriteLine($"The cars aren't the same brand or model at all");
            }

            Console.ReadLine();

        }
    }
}
