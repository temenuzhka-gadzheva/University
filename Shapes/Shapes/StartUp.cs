using Shapes.Circles;
using Shapes.Quadrilaterals;
using Shapes.Shapes;
using Shapes.Triangles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{

    public class StartUp
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(10),
                new IsoscelesTriangle(10, (Math.PI / 180) * 120),
                new Circle(15),
               new IsoscelesTriangle(10, (Math.PI / 180) * 35),
                new Rhombus(20,10),
                new Rectangle(20,30),
                new Rectangle(5,10),
                new Rectangle(6,9),
                new Square(20)
            };
            ShowGroupedAreaAndPerimeter(shapes);




        }

        public static void ShowGroupedAreaAndPerimeter(List<Shape> shapes)
        {
            var parallelogramAreas = 0.0;
            var parallelogramPerimeter = 0.0;
            var rhombusAreas = 0.0;
            var rhombusPerimeter = 0.0;
            var rectangleAreas = 0.0;
            var rectanglePerimeter = 0.0;
            var squareAreas = 0.0;
            var squarePerimeter = 0.0;
            var circleAreas = 0.0;
            var circlePerimeter = 0.0;
            var isoscelesTriangleAreas = 0.0;
            var isoscelesTrianglePerimeter = 0.0;

            StringBuilder sb = new StringBuilder();

            foreach (var shape in shapes)
            {
                if (shape.GetType().Name == "Parallelogram")
                {
                    parallelogramAreas += shape.GetArea();
                    parallelogramPerimeter += shape.GetPerimeter();
                }
                if (shape.GetType().Name == "Rhombus")
                {
                    rhombusAreas += shape.GetArea();
                    rhombusPerimeter += shape.GetPerimeter();
                }
                if (shape.GetType().Name == "Rectangle")
                {
                    rectangleAreas += shape.GetArea();
                    rectanglePerimeter += shape.GetPerimeter();
                }
                if (shape.GetType().Name == "Square")
                {
                    squareAreas += shape.GetArea();
                    squarePerimeter += shape.GetPerimeter();

                }
                if (shape.GetType().Name == "Circle")
                {
                    circleAreas += shape.GetArea();
                    circlePerimeter += shape.GetPerimeter();
                }
                if (shape.GetType().Name == "IsoscelesTriangle")
                {
                    isoscelesTriangleAreas += shape.GetArea();
                    isoscelesTrianglePerimeter += shape.GetPerimeter();
                }
            }
            sb.AppendLine("Shape Parallelogram:");
            sb.AppendLine($"  total area: {parallelogramAreas}");
            sb.AppendLine($"  total perimeters: {parallelogramPerimeter}");
            sb.AppendLine("Shape Rhombus:");
            sb.AppendLine($"  total area: {rhombusAreas}");
            sb.AppendLine($"  total perimeters: {rhombusPerimeter}");
            sb.AppendLine("Shape Rectangle:");
            sb.AppendLine($"  total area: {rectangleAreas}");
            sb.AppendLine($"  total perimeters: {rectanglePerimeter}");
            sb.AppendLine("Shape Square:");
            sb.AppendLine($"  total area: {squareAreas}");
            sb.AppendLine($"  total perimeters: {squarePerimeter}");
            sb.AppendLine("Shape Circle:");
            sb.AppendLine($"  total area: {circleAreas}");
            sb.AppendLine($"  total perimeters: {circlePerimeter}");
            sb.AppendLine("Shape IsoscelesTriangle:");
            sb.AppendLine($"  total area: {isoscelesTriangleAreas}");
            sb.AppendLine($"  total perimeters: {isoscelesTrianglePerimeter}");
            Console.WriteLine(sb.ToString().Trim());
        }
    }

}

