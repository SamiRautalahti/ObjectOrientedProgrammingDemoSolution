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

            //double area = Math.Round(Math.PI * 0.25 * 0.25, 2);

            Book book1 = new Book("Astrid Lindgren");
            book1.Name = "Peppi Pitkätossu";


            //Book book2 = new Book("Matematiikka 1");

            //Console.WriteLine($"{book1.Id}.kirjan nimi on: {book1.Name}");
            //Console.WriteLine($"{book2.Id}.kirjan nimi on: {book2.Name}");
            Console.WriteLine($"Book-luokan counter = {Book.counter}");
            

            Author author1 = new Author("Astrid Lindgren", "14.11.1907", book1);
            author1.PrintInfo();
            Console.ReadLine();

        }
    }
}
