using System;
using System.Linq;

namespace MindBoxSolution.Primitives
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Сторона А
        /// </summary>
        double _edgeA;

        /// <summary>
        /// Сторона B
        /// </summary>
        double _edgeB;

        /// <summary>
        /// Сторона C
        /// </summary>
        double _edgeC;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="edgeA">Сторона A</param>
        /// <param name="edgeB">Сторона B</param>
        /// <param name="edgeC">Сторона C</param>
        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if(edgeA <= 0.0 || edgeB <= 0.0 || edgeC <= 0.0)
            {
                throw new ArgumentException("Wrong input data: the length of a side of a triangle cannot be less than or equal to zero");
            }

            if(edgeA + edgeB <= edgeC || edgeC + edgeB <= edgeA || edgeA + edgeC <= edgeB)
            {
                throw new ArgumentException("Wrong input data: the sum of the lengths of two sides of a triangle cannot be less than the length of the third side of the triangle");
            }

            _edgeA = edgeA;
            _edgeB = edgeB;
            _edgeC = edgeC;
        }

        /// <inheritdoc />
        public double GetArea()
        {
            var semiPerimeter = GetPerimeter() / 2.0;
            return Math.Sqrt(semiPerimeter 
                * (semiPerimeter - _edgeA) * (semiPerimeter - _edgeB) * (semiPerimeter - _edgeC));

        }

        /// <summary>
        /// Метод нахождения периметра треугольника
        /// </summary>
        /// <returns>Периметр треугольника</returns>
        private double GetPerimeter()
        {
            return _edgeA + _edgeB + _edgeC;
        }

        /// <summary>
        /// Проверка, что треугольник прямоугольный
        /// </summary>
        public bool isRightTriangle()
        {
            var maxEdge = new[] { _edgeA, _edgeB, _edgeC }.Max();
            return Math.Abs((Math.Pow(maxEdge, 2.0) * 2.0) 
                - (Math.Pow(_edgeA, 2.0) + Math.Pow(_edgeB, 2.0) + Math.Pow(_edgeC, 2.0))) <= Consts.DoubleAccuracy;
        }

    }
}
