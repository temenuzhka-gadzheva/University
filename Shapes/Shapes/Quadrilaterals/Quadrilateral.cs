using Shapes.Shapes;
using System;

namespace Shapes.Quadrilaterals
{
    public abstract class Quadrilateral : Shape
    {
        private double sizeA;
        protected Quadrilateral(double sizeA)
        {
            this.SizeA = sizeA;
        }
        public bool IsSizeValid(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Size and height cannot be zero or negative number!");
            }
            return true;
        }
        public double SizeA
        {
            get => this.sizeA;
            private set
            {
                IsSizeValid(value);
                this.sizeA = value;
            }
        }

    }
}
