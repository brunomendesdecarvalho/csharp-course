using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using ExLINQ.Entities;

namespace ExLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            
            List<Product> list = new List<Product>();
            
            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] prod = sr.ReadLine().Split(',');
                    list.Add(new Product(prod[0], double.Parse(prod[1], CultureInfo.InvariantCulture)));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
