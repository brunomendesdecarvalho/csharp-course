using System;
using System.IO;

namespace Arquivos6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\Aulas C#\File1.txt";
            
            System.Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            System.Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            System.Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            System.Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            System.Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            System.Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            System.Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            System.Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
