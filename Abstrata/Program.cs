using System;
using System.Globalization;
using System.Collections.Generic;
using Abstrata.Entities;
using Abstrata.Entities.Enums;

namespace Abstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int N = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < N; i++)
            {
                System.Console.WriteLine($"Shape #{i + 1} data:");
                System.Console.Write("Rectangle or Circle (r/c)? ");
                string fig = Console.ReadLine();
                System.Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (fig.Equals("r"))
                {
                    System.Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    System.Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                    
                    Rectangle rect = new Rectangle(width, height, color);
                    shapes.Add(rect);
                }
                else
                {
                    System.Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Circle cir = new Circle(radius, color);
                    shapes.Add(cir);
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("SHAPE AREAS:");
            foreach(Shape shape in shapes)
            {
                System.Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
