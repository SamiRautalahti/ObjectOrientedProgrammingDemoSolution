using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    class Company
    {
            public string title;
            public string address;
            public string phone;
            public double outcome;
            public double expense;

        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.outcome = 0;
            this.expense = 0;
        }
        public Company(string title, string address, string phone, double outcome, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }
        public Company(Company previousCompany) // copy constructor
        {
            title = previousCompany.title;
            address = previousCompany.address;
            phone = previousCompany.phone;
            outcome = previousCompany.outcome;
            expense = previousCompany.expense;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Yrityksen nimi: {this.title}, osoite: {this.address}, puhelin: {this.phone}, tulot: {this.outcome}, menot: {this.expense}");
        }
        public void CalculateProfit()
        {
            double profit = ((this.outcome - this.expense) / this.expense * 100);
            if(profit < 100)
            {
                Console.WriteLine($"Voitto:{profit}%. Kehnosti menee");
            }
            if(profit >= 100 && profit < 200 )
            {
                Console.WriteLine($"Voitto:{profit}%. Välttävästi menee");
            }
            if (profit >= 200 && profit < 300)
            {
                Console.WriteLine($"Voitto:{profit}%. Tyydyttävästi menee");
            }
            if (profit >= 300)
            {
                Console.WriteLine($"Voitto:{profit}%. Hyvin menee");
            }
        }



    }
    }

