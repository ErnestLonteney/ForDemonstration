using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeExample
{
    internal class PriceCalculator
    {
        public decimal CalculatePrice(Order order)
        {
            switch (order.ProductName.ToLower())
            {
                case "product1":
                    return 10.0m * order.Qty;
                case "product2":
                    return 20.0m * order.Qty;
                case "product3":
                    return 30.0m * order.Qty;
                default:
                    throw new ArgumentException("Invalid product name");
            }

            return 0.0m; // Placeholder return value
        }
    }
}
