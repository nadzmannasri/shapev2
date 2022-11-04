using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class square : rectangle
    {
        private double _len;
        public double Len
        {
            get { return _len; }
            set { _len = value; }
        }

        public square()
        {
            _len = 0;
        }

        public square(double len)
        {
            _len = len;
        }

        public new double area()
        {
            return _len*_len;
        }

        public new double circumference()
        { 
            return 4 * _len;
        }
    }
}
