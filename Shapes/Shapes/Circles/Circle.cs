using Shapes.Shapes;
using System;


namespace Shapes.Circles
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        private  bool IsValidRadius(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Radius cannot be zero or negative number!");
            }
            return true;
        }
        public double Radius
        {
            get => this.radius;
            private set
            {
                IsValidRadius(value);
                this.radius = value;
            }

        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string WhoAmI()
        {
            return $"I am {GetType().Name}";
        }
    }
}
