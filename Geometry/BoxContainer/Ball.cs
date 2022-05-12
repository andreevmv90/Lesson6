using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxContainer
{
    public class Ball : Shape
    {
        private readonly int _radius;

        public int Radius
        {
            get
            {
                return _radius;
            }
        }

        public Ball(int radius)
        {
            _radius = radius;
        }

        public override double Volume()
        {
            return (4 * Math.PI / 3) * MyPow(_radius, 3);
        }
    }
}
