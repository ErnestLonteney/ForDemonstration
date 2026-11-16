using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    internal abstract class RateChangeObserver
    {
        private RateChangeSubject RateChangeSubject;

        public abstract decimal CurrentRate { get; protected set; }

        protected RateChangeObserver(RateChangeSubject rateChangeSubject)
        {
            RateChangeSubject = rateChangeSubject;
        }

        public abstract void Update(decimal rate);
    }
}
