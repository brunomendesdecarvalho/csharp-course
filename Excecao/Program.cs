using System;

namespace Excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                System.Console.WriteLine(result);
            } 
            catch (DivideByZeroException e) 
            {
                Console.WriteLine("Division by zero.");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error.");
            }
            finally
            {
                System.Console.WriteLine("Ending...");
            }
        }
    }
}
