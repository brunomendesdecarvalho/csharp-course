using System;
using System.Globalization;
using System.Collections.Generic;
using ExPolimorfismo.Entities;

namespace ExPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of employees: ");
            int N = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
        
            for(int i = 0; i < N; i++)
            {
                System.Console.WriteLine($"Employee #{(i+1)} data:");
                System.Console.Write("Outsourced (y/n)? ");
                string op = Console.ReadLine();
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (op.Equals("n"))
                {
                    Employee emp = new Employee(name, hours, valuePerHour);
                    employees.Add(emp);
                }
                else
                {
                    System.Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee emp = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(emp);
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in employees)
            {
                System.Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
