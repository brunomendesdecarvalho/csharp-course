using GenRestricao.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace GenRestricao
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("Enter N: ");
                int N = int.Parse(Console.ReadLine());
                List<double> prices = new List<double>();
                List<string> prods = new List<string>();
                for (int i = 0; i < N; i++)
                {
                    string[] prod = Console.ReadLine().Split(",");
                    prods.Add(prod[0]);
                    prices.Add(double.Parse(prod[1], CultureInfo.InvariantCulture));
                }

                CalculationService cs = new CalculationService();
                int index = prices.IndexOf(cs.Max(prices));
                Console.WriteLine("Most expensive:");
                Console.WriteLine(prods[index]
                                + ", "
                                + cs.Max(prices).ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
