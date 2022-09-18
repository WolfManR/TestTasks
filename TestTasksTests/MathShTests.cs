using static ShapeMath.MathSh;

namespace TestTasksTests
{
    public class MathShTests
    {
        [Theory]
        [InlineData(7, 154)]
        [InlineData(14, 616)]
        public void ValidCircleArea(double radius, int expectedAreaInInteger)
        {
            var result = Math.Round(CircleArea(radius));
            Assert.Equal(expectedAreaInInteger, result);
        }
    }
}