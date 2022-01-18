﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company exercise!");

            Console.WriteLine("Example: Company class");
            Console.WriteLine("\n\nSchool");
            Company school = new Company();
            school.buildingYear = 1990;
            school.address = "Skinnarilankatu 36, 53850 Lappeenranta";
            school.PrintInfo();
            Console.WriteLine("school-olio: " + school.ToString());
            school.CalculateAge();

            Console.WriteLine("\n\nOffice");
            Company office = new Company("Marssitie 50, 53810 Lappeenranta", 2000);
            office.PrintInfo();
            Console.WriteLine("office-olio: " + office.ToString());
            office.CalculateAge();

            Console.WriteLine("\n\nPostOffice");
            // create object using copy consructor
            Company postOffice = new Company(office);
            postOffice.PrintInfo();
            Console.WriteLine("postOffice-olio: " + postOffice.ToString());
            postOffice.CalculateAge();

            Console.ReadLine();
        }
    }
}