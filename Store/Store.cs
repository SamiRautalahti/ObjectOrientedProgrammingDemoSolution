using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExample
{
    class Store : IProducts, ICustomers
    {
        private string name;
        private double turnover;
        private List<Product> allProducts = new List<Product>();
        private List<Customer> allCustomers = new List<Customer>();

        public Store(string name)
        {
            this.name = name;
            this.turnover = 0;
        }

        public Store(string name, double turnover)
        {
            this.name = name;
            this.turnover = turnover;  
        }

        public void AddProduct(Product product)
        {
            this.allProducts.Add(product);
        }

        public void PrintProducts()
        {
            Console.WriteLine(this.allProducts.Count);

            foreach (Product p in allProducts)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public void AddCustomer(Customer customer)
        {
            this.allCustomers.Add(customer);
        }

        public void PrintCustomers()
        {
            Console.WriteLine("Asiakkaiden lukumäärä: " + this.allCustomers.Count);

            foreach (Customer p in allCustomers)
            {
                Console.WriteLine(p.ToString());
            }
        }
        
        public override string ToString()
        {
            return $"Kaupan nimi: {this.name}, Liikevaihto: {this.turnover}, Asiakkaita: {this.allCustomers.Count}, Tuotteiden määrä: {this.allProducts.Count}";
        }
    }
}
