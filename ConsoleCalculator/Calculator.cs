namespace CalculatorGeneric
{
    static class Calculator 
    {
        public static EventHandler DivideByZero = null;
        public static double Add(double operand1, double operand2) => operand1 + operand2;

        public static double Substruct(double operand1, double operand2) => operand1 - operand2;

        public static double Multiply(double operand1, double operand2) => operand1 * operand2;

        public static double? Divide(double operand1, double operand2)
        {
            if (operand2 == 0)
            {
                DivideByZero.Invoke(null, null);
                return null;                   
            }

            return operand1 / operand2;
        }      
    }
}
