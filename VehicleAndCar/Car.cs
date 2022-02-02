using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAndCar
{
    class Car : Vehicle
    {
        protected string engine;
        protected string type;
        protected int doors;

        public Car(string brand, string model, int modelYear, double price, string engine, string type, int doors) : base(brand, model, modelYear, price)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        public override bool Equals(object obj)
        {
            return obj is Car car &&
                brand == car.brand &&
                model == car.model &&
                modelYear == car.modelYear &&
                price == car.price &&
                engine == car.engine &&
                type == car.type &&
                doors == car.doors;


        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Brand: {base.brand} | Model: {base.model} | Model year: {base.modelYear} | Price: {base.price} | Engine: {this.engine} | Type: {this.type} | Doors: {this.doors}";
        }
        //Extra method only visible or this class, used to verify typeconversion
        public void TestTypeConversion()
        {
            Console.WriteLine($"\n\nTypeconversion was successfull if you see this text!\n");
        }
    }
}
