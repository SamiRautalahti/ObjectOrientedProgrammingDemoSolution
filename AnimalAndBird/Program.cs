using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAndBird
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird("Keijo", 5, "BIRD", 2));
            birds.Add(new Bird("Kaija", 1, "BIRD", 2));
            birds.Add(new Bird("Maija", 10, "BIRD", 2));
            birds.Add(new Bird("Raija", 3, "BIRD", 2));

            foreach (Bird b in birds)
            {
                Console.WriteLine(b.ToString());
            }

            birds.Sort();

            Console.WriteLine("Järejestetty lista");
            foreach (Bird b in birds)
            {
                Console.WriteLine(b.ToString());
            }



            /*Console.WriteLine("Periytyminen!");
            Bird birdA = new Bird("Keijo", 11, "BIRD", 2);
            Bird birdB = new Bird("Kaija", 10, "BIRD", 2);
            //birdB.PrintInfo();

            Console.WriteLine(birdB.ToString());

            if (birdA.Equals(birdB))
            {
                Console.WriteLine($"{birdA.GetName()} ja {birdB.GetName()} ovat samoja");
            }
            else
            {
                Console.WriteLine($"{birdA.GetName()} ja {birdB.GetName()} eivät ole samoja");
            }

            Parrot parrotA = new Parrot("Keijo", 20, "BIRD", 2, "Ara-papukaija");
            Console.WriteLine(parrotA.ToString());*/


            Console.ReadLine();

        }
    }
}
