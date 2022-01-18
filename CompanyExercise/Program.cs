using System;
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
            Company company1 = new Company();
            Console.WriteLine("\n\nLevykauppa");
            company1.title = "Record Collector Oy";
            company1.address = "Paraistentie 5 B 4, 53650 Lappeenranta";
            company1.phone = "+358458766327";
            company1.outcome = 250000;
            company1.expense = 45000;
            company1.PrintInfo();
            company1.CalculateProfit();

            Company company2 = new Company(company1);
            Console.WriteLine("Tiedot kopioitu.");
            Console.ReadLine();






            /*
            Console.WriteLine("Building exercise!");

            Console.WriteLine("Example: Company class");
            Console.WriteLine("\n\nSchool");
            Building school = new Building();
            school.buildingYear = 1990;
            school.address = "Skinnarilankatu 36, 53850 Lappeenranta";
            school.PrintInfo();
            Console.WriteLine("school-olio: " + school.ToString());
            school.CalculateAge();

            Console.WriteLine("\n\nOffice");
            Building office = new Building("Marssitie 50, 53810 Lappeenranta", 2000);
            office.PrintInfo();
            Console.WriteLine("office-olio: " + office.ToString());
            office.CalculateAge();

            Console.WriteLine("\n\nPostOffice");
            // create object using copy consructor
            Building postOffice = new Building(office);
            postOffice.PrintInfo();
            Console.WriteLine("postOffice-olio: " + postOffice.ToString());
            postOffice.CalculateAge();

            Console.ReadLine();*/
        }
    }
}
