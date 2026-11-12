using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    internal class ShopPrice : Price
    {
        public decimal DeliveryPrice { get; set; }

        public decimal ReservationPrice { get; set; }

        public decimal PriceInMainStore { get; set; }
    }
}
