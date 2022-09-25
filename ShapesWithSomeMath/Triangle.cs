namespace ShapesWithSomeMath;

public class Triangle : Shape
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public override double Area()
    {
        double halfPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }

    public bool IsRectangular()
    {
        FindGreatestSide(out var greatest, out var lowestSides, SideA, SideB, SideC);
        var greatestSquare = ValueSquare(greatest);
        var lowestsSquareSum = ValueSquare(lowestSides[0]) + ValueSquare(lowestSides[1]);
        return Math.Abs(greatestSquare - lowestsSquareSum) < FloatCompareTolerance;
    }

    protected static void FindGreatestSide(out double greatest, out double[] lowestSides, params double[] sides)
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
}