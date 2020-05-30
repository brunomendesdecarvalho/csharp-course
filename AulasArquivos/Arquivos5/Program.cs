using System;
using System.IO;

namespace Arquivos5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\Aulas C#";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                System.Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    System.Console.WriteLine(s);
                }

                var files = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                System.Console.WriteLine("FILES:");
                foreach (string f in files)
                {
                    System.Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + "\\newfolder");
            }
            catch (IOException e)
            {
                System.Console.WriteLine("An error occurred");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
