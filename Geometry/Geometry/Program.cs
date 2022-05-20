using System;
using System.Collections.Generic;

namespace PolygonCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This is Polygon creator");
            Console.WriteLine("Enter Polygon's name");
            var name = Console.ReadLine();

            var points = new List<Point>() 
            { 
                new Point("Point1", 10, 10), 
                new Point("Point2", 20, 20), 
                new Point("Point3", 20, 10) 
            };

            var polygon = new Polygon(name, points);                

            Console.WriteLine($"Figure '{polygon.Name}' has perimetr = {polygon.Perimetr}");
            Console.ReadKey();
        }
    }
}
