namespace CoAndContrVariants
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetSquare()
        {
            return Math.Sqrt(Radius) / 2;   
        }
    }
}
