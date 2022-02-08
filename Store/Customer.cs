using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExample
{
    class Customer : ICustomer
    {
        private string name;
        private double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public double GetBonus()
        {
            if (this.purchases <= 1000)
                
            {
                return this.purchases * 0.02;
            }
            if (this.purchases > 1000 && this.purchases <= 2000)
            {
                return this.purchases * 0.03;
            }
            else return this.purchases * 0.05;

                
        }

        public Customer GetCustomer(string name)
        {
            if (name.ToLower() == this.name.ToLower())
            //if (name.ToLower() .Equals(this.name.ToLower()))
            {
                return this;
            }


            return null;
        }

        public override string ToString()
        {
            return $"{this.name}, Ostokset: {this.purchases}, Bonukset: {this.GetBonus()}";
        }
    }
}
