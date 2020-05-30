using System;
using System.IO;

namespace Arquivos4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"d:\File1.txt";
            string targetPath = @"d:\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
