using System;
using ExtensionMethod.Extensions;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 05, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
