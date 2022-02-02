using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAndBird
{
    // Kantaluokka
    abstract class Animal
    {
        protected string name;
        protected int age;

        // konstruktori
        public Animal()
        {
            Console.WriteLine("Animal-kantaluokan muodostin");
            this.age = 0;
            this.name = string.Empty;
        }

        // konstruktori
        public Animal(string name, int age)
        {
            Console.WriteLine("Animal-kantaluojan muodostin");
            this.name = name;
            this.age = age;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Nimi: {this.name}, Ikä: {this.age}");
        }

        public override string ToString()
        {
            return $"{this.name}, {this.age}";
        }

        public string GetName()
        {
            return this.name;
        }

        abstract public void Speak();

    }
}
