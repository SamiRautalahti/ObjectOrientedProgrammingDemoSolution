using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokka_Storage
{
    class Program
    {
        static void Main(string[] args)
        {

            Storage storage1 = new Storage("HARAVAT", 100);
            Storage storage2 = new Storage("LAPIOT", 80);
            Storage storage3 = new Storage("SAKSET", 150);


            Console.WriteLine("--Tulostetaan varastojen lähtötilanne");
            Console.WriteLine(storage1.ToString());
            Console.WriteLine(storage2.ToString());
            Console.WriteLine(storage3.ToString());
            Console.WriteLine("\n");
            Console.WriteLine("--Lisätään varastoihin");
            Console.WriteLine(storage1.AddItems(50));
            Console.WriteLine(storage2.AddItems(100));
            Console.WriteLine(storage3.AddItems(-20));
            Console.WriteLine(storage1.ToString());
            Console.WriteLine(storage2.ToString());
            Console.WriteLine(storage3.ToString());
            Console.WriteLine("\n");
            Console.WriteLine("--Poistetaan varastoista");
            Console.WriteLine(storage1.RemoveItems(60));
            Console.WriteLine(storage2.RemoveItems(60));
            Console.WriteLine(storage3.RemoveItems(60));
            Console.WriteLine(storage1.ToString());
            Console.WriteLine(storage2.ToString());
            Console.WriteLine(storage3.ToString());
            Console.WriteLine("\n");
            Console.WriteLine("--Varastojen tyhjennys");

            Console.WriteLine("\n");
            Console.WriteLine("--Tulostetaan varastojen lopputilanne");





            Console.ReadLine();

            

        }
    }
}
