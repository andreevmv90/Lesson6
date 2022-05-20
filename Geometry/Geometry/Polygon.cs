using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonCreator
{
    public class Polygon
    {
        private List<Point> _points;

        public string Name
        {
            get;
        }

        public double Perimetr
        {
            get
            {
                return PerimetrCalc(_points);
            }
        }

        public Polygon(string name, List<Point> points)
        {
            Name = name;
            if (points.Count < 3)
                throw new Exception("Error number of points");
            _points = points;
        }

        private double PerimetrCalc(List<Point> points)
        {
            var result = 0.0;
            for(var i = 0; i < points.Count - 1; i++)
            {
                result += Math.Sqrt(MyPow(points[i + 1].X - points[i].X, 2) + MyPow(points[i + 1].Y - points[i].Y, 2));
            }
            result += Math.Sqrt(MyPow(points[points.Count - 1].X - points[0].X, 2) + MyPow(points[points.Count - 1].Y - points[0].Y, 2));
            return result;
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
