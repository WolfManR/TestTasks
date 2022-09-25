namespace ShapesWithSomeMath;

public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public override double Area() => 0;
}

public class Triangle : Shape
{
    public override double Area() => 0;
}

public class RectangularTriangle : Triangle
{
    public override double Area() => 0;
}