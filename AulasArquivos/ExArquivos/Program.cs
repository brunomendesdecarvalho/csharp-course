using System;
using System.IO;
using System.Globalization;
using ExArquivos.Entities;

namespace ExArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                string sourceFile = @"D:\aulas C#\AulasArquivos\ExArquivos\source.csv";
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                string targetFolder = sourceFolder + "\\out";
                string targetFile = targetFolder + "\\summary.csv";

                string[] lines = File.ReadAllLines(sourceFile);
                Directory.CreateDirectory(targetFolder);

                using (StreamWriter sw = File.AppendText(targetFile))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        
                        Product prod = new Product(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture), int.Parse(fields[2]));
                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("An error occurred");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
