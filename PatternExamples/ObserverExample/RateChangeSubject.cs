using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    internal abstract class RateChangeSubject
    {
       public abstract void Attach(RateChangeObserver newSubscriber);

       public abstract void Detach(RateChangeObserver subscriber);
           
       public abstract void Notify();

    }
}
