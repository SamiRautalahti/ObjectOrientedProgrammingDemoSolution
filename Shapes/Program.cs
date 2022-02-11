using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> allShapes = new List<Shape>
            {
                    new Circle("red", 6),
                    new Circle("blue", 2),
                    new Triangle("blue", 2, 4),
                    new Triangle("black", 4, 4),
                    new Rectangle("yellow", 6, 8),
                    new Rectangle("pink", 2, 2)
            };

            foreach (Shape s in allShapes)
            {
                Console.WriteLine($"{s.GetInfo()}");
                Console.WriteLine($"Pinta-ala on {s.GetArea():F2}");
            }
            allShapes.Sort();

            Console.WriteLine("____________________________________________");
            foreach (Shape s in allShapes)
            {
                Console.WriteLine($"{s.GetInfo()}");
                Console.WriteLine($"Pinta-ala on {s.GetArea():F2}");
            }


            /*
            foreach (Shape s in allShapes)
            {

                if (s.GetType() == typeof(Circle))
                {
                    Console.WriteLine($"{ s.GetInfo()}");
                }

            }

            foreach (Shape s in allShapes)
            {

                if (s.GetType() == typeof(Triangle))
                {
                    Console.WriteLine($"{ s.GetInfo()}");
                }

            }
            */



            Console.ReadLine();
        }
    }
}
