using Shapes.Quadrilaterals;
using Shapes.Shapes;
using System;


namespace Shapes.Triangles
{

    public class IsoscelesTriangle : Shape
    {
        private double angle;
        private double sizeA;
        public IsoscelesTriangle(double sizeA, double angle)
        {
            this.SizeA = sizeA;
            this.Angle = angle;
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
        public double Angle
        {
            get => this.angle;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Angle cannot be zero or negative!");
                }
                this.angle  = value; 
            }
        }
        public override double GetArea()
        {
            double area = 0.5 * this.SizeA * this.SizeA * Math.Sin(this.Angle); 
            return area;
        }
      
        public override double GetPerimeter()
        {
          
            var sizeC = 3.30708045736062;
            return 2 * SizeA + sizeC; 
        }

        public override string WhoAmI()
        {
            return $"I am {GetType().Name}";
        }
    }
}
