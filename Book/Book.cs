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
        private string author;
        public string publisher;
        private double price;
        private string isbn;
        public static string theme = "Perus";

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

        public string Isbn
        {
            get { return isbn; }
            set
            {
                if (value.Length == MaxLength && value.Substring(0, 3) == Prefix)
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("ISBN ei kelpaa");
                }
            }
        }

        public string Author { 
            get => author; 
        }

        public Book()
        {
            this.name = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this.Price = 0;
            this.Isbn = string.Empty;
        }
        public Book(string name, string author, string publisher, double price, string isbn, string theme)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            this.Isbn = isbn;
        }

        public void GetBookDetails(string tunnus)
        {
            if (this.Isbn == tunnus)
            {
                Console.WriteLine($"{this.name}, {this.Author}, {this.publisher}, {this.price:F2} EUR, {this.Isbn}, {theme}");
            }
            /*else
            {
                Console.WriteLine("Tunnukset eivät täsmää");
            }*/
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

