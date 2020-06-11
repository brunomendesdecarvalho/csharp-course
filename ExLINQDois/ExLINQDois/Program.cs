using ExLINQDois.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExLINQDois
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] emp = sr.ReadLine().Split(',');
                    employees.Add(new Employee(emp[0], emp[1], double.Parse(emp[2], CultureInfo.InvariantCulture)));
                }
            }

            var emails = employees.Where(p => p.Salary > salary).Select(p => p.Email);
            var sum = employees.Where(p => p.Name.StartsWith('M')).Sum(p => p.Salary);

            Console.WriteLine("Email of people whose salary is more than " + salary + ":");
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum);
        }
    }
}
