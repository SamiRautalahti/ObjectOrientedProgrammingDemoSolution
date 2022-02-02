using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAndCar
{
    class Vehicle
    {
        protected string brand;
        protected string model;
        protected int modelYear;
        protected double price;

        public Vehicle(string brand, string model, int modelYear, double price)
        {
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Merkki: {this.brand}, Tyyppi: {this.model}, Vuosimalli: {this.modelYear}, Hinta: {this.price} EUR.");
        }

    }


}
