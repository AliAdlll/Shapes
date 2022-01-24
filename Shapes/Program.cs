using System;
using System.Collections.Generic;
using Shapes_InterFace.Concrete;
using Shapes_InterFace.Contrcat;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Circle ID:0   Square Id:1   Triangle Id:2");
            //Console.Write($"Shape Id: ");
            //byte shapeID = byte.Parse(Console.ReadLine());
            //if (shapeID==0)
            //{
            //    Console.Write($"Enter Radius: ");
            //}
            var shapes = new List<IShapes>();
            shapes.Add(new Circle(3));
            shapes.Add(new Circle(4));
            shapes.Add(new Square(6));
            shapes.Add(new Square(7));
            shapes.Add(new Triangle(3,2));
            shapes.Add(new Triangle(7,2));
            shapes.Add(new Rectangle(4,5));
            shapes.Add(new Rectangle(4,3));
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"NameOfShape: {shapes[i].NameOfShape}    " +
                    $"Area= {shapes[i].Area()}   " +
                    $"Environment= {shapes[i].Environment()}");
            }
        }
    }
}
