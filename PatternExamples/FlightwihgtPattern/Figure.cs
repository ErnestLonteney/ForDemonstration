using System;
using System.Collections.Generic;
using System.Text;

namespace FlightwihgtPattern
{
    abstract class Figure
    {
        public CheckColors Color { get; set; }

        protected Figure(CheckColors color)
        {
            Color = color;
        }

        public FigureSize Size { get; set; }
    }
}
