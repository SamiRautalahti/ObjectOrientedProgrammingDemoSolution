using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä book");

            Book book1 = new Book();
            book1.Name = "ABC";

            Book book2 = new Book("Matematiikka 1");

            Console.WriteLine($"{book1.Id}.kirjan nimi on: {book1.Name}");
            Console.WriteLine($"{book2.Id}.kirjan nimi on: {book2.Name}");
            Console.WriteLine($"Book-luokan counter = {Book.counter}");
            Console.ReadLine();
        
        }
    }
}
