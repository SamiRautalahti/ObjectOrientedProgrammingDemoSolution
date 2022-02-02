using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee-exercise:");
            Console.WriteLine("====================================================================================");
            Employee[] employees = new Employee[4];
            employees[0] = new Employee("Bill Mackenzie", "AB112", "Mechanic", 3410.45);
            employees[1] = new Employee("Will Cooper", "AD345", "Sawer", 2115.55);
            employees[2] = new Employee("Alan MacArthur", "AC887", "Musician", 2018.85);
            employees[3] = new Employee("Philip McNulty", "AG422", "Lawyer", 2018.85);

            Console.WriteLine("\n");
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine("Employees printed from array with -ToString method:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{ employee.ToString()}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine("Array printed with PrintEmployeeInfo method:");

            foreach (Employee employee in employees)
            {
                employee.PrintEmployeeInfo();
            }

            Console.WriteLine("\n");
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine("Comparesalary: ");

            for (int i = 0; i < employees.Length; i++)
            {
                if (i < employees.Length - 1)
                {
                    employees[i].CompareSalary(employees[i + 1]);
                }
                else
                {
                    employees[i].CompareSalary(employees[0]);
                }
            }
            Console.WriteLine("====================================================================================");
            Console.ReadLine();
        }
    }
}
