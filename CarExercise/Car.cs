using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExercise
{
    class Car
    {
        public string color;

        public Car()
        {
            this.color = string.Empty;
            //AskData();
        }
        
        public void AskData()
        {
            Console.Write("Auton väri? ");
            this.color = Console.ReadLine();
        }
    }
}
