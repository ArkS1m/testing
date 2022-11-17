using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.MyExtensions
{
    public static class DoubleExtension
    {
        public static bool CompareNumbers(this double num1, double num2)
        {
            if (Math.Abs(num1 - num2) < Math.Pow(10.0, -17))
                return true;
            return false;
        }
    }
}
