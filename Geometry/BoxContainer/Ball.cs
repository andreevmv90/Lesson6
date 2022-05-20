using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxContainer
{
    public class Ball : Shape
    {

        public int Radius
        {
            get;
        }

        public Ball(int radius)
        {
            Radius = radius;
        }

        public override double Volume()
        {
            return (4 * Math.PI / 3) * MyPow(Radius, 3);
        }
    }
}
