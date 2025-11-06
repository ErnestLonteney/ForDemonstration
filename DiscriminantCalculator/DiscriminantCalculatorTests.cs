namespace DiscriminantCalculator;

internal static class DiscriminantCalculatorTests
{

    public static void CalculateDiscriminant_CorrectInput_TwoRootsResult()
    {
        // Arrange
        double a = 10, b = 4, c = -6; 
        double x1Expected = 0.6, x2Expected = -1;

        // Act
        var result = DiscriminantCalculator.CalculateDiscriminant(a, b, c);

        // Assert
        if (result.X1 == x1Expected && result.X2 == x2Expected)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test passed");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Test failed");
        }

        Console.ResetColor();
    }

    public static void CalculateDiscriminant_CorrectInput_SingleRootsResult()
    {
        // Arrange
        double a = 1, b = -2, c = 1;
        double x1Expected = 1;
        string expectedMessage = "One real root (double root)."; 

        // Act
        var result = DiscriminantCalculator.CalculateDiscriminant(a, b, c);

        // Assert
        if (result.X1 == x1Expected && !result.X2.HasValue && result.Message == expectedMessage)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test passed");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Test failed");
        }

        Console.ResetColor();
    }

    public static void CalculateDiscriminant_CorrectInput_NoResults()
    {
        // Arrange
        double a = 1, b = 1, c = 1;
        string expectedMessage = "No real roots.";

        // Act
        var result = DiscriminantCalculator.CalculateDiscriminant(a, b, c);

        // Assert
        if (!result.X1.HasValue && !result.X2.HasValue && result.Message == expectedMessage)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test passed");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Test failed");
        }

        Console.ResetColor();
    }
}
