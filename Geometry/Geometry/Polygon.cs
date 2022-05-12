using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonCreator
{
    public class Polygon
    {
        private readonly Point _point1;
        private readonly Point _point2;
        private readonly Point _point3;
        private readonly Point _point4;
        private readonly Point _point5;

        private readonly string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double? Perimetr
        {
            get 
            {
                double? result;

                if (_point1 != null && _point2 != null && _point3 != null)
                {
                    if (_point4 != null && _point5 != null)
                    {
                        result = PerimetrCalc(_point1, _point2, _point3, _point4, _point5);
                    }
                    else if (_point4 != null)
                    {
                        result = PerimetrCalc(_point1, _point2, _point3, _point4);
                    }
                    else
                    {
                        result = PerimetrCalc(_point1, _point2, _point3);
                    }
                }
                else
                {
                    result = null;
                }

                return result;
            }
        }

        public Polygon(string name, Point point1, Point point2, Point point3)
        {
            _name = name;
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
        }

        public Polygon(string name, Point point1, Point point2, Point point3, Point point4) 
            : this(name, point1, point2, point3)
        {
            _point4 = point4;
        }

        public Polygon(string name, Point point1, Point point2, Point point3, Point point4, Point point5) 
            : this(name, point1, point2, point3, point4)
        {
            _point5 = point5;
        }

        private double PerimetrCalc(Point point1, Point point2, Point point3)
        {
            var side1 = Math.Sqrt(MyPow(point2.X - point1.X, 2) + MyPow(point2.Y - point1.Y, 2)); // точка 1 и 2
            var side2 = Math.Sqrt(MyPow(point3.X - point1.X, 2) + MyPow(point3.Y - point1.Y, 2)); // точка 1 и 3
            var side3 = Math.Sqrt(MyPow(point3.X - point2.X, 2) + MyPow(point3.Y - point2.Y, 2)); // точка 2 и 3
            return side1 + side2 + side3;
        }

        private double PerimetrCalc(Point point1, Point point2, Point point3, Point point4)
        {
            var side1 = Math.Sqrt(MyPow(point2.X - point1.X, 2) + MyPow(point2.Y - point1.Y, 2)); // точка 1 и 2
            var side2 = Math.Sqrt(MyPow(point3.X - point2.X, 2) + MyPow(point3.Y - point2.Y, 2)); // точка 2 и 3
            var side3 = Math.Sqrt(MyPow(point3.X - point4.X, 2) + MyPow(point3.Y - point4.Y, 2)); // точка 3 и 4
            var side4 = Math.Sqrt(MyPow(point1.X - point4.X, 2) + MyPow(point1.Y - point4.Y, 2)); // точка 1 и 4
            return side1 + side2 + side3 + side4;
        }

        private double PerimetrCalc(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            var side1 = Math.Sqrt(MyPow(point2.X - point1.X, 2) + MyPow(point2.Y - point1.Y, 2)); // точка 1 и 2
            var side2 = Math.Sqrt(MyPow(point3.X - point2.X, 2) + MyPow(point3.Y - point2.Y, 2)); // точка 2 и 3
            var side3 = Math.Sqrt(MyPow(point3.X - point4.X, 2) + MyPow(point3.Y - point4.Y, 2)); // точка 3 и 4
            var side4 = Math.Sqrt(MyPow(point5.X - point4.X, 2) + MyPow(point5.Y - point4.Y, 2)); // точка 4 и 5
            var side5 = Math.Sqrt(MyPow(point5.X - point1.X, 2) + MyPow(point5.Y - point1.Y, 2)); // точка 1 и 5
            return side1 + side2 + side3 + side4 + side5;
        }

        private static int MyPow(int value, int step)
        {
            var _step = step - 1;
            int result = value;
            while(_step != 0)
            {
                _step--;
                result *= value;
            }

            return result;
        }
    }
}
