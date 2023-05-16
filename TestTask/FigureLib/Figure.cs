using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public abstract class Figure
    {
        /// <summary>
        /// Returns calculated figure's area
        /// </summary>
        /// <returns>Area</returns>
        public abstract double GetArea();
    }
}
