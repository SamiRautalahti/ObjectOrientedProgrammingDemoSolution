using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExercise
{
    class Book : IComparable<Book>
    {
        public string title;
        public string author;
        public string id;
        public double price;

        // empty constructor
        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.id = string.Empty;
            this.price = 0;
        }

        // constructor
        public Book(string title)
        {
            this.title = title;
            this.author = string.Empty;
            this.id = string.Empty;
            this.price = 0;
        }

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            SetId(id);
            this.price = price;
        }

        public string GetBookInformation()
        {
            //return this.author + ", " + this.title +", " + this.id +", "+ this.price;
            return $"{this.author}, {this.title}, {this.id}, {this.price:F2} EUR";
        }

        public void SetId(string idValue)
        {
            //tarkistaa tässä onko id:n pituus viisi merkkiä
            if (idValue.Length == 5)
            {
                this.id = idValue;
            }
            else
            {
                this.id = "not valid";
            }
            
        }
        public void CompareBook(Book book)
        {
         
            //verrata parametrinä olevan olion kappalehintaa kutsuttavan kappalehintaan
            // palauta tieto siitä, kumpi kirja on kalliimpi.
            if (this.price > book.price)
            {
                Console.WriteLine($"{this.title} on kalliimpi kuin {book.title}");
            }
            else if (this.price < book.price)
            {
                Console.WriteLine($"{book.title} on kalliimpi kuin {this.title}");
            }
            else
            {
                Console.WriteLine($"{this.title} on samanhintainen kuin {book.title}");
            }
            Console.WriteLine($"kutsuva olio {this.title}");
            Console.WriteLine($"parametrina tuleva olio {book.title}");
        }

        public int CompareTo(Book other)
        {
            return this.price.CompareTo(other.price);
            //throw new NotImplementedException();
        }
    }
}
