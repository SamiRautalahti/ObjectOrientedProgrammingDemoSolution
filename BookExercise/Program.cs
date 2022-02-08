using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Book exercise!");
            /*Book book1 = new Book();
            book1.title = "Matematiikka 1";
            book1.SetId("A2345");
            Console.WriteLine("Ensimmäinen kirja: " + book1.title);

            Book book2 = new Book("Aapinen");
            book2.price = 10.00;
            Console.WriteLine("Toinen kirja: " + book2.title);

            Book book3 = new Book ("Historia 4", "Salonen Matti", "12345", 22.50);
            Console.WriteLine(book3.GetBookInformation());

            book3.CompareBook(book2);*/

            List<Book> books = new List<Book>();
            books.Add(new Book("Puistokemia 3", "Peltonen Pertti", "45100", 45.00));
            books.Add(new Book("Hapot ja emäkset - jatkokurssi 2", "Hakavuo Irmeli", "25200", 310.00));
            books.Add(new Book("Pommit ja pamaukset", "Junttila Erkki", "55002", 48.00));
            books.Add(new Book("Lähimaailman muuttuneet tieteet 1", "Jurvola Sirkka", "21005", 22.00));


            foreach (Book b in books)
            {
                Console.WriteLine(b.title + " , " + b.price);
            }

            books.Sort();

            Console.WriteLine("Järjestetty hinnan mukaan");

            foreach (Book b in books)
            {
                Console.WriteLine(b.title + " , " + b.price);
                //Console.WriteLine(b.GetBookInformation());
            }

            



            Console.ReadLine();
        }
    }
}
