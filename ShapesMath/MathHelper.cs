namespace ShapeMath;

internal static class MathHelper
{
    public static void FindGreatestSide(out double greatest, out double[] lowestSides, params double[] sides)
    {
        greatest = sides[0];
        lowestSides = new double[sides.Length - 1];
        for (var i = 1; i < sides.Length; i++)
        {
            if (greatest >= sides[i])
            {
                lowestSides[i - 1] = sides[i];
                continue;
            }

            lowestSides[i - 1] = greatest;
            greatest = sides[i];
        }
    }

    public static bool IsTriangleRectangular(double greatest, IReadOnlyList<double> lowestSides, double floatCompareTolerance = 0.02)
    {
        var greatestSquare = ValueSquare(greatest);
        var lowestsSquareSum = ValueSquare(lowestSides[0]) + ValueSquare(lowestSides[1]);
        return Math.Abs(greatestSquare - lowestsSquareSum) < floatCompareTolerance;
    }

    public static double ValueSquare(double value) => value * value;
}