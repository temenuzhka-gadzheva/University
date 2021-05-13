

namespace Shapes.Quadrilaterals
{
    public class Rhombus : Quadrilateral
    {
        private double height;
        public Rhombus(double sizeA, double height): base(sizeA)
        {
            this.Height = height;
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
            return 4 * SizeA;
        }

        public override string WhoAmI()
        {
            return $"I am {GetType().Name}";
        }
    }
}
