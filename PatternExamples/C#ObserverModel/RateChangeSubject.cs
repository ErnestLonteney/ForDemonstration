using System;
using System.Collections.Generic;
using System.Text;

namespace C_ObserverModel
{
    internal class RateChangeSubject
    {
        private EventHandler<RateChangedEventArgs> _rateChanger;
        public event EventHandler<RateChangedEventArgs> RateChanged
        {
            add { _rateChanger += value; }
            remove { _rateChanger -= value; }
        }

        public decimal Rate
        {
            get { return field; }
            set
            {
                if (field != value)
                {
                    field = value;
                    _rateChanger?.Invoke(this, new RateChangedEventArgs(Rate));
                }
            }
        }
    }
}
