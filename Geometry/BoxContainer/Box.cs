using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxContainer
{
    public class Box : Shape
    {
        private readonly int _height;

        public int Height
        {
            get
            {
                return _height;
            }
        }

        public Box(int height)
        {
            _height = height;
        }
        
        public override double Volume()
        {
            return _remainedVolume = MyPow(_height, 3);
        }

        /*
         * Реализация заполнения Куба
        */
        private double _remainedVolume;
        public double RemainedVolume
        {
            get
            {
                return _remainedVolume;
            }
        }

        public bool Add(Shape shape)
        {
            bool result = false;

            if (shape.Volume() < _remainedVolume)
            {
                result = true;
                _remainedVolume -= shape.Volume();
            }             

            return result;
        }

    }
}
