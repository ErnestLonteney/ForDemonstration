using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    struct Price
    {
        public decimal RawPrice { get; set; }
        public decimal LandedPrice { get; set; }
        public decimal DeliveryPrice { get; set; }
        public decimal StorePrice { get; set; }
    }
}
