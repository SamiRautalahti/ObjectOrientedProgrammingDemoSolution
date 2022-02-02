using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    class Employee
    {
        public string name;
        public string id;
        public string position;
        public double salary;


        public Employee(string name, string id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }
        public void CompareSalary(Employee employee)
        {
            if (this.salary > employee.salary)
            {
                Console.WriteLine($"{this.name}, salary:{this.salary:F2} is bigger than {employee.name}.");
            }
            if (this.salary < employee.salary)
            {
                Console.WriteLine($"{employee.name}, salary:{employee.salary:F2} is bigger than {this.name}");
            }
            if (this.salary == employee.salary)
            {
                Console.WriteLine($"{this.name} and {employee.name} has equal salary");
            }
        }

        public override string ToString()
        {
            return $"Name: {this.name}, id: {this.id}, Position: {this.position}, Salary:{this.salary:F2}";
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Employee: {this.name}, id: {this.id}, Position: {this.position}, Salary: {this.salary}");
        }
    }
}
  
