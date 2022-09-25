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