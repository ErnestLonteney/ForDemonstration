namespace DiscriminantCalculator;

public static class DiscriminantCalculator
{
    private static double GetDiscriminant(double a, double b, double c) => Math.Pow(b, 2) - 4 * a * c;

    public static XResult CalculateDiscriminant(double a, double b, double c)
    {
         var discriminant = GetDiscriminant(a, b, c);   

         if (discriminant > 0)
         {
             var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
             var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
             
            return new XResult(x1, x2, "Two distinct real roots.");
         }
         else if (discriminant == 0)
         {
             var x = -b / (2 * a);
             return new XResult(x, null, "One real root (double root).");
         }
         else
         {
             return new XResult(null, null, "No real roots.");
         }   
    }
}


