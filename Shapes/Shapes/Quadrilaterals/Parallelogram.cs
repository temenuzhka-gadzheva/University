

using System;

namespace Shapes.Quadrilaterals
{
    public class Parallelogram : Quadrilateral
    {
       
        private double sizeB;
        private double height;
        protected Parallelogram(double sizeA, double sizeB, double height): base(sizeA)
        {
            this.SizeB = sizeB;
            this.Height = height;
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
        public double Height
        {
            get => this.height;
            private set
            {
                IsSizeValid(value);
                this.height = value;
            }
        }
        public override double GetArea()
        {
            return SizeA * Height;
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
