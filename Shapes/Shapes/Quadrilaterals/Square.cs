using System;


namespace Shapes.Quadrilaterals
{
    public class Square : Quadrilateral
    {
        public Square(double sizeA) : base(sizeA)
        {
        }

        public override double GetArea()
        {
          
            return Math.Pow(SizeA, 2);
        }

        public override double GetPerimeter()
        {
            return 4 * SizeA;
        }

        public override string WhoAmI()
        {
            return $"I am {GetType().Name}";
        }
    }
}
