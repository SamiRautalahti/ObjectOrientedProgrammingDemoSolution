using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExample
{
    interface ICustomer
    {
        Customer GetCustomer(string name);

        double GetBonus();
    }
}
