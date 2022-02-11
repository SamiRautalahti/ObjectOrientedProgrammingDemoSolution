using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {
            this.radius = 0;
        }

        public Circle(string color, double radius) : base(color, "CIRCLE")
        {
            this.radius = radius;
            //this.color = color; vaihtoehto base:lle
            //this.type = "CIRCLE"; vaihtoehto base:lle
        }

        public override double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public override string GetInfo()
        {
            return $"Radius: {this.radius}, Type: {base.type}, Color: {this.color}";
        }
    }
}
