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
            Console.WriteLine("Syötä ensimmäisen auton tiedot:");
            Car car1 = new Car();
            car1.AskData();
            car1.Accelerate(25);
            Console.WriteLine($"\nNopeutta muutettu, nopeus on nyt {car1.speed}");
            car1.Brake();
            Console.WriteLine($"\nJarrutettu, nopeus on nyt {car1.speed}");
            Console.WriteLine("Syötä toisen auton tiedot:");
            Car car2 = new Car();
            car2.AskData();
            car2.Accelerate(10);
            Console.WriteLine($"\nNopeutta muutettu, nopeus on nyt {car2.speed}");
            car2.Brake();
            Console.WriteLine($"\nJarrutettu, nopeus on nyt {car2.speed}");
            Console.WriteLine("Auto 1:");
            car1.ShowCarInfo();
            Console.WriteLine("Auto 2:");
            car2.ShowCarInfo();
            Console.WriteLine("\nCar tehtävä loppui!");
            Console.ReadLine();

        }
    }
}
