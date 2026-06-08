using System;
using System.Collections.Generic;
using System.Text;

namespace BookExample
{
    internal class Page
    {
        public int Number { get; }

        public string? Text { get; init; }

        public byte[]? Image { get; set; }

        public Page(int number)
        {
             Number = number;
        }
    }
}
