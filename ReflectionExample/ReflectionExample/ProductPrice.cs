using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    struct ProductPrice
    {
        public decimal PriceWithDiscount { get; set; }
        public decimal PriceInMainStore { get; set; }
        public decimal StoragePrice { get; set; }
    }
}
