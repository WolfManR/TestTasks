namespace ShapesTests;

public class ShapesTests
{
    [Fact]
    public void AreaForTriangleCalculable()
    {
        var  triangle = new Triangle(10.95, 7.22, 6.91);

        var area = triangle.Area();

        Assert.True(area > 0);
    }

    [Fact]
    public void RectangularTriangleIsRectangular()
    {
        var triangle = new Triangle(2.24, 2, 1);
        triangle.FloatCompareTolerance = 0.02;

        var result = triangle.IsRectangular();

        Assert.True(result);
    }

    [Fact]
    public void NotRectangularTriangleIsNotRectangular()
    {
        var triangle = new Triangle(3.54, 2.45, 2);
        triangle.FloatCompareTolerance = 0.02;

        var result = triangle.IsRectangular();

        Assert.False(result);
    }

    [Fact]
    public void AreaForCircleCalculable()
    {
        var  circle = new Circle(14);

        var area = circle.Area();

        Assert.True(area > 0);
    }

    [Fact]
    public void AreaCalculableWithoutKnowingTypeOfShape()
    {
        Shape triangle = new Triangle(10.95, 7.22, 6.91);

        var area = triangle.Area();

        Assert.True(area > 0);
    }
}