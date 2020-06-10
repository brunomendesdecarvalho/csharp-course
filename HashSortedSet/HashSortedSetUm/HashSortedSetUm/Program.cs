using System;
using System.Collections.Generic;

namespace HashSortedSetUm
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}
