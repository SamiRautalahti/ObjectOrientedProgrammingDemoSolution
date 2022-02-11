using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes 
{
    abstract class Shape : IComparable<Shape> 
    {
        protected string color;
        protected string type;

        public Shape()
        {
            this.color = string.Empty;
            this.type = string.Empty;
        }

        public Shape(string color, string type)
        {
            this.color = color;
            this.type = type;
        }

        abstract public double GetArea();

        abstract public string GetInfo();

        public virtual string GetColor()
        {
            return this.color;
        }

        public int CompareTo(Shape other)
        {
            return this.GetArea().CompareTo(other.GetArea());
        }
    }
}
