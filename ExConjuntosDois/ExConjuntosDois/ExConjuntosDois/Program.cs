using System;
using System.Collections.Generic;

namespace ExConjuntosDois
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            GetStudents("A", a);
            GetStudents("B", b);
            GetStudents("C", c);

            HashSet<int> total = new HashSet<int>(a);
            total.UnionWith(b);
            total.UnionWith(c);

            Console.Write("Total students: " + total.Count.ToString());

            static void GetStudents(string course, HashSet<int> students)
            {
                try
                {
                    Console.Write("How many students for course " + course + "?");
                    int N = int.Parse(Console.ReadLine());
                    for (int i = 0; i < N; i++)
                    {
                        students.Add(int.Parse(Console.ReadLine()));
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
