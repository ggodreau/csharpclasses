using System;

namespace Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    
    // this is not ShippingCalculator INHERITING IShippingCalculator
    // it is ShippingCalculator IMPLEMENTING IShippingCalculator

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                // shipping price is 10% of order purchase price
                return order.TotalPrice * 0.1f;
            
            // else free shipping
            return 0;
        }
    }
}
