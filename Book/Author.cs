using System;
using Literature;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literature
{
    class Author
    {
        public string name;
        public string birthday;
        public Book book;

        public Author()
        {
            this.name = string.Empty;
            this.birthday = string.Empty;
            this.book = null;
        }

        public Author(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
            this.book = null;
        }

        public Author(string name, string birthday, Book book)
        {
            this.name = name;
            this.birthday = birthday;
            this.book = book;
        }

        internal Book Book
        {
            get { return book; }
            set
            {
                //Console.WriteLine("value-muuttujan author: " + value.Author);
                //Console.WriteLine("this.Author: " + this.name);

                if (value != null && value.Author == this.name)
                //if (this.name.Equals(value.Author)
                {
                    this.book = value;
                }
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Kirjailijan nimi: {this.name}");
            Console.WriteLine($"Kirjailijan syntymäaika: {this.birthday}");

            if (this.book != null)
            {
                Console.WriteLine($"Kirjan nimi: {this.book.ToString()}");
            }
            else
            {
                Console.WriteLine($"Kirjailijalla ei ole teosta");
            }
        }
    }
}

