public static class MathHelper
{
    // Statisk felt for matematiske konstanter
    public static readonly double Pi = 3.14159;

    // En statisk metode for å beregne arealet av en sirkel
    public static double CalculateCircleArea(double radius)
    {
        return Pi * radius * radius;
    }
}