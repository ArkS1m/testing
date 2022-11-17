using System;
using AreaCalculator;
using AreaCalculator.Models.GeometricObjects;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            IGeometricObject circleA = new Circle(5);
            IGeometricObject triangleA = new Triangle(3, 4, 5);
            IGeometricObject rectangleA = new Rectangle(3, 4);
            Console.WriteLine(circleA.CalculateArea());
            Console.WriteLine(triangleA.CalculateArea());
            Console.WriteLine(rectangleA.CalculateArea());
            Console.ReadLine();
        }
    }
}
