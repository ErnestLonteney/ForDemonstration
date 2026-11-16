namespace C_ObserverModel
{
    internal class RateChangedEventArgs : EventArgs
    {
        public RateChangedEventArgs(decimal rate)
        {
            Rate = rate;
        }

        public decimal Rate { get; }
    }
}