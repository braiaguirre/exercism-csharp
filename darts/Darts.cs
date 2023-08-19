using System;

public static class Darts
{
    public static double Score(double x, double y)
    {
        double coord = Math.Pow(x, 2) + Math.Pow(y, 2);
        return coord > 100 ? 0 : coord > 25 ? 1 : coord > 1 ? 5 : 10;
    }
}
