using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\File1.txt";
            string targetPath = @"D:\File2.txt";

            try 
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string i in lines)
                {
                    System.Console.WriteLine(i);
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
