using System;

namespace MindBoxSolution.Primitives
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        double _radius;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException">Радиус меньше или равен нулю</exception>
        public Circle(double radius)
        {
            if (radius <= 0.0)
            {
                throw new ArgumentException("Provided radius is not a positive double");
            }
            _radius = radius;
        }

        /// <inheritdoc />
        public double GetArea()
        {
            return Math.Pow(_radius, 2.0)*Math.PI;
        }
    }
}
