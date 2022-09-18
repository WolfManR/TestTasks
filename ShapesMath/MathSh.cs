namespace ShapeMath;

public static class MathSh
{
    public static double CircleArea(double radius) => Math.PI * ValueSquare(radius);

    public static double TriangleAreaBySides(double sideA, double sideB, double sideC)
    {
        FindGreatestSide(out var greatest, out var lowestSides, sideA, sideB, sideC);
        if (IsTriangleRectangular(greatest, lowestSides)) return .5 * lowestSides[0] * lowestSides[1];
        double halfPerimeter = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
    }

    public static void FindGreatestSide(out double greatest, out double[] lowestSides, params double[] sides)
    {
        greatest = sides[0];
        lowestSides = new double[sides.Length - 1];
        for (var i = 1; i < sides.Length; i++)
        {
            if (greatest >= sides[i])
            {
                lowestSides[i-1] = sides[i];
                continue;
            }

            lowestSides[i - 1] = greatest;
            greatest = sides[i];
        }
    }

    public static bool IsTriangleRectangular(double greatest, IReadOnlyList<double> lowestSides)
    {
        return Math.Abs(ValueSquare(greatest) - (ValueSquare(lowestSides[0]) + ValueSquare(lowestSides[1]))) < 0.0002;
    }

    public static double ValueSquare(double value) => value * value;
}