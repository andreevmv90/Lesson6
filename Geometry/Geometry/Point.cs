using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonCreator
{
    public class Point
    {
        private readonly string _name;
        private readonly int _x;
        private readonly int _y;

        public Point(string name, int x, int y)
        {
            _name = name;
            _x = x;
            _y = y;
        }

        public string Name 
        { 
            get 
            { 
                return _name; 
            } 
        }

        public int X 
        {
            get
            {
                return _x;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }
    }
}
