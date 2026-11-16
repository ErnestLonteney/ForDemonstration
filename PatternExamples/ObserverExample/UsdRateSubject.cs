using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    internal class UsdRateSubject : RateChangeSubject
    {
        private List<RateChangeObserver> _subscribers = [];

        public decimal Rate
        {
            get { return field; }
            set
            {
                if (field != value)
                {
                    field = value;
                    Notify();
                }
            }
        }

        public override void Attach(RateChangeObserver newSubscriber)
        {
            _subscribers.Add(newSubscriber);
        }

        public override void Detach(RateChangeObserver subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public override void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(Rate);
            }
        }   
    }
}
