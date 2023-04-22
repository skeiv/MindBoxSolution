using MindBoxSolution.Primitives;

namespace MindBoxSolution.Tests
{
    /// <summary>
    /// Тесты для треугольника
    /// </summary>
    [TestFixture]
    public class TriangleTests
    {
        /// <summary>
        ///  Исключение: Отрицательная или нулевая длина стороны треугольника
        /// </summary>
        [Test]
        public void TriangleNegativeEdgesTest_Exception()
        {
            IFigure figure;

            Assert.Throws<ArgumentException>(() => figure = new Triangle(-1, 1, 0));
            Assert.Throws<ArgumentException>(() => figure = new Triangle(1, -1, 0));
            Assert.Throws<ArgumentException>(() => figure = new Triangle(1, 0, -1));
            Assert.Throws<ArgumentException>(() => figure = new Triangle(-1, -1, -1));
            Assert.Throws<ArgumentException>(() => figure = new Triangle(0, 1, 0));
        }

        /// <summary>
        /// Успех: Нахождение площади треугольника
        /// </summary>
        [Test]
        public void TrianglePositiveEdgesTest_Success()
        {
            var edgeA = 5.0;
            var edgeB = 5.0; 
            var edgeC = 6.0;
            IFigure figure = new Triangle(edgeA, edgeB, edgeC);

            var returnedValue = figure.GetArea();
            var expectedValue = 12.0;
            
            Assert.IsTrue(returnedValue - expectedValue <= Consts.DoubleAccuracy);
        }

        /// <summary>
        /// Проверка на прямоугольность треугольника: треугольник не прямоугольный
        /// </summary>
        [Test]
        public void IsTriangleRight_False()
        {
            var edgeA = 5.0;
            var edgeB = 5.0;
            var edgeC = 6.0;
            Triangle figure = new Triangle(edgeA, edgeB, edgeC);

            var returnedValue = figure.isRightTriangle();

            Assert.IsFalse(returnedValue);
        }

        /// <summary>
        /// Проверка на прямоугольность треугольника: треугольник прямоугольный
        /// </summary>
        [Test]
        public void IsTriangleRight_True()
        {
            var edgeA = 3.0;
            var edgeB = 4.0;
            var edgeC = 5.0;
            Triangle figure = new Triangle(edgeA, edgeB, edgeC);

            var returnedValue = figure.isRightTriangle();

            Assert.IsTrue(returnedValue);
        }
    }
}
