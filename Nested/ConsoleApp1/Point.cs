﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Point
    {
        public Point(int x, int y)
        {
            X = x;   
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }  
    }
}
