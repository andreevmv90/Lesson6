using System;

namespace PolygonCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This is Polygon creator");
            Console.WriteLine("Enter Polygon's name");
            var name = Console.ReadLine();
            int number;
            Console.WriteLine("Enter number of points. It must be inside the range 1-5");
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 5)
            {
                Console.WriteLine("Enter number of points. It must be inside the range 1-5");
            }


            var point1 = new Point("Point1", 0, 0);
            var point2 = new Point("Point2", 10, 10);
            var point3 = new Point("Point3", 20, 10);

            var polygon = new Polygon(name, point1, point2, point3);

            Point point4;
            Point point5;

            if (number == 4)
            {
                point4 = new Point("Point4", 30, 8);
                polygon = new Polygon(name, point1, point2, point3, point4);
            }              
            else if (number == 5)
            {
                point4 = new Point("Point4", 30, 8);
                point5 = new Point("Point5", 20, 2);
                polygon = new Polygon(name, point1, point2, point3, point4, point5);
            }
                

            Console.WriteLine($"Figure '{polygon.Name}' has perimetr = {polygon.Perimetr ?? -1}");
            Console.ReadKey();
        }
    }
}
