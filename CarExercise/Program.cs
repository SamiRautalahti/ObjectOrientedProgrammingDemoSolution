using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car tehtävä:");
            Car car1 = new Car();
            car1.AskData();
            car1.Accelerate(25);
            Console.WriteLine($"\nNopeutta muutettu {car1.speed}");
            car1.Brake();
            Console.WriteLine($"\nJarrutettu, nopeus on nyt {car1.speed}");
            car1.ShowCarInfo();
            Console.WriteLine("\nCar tehtävä loppui!");
            Console.ReadLine();

        }
    }
}
