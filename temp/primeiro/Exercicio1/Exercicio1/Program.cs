using System;
using System.Globalization;


namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Questão 01    
                int x, y;
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                Console.WriteLine("SOMA = " + (x+y).ToString());
            
                Questão 02
                double pi, area, raio;
                pi = 3.14159;
                raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                area = pi * Math.Pow(raio, 2);

                Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            

                Questão 03
                int a, b, c, d;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());

                int diferenca = (a * b) - (c * d);

                Console.WriteLine("DIFERENCA = " + diferenca.ToString());
            

                Questão 04
                int num, horas;
                double valor, salario;

                num = int.Parse(Console.ReadLine());
                horas = int.Parse(Console.ReadLine());
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                salario = valor * horas;

                Console.WriteLine("NUMBER = {0}", num);
                Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
                
                Questão 05
                string[] v1, v2;
                v1 = Console.ReadLine().Split(' ');
                v2 = Console.ReadLine().Split(' ');

                int cod1, cod2, qtd1, qtd2;
                double val1, val2;

                cod1 = int.Parse(v1[0]);
                qtd1 = int.Parse(v1[1]);
                cod2 = int.Parse(v2[0]);
                qtd2 = int.Parse(v2[1]);
                val1 = double.Parse(v1[2], CultureInfo.InvariantCulture);
                val2 = double.Parse(v2[2], CultureInfo.InvariantCulture);

                double total = (val1 * qtd1) + (val2 * qtd2);

                Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            */

            string[] v = Console.ReadLine().Split(' ');

            double a, b, c;
            a = double.Parse(v[0], CultureInfo.InvariantCulture);
            b = double.Parse(v[1], CultureInfo.InvariantCulture);
            c = double.Parse(v[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double aTri = a * c / 2;
            double aCir = pi * Math.Pow(c, 2);
            double aTra = (a + b) * c / 2;
            double aQua = Math.Pow(b, 2);
            double aRet = a * b;

            Console.WriteLine("TRIANGULO: " + aTri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + aCir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + aTra.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + aQua.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + aRet.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
