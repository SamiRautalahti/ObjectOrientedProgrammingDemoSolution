using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    class Company
    {
        public string address;
        public int buildingYear;

        // empty constructor
        public Company()
        {
            this.address = string.Empty;
            this.buildingYear = 0;
        }

        public Company(string address, int buildingYear)
        {
            this.address = address;
            this.buildingYear = buildingYear;
        }

        // copy constructor
        public Company(Company company)
        {
            this.address = company.address;
            this.buildingYear = company.buildingYear;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Rakennuksen osoite: {this.address}, rakennusvuosi: {this.buildingYear}");
        }

        public override string ToString()
        {
            return $"luokka: {base.ToString()}, osoite: {this.address}, rakennusvuosi: {this.buildingYear}";
        }
    }
}
