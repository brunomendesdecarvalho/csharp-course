using Exercicio.Entities;
using Exercicio.Services;
using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contract c = new Contract(number, date, value);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());
            ContractService cs = new ContractService();

            cs.ProcessContract(c, months);
            Console.WriteLine(c.ToString());


        }
    }
}
