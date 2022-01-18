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
            company1.title = "Rare Records Collector Oy";
            company1.address = "Paraistentie 5 B 4, 53650 Lappeenranta";
            company1.phone = "0458766327";
            company1.outcome = 400000;
            company1.expense = 5000;
            company1.PrintInfo();
            company1.CalculateProfit();

            Company company2 = new Company();
            Console.WriteLine("\n\nKuljetusliike");
            company2.title = "Mikon pikakuljetus Oy";
            company2.address = "Porslankarintie 7, 58760 Lappeenranta";
            company2.phone = "0448456328";
            company2.outcome = 200;
            company2.expense = 400;
            company2.PrintInfo();
            company2.CalculateProfit();

            Company company3 = new Company(company1);
            Console.WriteLine("\n\n");
            Console.WriteLine("Tiedot kopioitu.");
            company3.PrintInfo();
            Console.WriteLine("\n\n");


            Company company4 = new Company("Taxellin veronkierto Oy", "Vilppikuja 68, 54100 Joutseno", "0444475723", 100000, 20000);
            company4.PrintInfo();
            company4.CalculateProfit();
            Console.WriteLine("\n\n");

            Company company5 = new Company("Teron ruokapalvelu Oy", "Lounaskatu 8, 55800 Imatra", "0455587834", 1000, 20000);
            company5.PrintInfo();
            company5.CalculateProfit();
            Console.WriteLine("\n\n");
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
