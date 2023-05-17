namespace FigureLib.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleInvalidNegativeArgument()
        {
            double a = -7.0;
            double b = 8.0;
            double c = 9.0;

            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void ImpossibleTriangleArguments()
        {
            double a = 7.0;
            double b = 8.0;
            double c = 20.0;

            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void CorrectAreaCalculating()
        {
            double a = 7.0;
            double b = 8.0;
            double c = 9.0;

            Figure figure = new Triangle(a, b, c);

            double halfP = (a + b + c) / 2;
            double expected = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));

            Assert.Equal(expected, figure.GetArea(), 15);
        }

        [Fact]
        public void CheckRectangularTriangle()
        {
            double a = 15.0;
            double b = 12.0;
            double c = 9.0;

            Triangle triangle = new Triangle(a, b, c);

            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void CheckNonRectangularTriangle() 
        {
            double a = 4.0;
            double b = 3.0;
            double c = 8.0;

            Triangle triangle = new Triangle(a, b, c);

            Assert.False(triangle.IsRectangular());
        }
    }
}