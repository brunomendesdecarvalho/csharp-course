﻿using System;

namespace Delegate.Services
{
    class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }
        
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        
        public static double Square(double x)
        {
            return x * x;
        }

        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y; // x é maior que y? Se sim, x; se não, y.
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }
    }
}
