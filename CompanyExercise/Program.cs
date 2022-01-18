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
            Console.WriteLine("Company exercise:");

            Console.WriteLine("Example: Company class");
            Company school = new Company();
            school.buildingYear = 1990;
            school.address = "Skinnarilankatu 36, 53850 Lappeenranta";
            school.PrintInfo();

            Company office = new Company("Marssitie 50, 53810 Lappeenranta", 2000);
            office.PrintInfo();

            // create object using copy consructor
            Company postOffice = new Company(office);
            postOffice.PrintInfo();

        }
    }
}
