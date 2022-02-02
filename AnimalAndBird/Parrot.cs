using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAndBird
{
    class Parrot : Bird
    {
        protected string family; //laji

        public Parrot()
        {
        }

        public Parrot (string name, 
                        int age, 
                        string birdClass, 
                        int legs,
                        string family): base(name, age, birdClass, legs)
        {
            this.family = family;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.family}";
        }
    }
}
