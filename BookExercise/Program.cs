﻿using System;
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
            Book book1 = new Book();
            book1.title = "Matematiikka 1";
            book1.SetId("A2345");
            Console.WriteLine("Ensimmäinen kirja: " + book1.title);

            Book book2 = new Book("Aapinen");
            book2.price = 10.00;
            Console.WriteLine("Toinen kirja: " + book2.title);

            Book book3 = new Book ("Historia 4", "Salonen Matti", "12345", 22.50);
            Console.WriteLine(book3.GetBookInformation());

            book3.CompareBook(book2);

            Console.ReadLine();
        }
    }
}
