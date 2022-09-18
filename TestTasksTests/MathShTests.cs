using ShapeMath;

namespace TestTasksTests
{
    public class MathShTests
    {
        private readonly MathSh _mathService;
        public MathShTests()
        {
            _mathService = new();
        }

        [Theory]
        [InlineData(7, 154)]
        [InlineData(14, 616)]
        public void ValidCircleArea(double radius, int expectedAreaInInteger)
        {
            var result = Math.Round(_mathService.CircleArea(radius));
            Assert.Equal(expectedAreaInInteger, result);
        }

        [Theory]
        [InlineData(2.24, new double[] { 2, 1 }, true)]
        [InlineData(2.83, new double[] { 2, 2 }, true)]
        [InlineData(3.54, new double[] { 2.45, 2 }, false)]
        [InlineData(1, new double[] { 1, 1 }, false)]
        public void TriangleRectangularCheckCorrect(double greatest, double[] lowestSides, bool expected)
        {
            var result = _mathService.IsTriangleRectangular(greatest, lowestSides);
            Assert.Equal(expected, result);
        }
    }
}