using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Especificar o data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Definir a expressão de consulta
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Executar a consulta
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
