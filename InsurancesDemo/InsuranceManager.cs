using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancesDemo
{
    class InsuranceManager
    {
        List<Insurance> allInsurance = new List<Insurance>
        {

        };

        public void AddInsurance(string animal, string name, bool isNeutered)
        {
            allInsurance.Add(new Insurance(animal, name, isNeutered, GetFee(animal, isNeutered)));
        }

        public InsuranceManager()
        {
        }

        public double GetFee(string animal, bool isNeutered) // metodilla 2 parametria
        {
            if (animal == "koira")
            {
                if (isNeutered == true)
                {
                    return 50;
                }
                else
                {
                    return 80;
                }
            }
            if (animal == "kissa")
            {
                if (isNeutered == true)
                {
                    return 40;
                }
                else
                {
                    return 60;
                }
            }
            else
            {
                return 0;
            }
        }

        public void PrintInsurances()
        {
            Console.WriteLine($"vakuutuksia yhteensä {allInsurance.Count}");
            foreach(Insurance s in allInsurance)
            {
                Console.WriteLine("");
                Console.WriteLine(s.ToString());
            }
        }

        public void FindInsurances(string animal, bool isNeutered) // metodilla 2 parametria
        {
            Console.WriteLine("Löytyi:");

            foreach (Insurance s in allInsurance)
            {
                if (s.GetSpecies() == animal)
                {
                    if (isNeutered == true && s.GetNeuteredInfo() == "leikattu")
                    {
                        Console.WriteLine($"\n{s.GetSpecies()}, {s.GetName()}, vakuutusmaksu {GetFee(animal, isNeutered)} €");
                    }

                    if (isNeutered == false && s.GetNeuteredInfo() == "leikkaamaton")
                    {
                        Console.WriteLine($"\n{s.GetSpecies()}, {s.GetName()}, vakuutusmaksu {GetFee(animal, isNeutered)} €");
                    }
                }
            }
        }
    }
}

