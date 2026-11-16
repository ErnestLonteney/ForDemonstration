namespace C_ObserverModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RateChangeSubject rateChangeSubject = new RateChangeSubject();

            UsdRateListener usdRateListener1 = new UsdRateListener(rateChangeSubject);
            UsdRateListener usdRateListener2 = new UsdRateListener(rateChangeSubject);

            rateChangeSubject.Rate = 44.23m;
            
            rateChangeSubject.RateChanged -= new EventHandler<RateChangedEventArgs>(usdRateListener2.RateChangeSubject_RateChanged);

            rateChangeSubject.Rate = 46.23m;
        }
    }
}
