using System;

namespace ConsoleApp
{
    public class OrderService
    {
        public double CalculatePrice(Func<double, bool> discountPredicate)
        {
            var price = 2000.0;

            if (discountPredicate(price))
            {
                return price - 100.0;
            }
            else
            {
                return price;
            }
        }
    }
}