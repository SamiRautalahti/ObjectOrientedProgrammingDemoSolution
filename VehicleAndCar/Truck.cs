﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAndCar
{
    class Truck : Car
    {
        protected double load;
        protected double consumption;


        public Truck(string brand, string model, int modelYear, double price, string engine, string type, int doors, double load, double consumption) : base(brand, model, modelYear, price, engine, type, doors)
        {
            this.load = load;
            this.consumption = consumption;
        }

        public double CalculateConsumption()
        {
            return this.consumption * this.load;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Weight: {this.load}kg | Consumption: {this.consumption}/kg");
        }
    }
}
