using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Models.GeometricObjects
{
    public class Rectangle : IGeometricObject
    {
        public double rectangleSideA { get; set; }
        public double rectangleSideB { get; set; }
        public Rectangle(double rectangleSideA, double rectangleSideB)
        {
            this.rectangleSideA = rectangleSideA;
            this.rectangleSideB = rectangleSideB;
        }

        public double CalculateArea()
        {
            return rectangleSideA * rectangleSideB;
        }
    }
}
