using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämän harjoituksen nimi on: Luokka Book!");
            Console.WriteLine("****************************************\n");

            /*Book book1 = new Book();
            book1.name = "Lyhyt matematiikka 2";
            book1.author = ("Hätynen Martti");
            book1.publisher = ("Tammi");
            book1.Price = 25.85;
            book1.Isbn = "9786545234123";
            Console.WriteLine("Ensimmäinen kirja = " + book1.name);

            Console.WriteLine("****************************************\n");
            Book book2 = new Book();
            book2.name = "Fysiikka ja pommit 2";
            book2.author = ("Toljander Tommi");
            book2.publisher = ("Tammi");
            book2.Price = 48.95;
            book2.Isbn = "9784565274233";
            Console.WriteLine("Toinen kirja = " + book2.name);*/

            Console.WriteLine("****************************************\n");
            Book book3 = new Book("Kemian jatkokurssi 3", "Parkkala Esko", "Otava", 56.75, "9784562874219", "Perus");
            Console.WriteLine("Kolmas kirja = " + book3.name);

            Console.WriteLine("****************************************\n");
            Book book4 = new Book("Uskonto osa 2 - perisynnit", "Kittilä Kirsi", "Gummerus", 66.66, "9784763274232", "Perus");
            Console.WriteLine("Neljäs kirja = " + book4.name);

            Console.WriteLine("****************************************\n");
            Book book5 = new Book("Puistokemian lyhyt oppimäärä", "Juusela Jouko", "Like", 53.95, "9782773272335", "Perus");
            Console.WriteLine("Viides kirja = " + book5.name);

            Console.WriteLine("****************************************\n");
            Book.ChangeTheme();
            Console.WriteLine("****************************************\n");
            //book1.GetBookDetails("9786545234123");
            //book2.GetBookDetails("9784565274233");
            book3.GetBookDetails("9784562874219");
            book4.GetBookDetails("9784763274232");
            book5.GetBookDetails("9782773272335");

            Author author1 = new Author("Kuusela Kauko", "01.11.2000");
            author1.PrintInfo();




            Console.ReadLine();
        }
    }
}
