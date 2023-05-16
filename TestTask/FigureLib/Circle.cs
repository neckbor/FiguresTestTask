namespace FigureLib
{
    public class Circle : Figure
    {
        private double _radius;

        /// <summary>
        /// Initializes a new instance of Circle class
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <exception cref="ArgumentException">In case radius is less than zero</exception>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Сircle raduis can't be less than zero");
            }

            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
