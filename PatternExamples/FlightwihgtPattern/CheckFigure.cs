using System;
using System.Collections.Generic;
using System.Text;

namespace FlightwihgtPattern
{
    internal class CheckFigure : Figure
    {
        public string Name { get; } = string.Empty;

        public CheckFigure(string name, CheckColors color) : base(color)
        {
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine($"CheckFigure {Name} of color {Color} is moving.");
        }
    }
}
