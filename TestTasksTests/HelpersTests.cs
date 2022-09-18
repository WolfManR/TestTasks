using ShapeMath;

namespace TestTasksTests;

public class HelpersTests
{
    private readonly MathSh _mathService;
    public HelpersTests()
    {
        _mathService = new();
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

    [Theory]
    [InlineData(new double[] { 3, 2, 1, 2, 3, 5 }, 5)]
    [InlineData(new double[] { 3.4, 2.2, 2.1, 2.4, 3, 5 }, 5)]
    [InlineData(new double[] { 2.11, 2.1, 2 }, 2.11)]
    public void GreaterValueIsGreater(double[] values, double expectedGreaterValue)
    {
        _mathService.FindGreatestSide(out var greatest, out _, values);

        Assert.Equal(expectedGreaterValue, greatest);
    }
}