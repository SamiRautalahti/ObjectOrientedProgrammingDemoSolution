using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Interface/Product Example");
            List<Product> productList = new List<Product>();
            productList.Add(new Product("Teltta", 124.99, 450));
            productList.Add(new Product("Aurinkotuoli", 19.99, 300));
            productList.Add(new Product("Uimapatja", 39.00, 200));

            foreach (Product currentProduct in productList)
            {
                if (currentProduct.GetProduct("Uimapatja") != null)
                {
                    Console.WriteLine("Uimapatja löytyi");
                    Console.WriteLine($"Varaston arvo: {currentProduct.CalculateTotal()}");
                    Console.WriteLine(" -------- ");
                }
                //Console.WriteLine(currentProduct.ToString());
            }

            Console.WriteLine(" --------------- ");
            Console.WriteLine(" ---- STORE ---- ");
            Console.WriteLine(" --------------- ");
            Store myStore = new Store("Retkeilykauppa");
            myStore.AddProduct(new Product("Makuupussi", 89.99, 120));
            myStore.AddProduct(new Product("Teltta", 289.99, 100));
            myStore.AddProduct(new Product("Telttapatja", 189.99, 220));
            myStore.PrintProducts();


            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer("Pertti Laakso", 890));
            customerList.Add(new Customer("Akseli Anttola", 7650));
            customerList.Add(new Customer("Kirka Jövell", 2890));
            customerList.Add(new Customer("Sampo Jaarla", 4890));

            

            foreach (Customer c in customerList)
            {
                Console.WriteLine($"Asiakkaan {c.ToString()} Bonus on {c.GetBonus()}");
            }

            myStore.AddCustomer(customerList.ElementAt(0)); 
            myStore.AddCustomer(customerList.ElementAt(1));
            myStore.AddCustomer(customerList.ElementAt(2));
            myStore.AddCustomer(customerList.ElementAt(3));

            //myStore.AddCustomer(customerList[0]);
            //myStore.AddCustomer(customerList[1]);
            //myStore.AddCustomer(customerList[2]);
            //myStore.AddCustomer(customerList[3]);

            Console.WriteLine(myStore.ToString());
            //myStore.PrintCustomers();


            Console.ReadLine();
        }
    }
}
