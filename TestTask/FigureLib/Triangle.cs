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

        /// <summary>
        /// Initializes a new instanse of Triangle class
        /// </summary>
        /// <param name="a">Side A</param>
        /// <param name="b">Side B</param>
        /// <param name="c">Side C</param>
        /// <exception cref="ArgumentException">In case argument is less than zero or triangle is impossible with given sides</exception>
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
            double halfP = (_a + _b + _c) / 2;

            return Math.Sqrt(halfP * (halfP - _a) * (halfP - _b) * (halfP - _c));
        }

        /// <summary>
        /// Indicates where triangle is rectangular
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            List<double> q = new List<double>() { _a, _b, _c };
            q.Sort();

            return Math.Pow(q.ElementAt(2), 2) == Math.Pow(q.ElementAt(1), 2) + Math.Pow(q.ElementAt(0), 2);
        }
    }
}
