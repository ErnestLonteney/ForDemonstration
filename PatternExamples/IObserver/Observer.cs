using System;
using System.Collections.Generic;
using System.Text;

namespace IObserver
{
    internal class Observer : IObserver<RateChangedEventArgs>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(RateChangedEventArgs value)
        {
            throw new NotImplementedException();
        }
    {
    }
}
