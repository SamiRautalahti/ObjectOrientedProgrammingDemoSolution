using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            InsuranceManager im = new InsuranceManager();
            Console.WriteLine("vakuutukset:");
            im.AddInsurance("koira", "Rolle", false);
            im.AddInsurance("koira", "Tessu", true);
            im.AddInsurance("kissa", "Monni", true);
            im.AddInsurance("koira", "Pluto", false);
            im.AddInsurance("lintu", "Tipi", false);
            im.PrintInsurances();
            Console.WriteLine("---");
            im.FindInsurances("koira", false);
            Console.ReadLine();
        }
    }
}
