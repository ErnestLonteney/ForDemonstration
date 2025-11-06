namespace DiscriminantCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("TestCalculateDiscriminant-1 ");
            DiscriminantCalculatorTests.CalculateDiscriminant_CorrectInput_TwoRootsResult();

            Console.Write("TestCalculateDiscriminant-2 ");
            DiscriminantCalculatorTests.CalculateDiscriminant_CorrectInput_SingleRootsResult();

            Console.Write("TestCalculateDiscriminant-3 ");
            DiscriminantCalculatorTests.CalculateDiscriminant_CorrectInput_NoResults();
        }
    }
}