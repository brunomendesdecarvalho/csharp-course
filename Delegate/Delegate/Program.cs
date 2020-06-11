using System;
using Delegate.Services;
namespace Delegate
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;
            double y = 12;
            
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(x, y);
        }
    }
}
