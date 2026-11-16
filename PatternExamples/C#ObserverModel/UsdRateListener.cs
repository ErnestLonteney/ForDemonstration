using System;
using System.Collections.Generic;
using System.Text;

namespace C_ObserverModel
{
    internal class UsdRateListener
    {
        public UsdRateListener(RateChangeSubject rateChangeSubject)
        {
            rateChangeSubject.RateChanged += RateChangeSubject_RateChanged;
        }

        public void RateChangeSubject_RateChanged(object sender, RateChangedEventArgs e)
        {
            Console.WriteLine($"USD rate changed to {e.Rate}");
        }
    }
}
