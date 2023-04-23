using MindBoxSolution.Primitives;

namespace MindBoxSolution.Tests
{
    /// <summary>
    /// Тесты для круга
    /// </summary>
    [TestFixture]
    public class CircleTests
    {
        /// <summary>
        /// Исключение: Отрицательный или нулевой радиус круга
        /// </summary>
        [Test]
        public void CircleNegativeRadiusTest_Exception()
        {
            IFigure figure;

            Assert.Throws<ArgumentException>(() => figure = new Circle(-1));
            Assert.Throws<ArgumentException>(() => figure = new Circle(0));
        }

        /// <summary>
        /// Успех: Нахождение площади круга
        /// </summary>
        [Test]
        public void CirclePositiveRadiusTest_Success()
        {
            var radius = 5.0;
            IFigure figure = new Circle(radius);

            var expectedValue = 78.5398163375;
            var returnedValue = figure.GetArea();

            Assert.IsTrue(returnedValue - expectedValue <= Consts.DoubleAccuracy);
        }
    }
}
