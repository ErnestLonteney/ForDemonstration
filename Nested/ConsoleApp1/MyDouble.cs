using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct MyDouble
    {
        public int MainPart { get; set; }
        public int Extension { get; set; }

        public MyDouble(int mainPart, int extension)
        {
           MainPart = mainPart; 
           Extension = extension;
        }

        public string Value => $"{MainPart}.{Extension}";
    }
}
