using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    struct Point 
    {
        private int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                this.x = value;
                IsEmpty = true;
            }
        }
        public int Y { get; set; }
        public int Z { get; set; }

        public bool IsEmpty { get; private set; } = true;

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
            IsEmpty = false;
        }
    }
}
