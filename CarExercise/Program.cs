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
            Console.WriteLine($"Auton väri on nyt {car1.color}");
            Console.ReadLine();
        }
    }
}
