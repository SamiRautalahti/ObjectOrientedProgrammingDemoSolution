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
            Console.WriteLine("Ajoneuvo-harjoitus!");
            Vehicle vehicleA = new Vehicle("Toyota", "Corolla", 2000, 5000);
            Vehicle vehicleB = new Vehicle("Toyota", "Carina II", 1995, 3000);
            Vehicle vehicleC = new Vehicle("Toyota", "Supra Hyper", 1955, 30000);
            Vehicle vehicleD = new Vehicle("Toyota", "Yaris", 2009, 15000);
            Car carA = new Car("Toyota", "Corolla", 2000, 5000, "2.4L", "Sedan", 4);
            Car carB = new Car("Toyota", "Top Cruiser", 2004, 50000, "3.5L", "Sedan", 4);
            Car carC = new Car("Toyota", "Overcharger", 2019, 48000, "2.8L", "Sedan", 4);


            vehicleA.PrintInfo();
            vehicleB.PrintInfo();
            vehicleC.PrintInfo();
            Console.WriteLine(carA.ToString());
            Console.WriteLine(carB.ToString());
            Console.WriteLine(carC.ToString());

            if (carA.Equals(carB))
            {
                Console.WriteLine($"Autot ovat saman merkkisiä ja mallisia");
            }
            else
            {
                Console.WriteLine($"Autot eivät ole saman merkkisiä ja mallisia");
            }

            Console.ReadLine();

        }
    }
}
