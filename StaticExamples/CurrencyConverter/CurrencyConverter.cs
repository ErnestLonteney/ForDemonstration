namespace ConsoleApp26
{
     static class CurrencyConverter
     {
        private static double dollarRate;
        private static double euroRate;

        static CurrencyConverter()
        {
            dollarRate = GetDollarRate();
            euroRate = GetEuroRate();
        }

        private static double GetDollarRate()
        {
            return 45; // call database
        }

        private static double GetEuroRate()
        {
            return 50; // call database
        }

        public static double DallarRate 
        {
            get => dollarRate;
            set => dollarRate = value;
        }

        public static double EuroRate
        {
            get => euroRate;
            set => euroRate = value;
        }


        public static double ConvertEuroToHrn(double sum)
        {
            return euroRate * sum;
        }

        public static double ConvertDollarsToHrn(double sum)
        {
            return dollarRate * sum;
        }

        public static double ConvertHrnToEuro(double sum)
        {
            if (euroRate == 0)
                return 0;   

            return sum / euroRate;
        }

        public static double ConvertHrnToDollars(double sum)
        {
            if (dollarRate == 0)
                return 0;

            return sum / dollarRate;
        }

    }
}
