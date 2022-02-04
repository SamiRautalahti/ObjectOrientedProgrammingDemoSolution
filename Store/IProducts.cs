using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExample
{
    interface IProducts
    {
        void AddProduct(Product product);

        void PrintProducts();
    }
}
