using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokka_Storage
{
    class Place
    {
        protected string name;

        public Place(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
