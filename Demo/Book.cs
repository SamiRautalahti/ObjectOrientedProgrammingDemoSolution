using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string name;
        public string author;
        public string publisher;
        private double price;
        public string isbn;
        private static string theme = "Perus";

        private const int MaxLength = 13;
        private const string Prefix = "978";

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
                if (this.price > 30)
                {
                    this.price = this.price * 0.90;
                }
            }
        }

        public Book()
        {
            this.name = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this.Price = 0;
            this.isbn = string.Empty;
        }
        public Book(string name, string author, string publisher, double price, string isbn, string theme)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            this.isbn = isbn;
        }

        public void GetBookDetails(string tunnus)
        {
            if (this.isbn == tunnus)
            {
                Console.WriteLine($"{this.name}, {this.author}, {this.publisher}, {this.price:F2} EUR, {this.isbn}, {theme}");
            }
            else
            {
                Console.WriteLine("Tunnukset eivät täsmää");
            }
        }
        public static void ChangeTheme()
        {
            Console.WriteLine("Vaihda uusi teema:");
            theme = Console.ReadLine();
            Console.WriteLine(theme);
        }
        /*public static void ChangeTheme(string newTheme)
        {
            theme = newTheme;
        }*/
    }
}

