using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxContainer
{
    public class Cylinder : Shape
    {

        public int Height
        {
            get;
        }

        public int Radius
        {
            get;
        }


        public Cylinder(int height, int radius)
        {
            Height = height;
            Radius = radius;
        }

        public override double Volume()
        {
            return Math.PI * MyPow(Radius, 2) * Height;
        }
    }
}
