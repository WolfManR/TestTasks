namespace ShapesWithSomeMath;

public abstract class Shape
{
    public double FloatCompareTolerance { get; set; } = 0.002;

    public abstract double Area();

    protected static double ValueSquare(double value) => value * value;
}