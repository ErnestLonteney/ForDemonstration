using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeSummuryColumn
{
    class Prices
    {
        public int ProductId { get; set; }
        public double RawPrice { get; set; }
        public double LandedPrice { get; set; }
        public double MedianPrice { get; set; }
        public double PurchasePrice { get; set; }
    }
}
