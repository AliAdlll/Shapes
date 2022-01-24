using Shapes_Abstract.Concrete;
using System;
using System.Collections.Generic;

namespace Shapes_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> shapes = new List<Shapes>();
            shapes.Add(new Triangle(2, 5));
            shapes.Add(new Square(4));
            shapes.Add(new Circle(6));
            shapes.Add(new Rectangle(3, 4));
            foreach (var item in shapes)
            {
                Console.WriteLine($"NameOfShape: { item.NameOfShape} Area= {item.Area()} Environment= {item.Environment()}");
            }
        }
    }
}
