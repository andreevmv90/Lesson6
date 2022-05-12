using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxContainer
{
    public class Cylinder : Shape
    {
        private readonly int _height;
        private readonly int _radius;

        public int Height
        {
            get
            {
                return _height;
            }
        }

        public int Radius
        {
            get
            {
                return _radius;
            }
        }


        public Cylinder(int height, int radius)
        {
            _height = height;
            _radius = radius;
        }

        public override double Volume()
        {
            return Math.PI * MyPow(_radius, 2) * _height;
        }
    }
}
