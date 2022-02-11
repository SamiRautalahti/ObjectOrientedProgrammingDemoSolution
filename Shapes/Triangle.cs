using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        private double length;
        private double width;

        public Triangle()
        {
            this.length = 0;
            this.width = 0;
        }

        public Triangle(string color, double length, double width) : base(color, "TRIANGLE")
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            return this.length * this.width /2;
        }

        public override string GetInfo()
        {
            return $"Color: {base.color}, Type: {base.type}, Length: {this.length}, Width: {this.width}";
        }
    }

}
