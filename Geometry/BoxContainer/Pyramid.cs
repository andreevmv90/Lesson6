using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxContainer
{
    public class Pyramid : Shape
    {

        public int Height
        {
            get;
        }

        public int Square
        {
            get;
        }

        public Pyramid(int height, int square)
        {
            Height = height;
            Square = square;
        }

        public override double Volume()
        {
            return Height * Square / 3;
        }
    }
}
