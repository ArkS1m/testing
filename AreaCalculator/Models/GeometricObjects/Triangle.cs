using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Models.GeometricObjects
{
    public class Triangle : IGeometricObject
    {
        double triangleSideA { get; }
        double triangleSideB { get; }
        double triangleSideC { get; }
        public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            this.triangleSideA = triangleSideA;
            this.triangleSideB = triangleSideB;
            this.triangleSideC = triangleSideC;
        }
        bool IsRightTriangle()
        {
            if ((Math.Pow(triangleSideA, 2) + Math.Pow(triangleSideB, 2) + Math.Pow(triangleSideC, 2)) / 2 ==
                Math.Pow(Math.Max(triangleSideA, Math.Max(triangleSideB, triangleSideC)), 2))
                return true;
            return false;
        }
        public double CalculateArea()
        {
            if (IsRightTriangle())
                return (triangleSideA * triangleSideB) / 2;
            else
            {
                double halfPerimeter = (triangleSideA + triangleSideB + triangleSideC) / 2;

                return Math.Sqrt(halfPerimeter * (halfPerimeter - triangleSideA) *
                    (halfPerimeter - triangleSideA) * (halfPerimeter - triangleSideB));
            }

        }
    }
}
