using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Quadrilaterals
{
    public class Rectangle : Quadrilateral
    {
        private double sizeB;
        public Rectangle(double sizeA, double sizeB) : base(sizeA)
        {
            this.SizeB = sizeB;
        }
        public double SizeB
        {
            get => this.sizeB;
            private set
            {
                IsSizeValid(value);
                this.sizeB = value;
            }
        }
        public override double GetArea()
        {
            return SizeA * SizeB;
        }

        public override double GetPerimeter()
        {
            return 2 * (SizeA + SizeB);
        }

        public override string WhoAmI()
        {
            return $"I am {GetType().Name}";
        }
    }
}
