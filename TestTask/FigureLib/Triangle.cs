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
