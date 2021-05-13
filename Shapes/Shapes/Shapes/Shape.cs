
using System.Collections.Generic;


namespace Shapes.Shapes
{
    public abstract class Shape
    {
        protected Shape()
        {
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract string WhoAmI();



    }
}
