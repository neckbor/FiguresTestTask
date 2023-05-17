using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CircleInvalidNegativeArgument()
        {
            double radius = -2.0;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Fact]
        public void CorrectAreaCalculating()
        {
            double radius = 5.0;

            Figure figure = new Circle(radius);

            double expected = Math.PI * Math.Pow(radius, 2);

            Assert.Equal(expected, figure.GetArea(), 15);
        }
    }
}
