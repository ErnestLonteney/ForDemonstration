using System;
using System.Collections.Generic;
using System.Text;

namespace MementoExample
{
    internal class StorageBack
    {
        public DateTime DateOfPacking { get; set; }

        public string[] Items { get; set; } = [];

        public byte Level { get; set; }

        public TypeHero Type { get; set; }
    }
}
