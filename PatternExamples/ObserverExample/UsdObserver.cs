using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    internal class UsdObserver(UsdRateSubject rateChangeSubject) : RateChangeObserver(rateChangeSubject)
    {
        public override decimal CurrentRate { get; protected set; }

        public override void Update(decimal rate)
        {
            Console.WriteLine("USD rate has changed.");
            CurrentRate = rate;
            Console.WriteLine(CurrentRate);
        }
    }
}
