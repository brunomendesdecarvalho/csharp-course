using System;
using System.IO;

namespace Arquivos3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\File1.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    using(StreamReader sr = new StreamReader(fs)) {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            System.Console.WriteLine(line);
                        }
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
