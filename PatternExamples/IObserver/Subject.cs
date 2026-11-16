using System;
using System.Collections.Generic;
using System.Text;

namespace IObserver
{
    internal class Subject : IObservable<RateChangedEventArgs>
    {
        public IDisposable Subscribe(IObserver<RateChangedEventArgs> observer)
        {
            throw new NotImplementedException();
        }
    }
}
