namespace ObserverExample
{
    internal class Program
    {
        static void Main()
        {
           UsdRateSubject usdRateSubject = new();

           UsdObserver usdObserver1 = new (usdRateSubject);
           UsdObserver usdObserver2 = new (usdRateSubject);
           
            usdRateSubject.Rate = 44.23m;

           usdRateSubject.Attach(usdObserver1);
           usdRateSubject.Attach(usdObserver2);

           usdRateSubject.Rate = 45.23m;

           usdRateSubject.Detach(usdObserver2);

            usdRateSubject.Rate = 46.54m;
        }
    }
}
