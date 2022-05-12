using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxContainer
{
    public class Pyramid : Shape
    {
        private readonly int _height;
        private readonly int _square;

        public int Height
        {
            get
            {
                return _height;
            }
        }

        public int Square
        {
            get
            {
                return _square;
            }
        }

        public Pyramid(int height, int square)
        {
            _height = height;
            _square = square;
        }

        public override double Volume()
        {
            return _height * _square / 3;
        }
    }
}
