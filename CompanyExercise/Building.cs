using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    class Building
    {
        public string address;
        public int buildingYear;

        // empty constructor
        public Building()
        {
            this.address = string.Empty;
            this.buildingYear = 0;
        }

        public Building(string address, int buildingYear)
        {
            this.address = address;
            this.buildingYear = buildingYear;
        }

        // copy constructor
        public Building(Building building)
        {
            this.address = building.address;
            this.buildingYear = building.buildingYear;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Rakennuksen osoite: {this.address}, rakennusvuosi: {this.buildingYear}");
        }

        public override string ToString()
        {
            return $"luokka: {base.ToString()}, osoite: {this.address}, rakennusvuosi: {this.buildingYear}";
        }
        public void CalculateAge()
        {
            int age = 2022 - this.buildingYear;
            Console.WriteLine($"Rakennuksen ikä: {age}");
        }
    }
}
