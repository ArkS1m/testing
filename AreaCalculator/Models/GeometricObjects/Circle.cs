using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Models.GeometricObjects
{
    public class Circle : IGeometricObject
    {
        double radius { get; }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
