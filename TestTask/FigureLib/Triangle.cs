using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            if (a < 0)
            {
                throw new ArgumentException("Side A can't be less than zero");
            }

            if (b < 0)
            {
                throw new ArgumentException("Side B can't be less than zero");
            }

            if (c < 0)
            {
                throw new ArgumentException("Side C can't be less than zero");
            }

            if (c >= a + b || b >= a + c || a >= b + c)
            {
                throw new ArgumentException($"Triangle with sides {a}, {b}, {c} is impossible");
            }

            _a = a;
            _b = b;
            _c = c;
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
