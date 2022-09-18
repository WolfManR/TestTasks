using ShapeMath;

namespace TestTasksTests;

public class AreaCalculationTests
{
    private readonly MathSh _mathService;
    public AreaCalculationTests()
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
    [InlineData(3.54, 2.45, 2, 2)]
    [InlineData(2.83, 2, 2, 2)]
    [InlineData(10.95, 7.22, 6.91, 24)]
    [InlineData(8, 9.43, 5, 20)]
    public void ValidTriangleArea(double sideA, double sideB, double sideC, int expectedAreaInInteger)
    {
        var result = Math.Round(_mathService.TriangleAreaBySides(sideA, sideB, sideC));
        Assert.Equal(expectedAreaInInteger, result);
    }
}