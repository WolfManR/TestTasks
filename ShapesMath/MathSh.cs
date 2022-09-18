namespace ShapeMath;

public class MathSh
{
    public double FloatNumbersCompareToleranceValue { get; set; } = 0.02;

    public double CircleArea(double radius) => Math.PI * MathHelper.ValueSquare(radius);

    public double TriangleAreaBySides(double sideA, double sideB, double sideC)
    {
        MathHelper.FindGreatestSide(out var greatest, out var lowestSides, sideA, sideB, sideC);
        if (MathHelper.IsTriangleRectangular(greatest, lowestSides, FloatNumbersCompareToleranceValue)) return .5 * lowestSides[0] * lowestSides[1];
        double halfPerimeter = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
    }
}