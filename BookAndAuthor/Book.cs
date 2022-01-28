using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAndAuthor
{
    class Book
    {
        private const int MaxLength = 25;
        private string author;
        private string name;
        private int id;
        public static int counter = 1;

        public Book()
        {
            this.Name = string.Empty;
            this.Id = counter;
            counter++;
        }

        public Book(string name)
        {
            this.Name = name;
            this.Id = counter;
            counter++;
        }

        public string Name {
            get
            {
                return name;
            }

            set
            {
                if (value.Length > MaxLength)
                {
                    Console.WriteLine("nimi on liian pitkä");
                }
                else
                {
                    name = value.ToLower();
                }
            }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Author { 
            get => author; 
            //set => author = value; 
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Author}";
        }
    }
}
