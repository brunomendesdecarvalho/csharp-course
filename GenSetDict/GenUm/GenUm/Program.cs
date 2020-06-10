using GenUm.Entities;
using System;

namespace GenUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many values? ");
            int amount = int.Parse(Console.ReadLine());
            PrintService<int> ps = new PrintService<int>();
            for(int i = 0; i < amount; i++)
            {
                ps.AddValue(int.Parse(Console.ReadLine()));
            }

            ps.Print();


        }
    }
}
