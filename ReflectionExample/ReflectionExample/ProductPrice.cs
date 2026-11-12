using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class ProductPrice : Price
    {
        public decimal PriceWithDiscount { get; set; }
        public decimal PriceWithLoyality { get; set; }
        public decimal NettoPrice { get; set; }

        public decimal PriceWithTax { get; set; }
    }
}
