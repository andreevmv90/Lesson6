using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxContainer
{
    public abstract class Shape
    {
        public abstract double Volume();

        public static int MyPow(int value, int step)
        {
            var _step = step - 1;
            int result = value;
            while (_step != 0)
            {
                _step--;
                result *= value;
            }

            return result;
        }
    }
}
