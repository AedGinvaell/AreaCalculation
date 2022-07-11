using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Circle
    {
        const double pi = 3.1415;
        // Вычисление площади круга по формуле π × r2
        public static double AreaCalculation(double radius)
        {
            return Math.Pow(radius, 2) * pi;
        }

    }
}
