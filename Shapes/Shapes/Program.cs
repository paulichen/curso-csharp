using System;
using System.Collections.Generic;
using Shapes.Entities;
using Shapes.Entities.Enums;
using System.Globalization;

namespace Shapes {
    class Program {
        static void Main(string[] args) {

            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("Enter number of Shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                Console.WriteLine($"Shape #{i + 1} data: ");
                Console.Write("REctangle or Circle? (r/c) ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(ch == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, height, color));
                } else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape s in shapes) {
                Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
