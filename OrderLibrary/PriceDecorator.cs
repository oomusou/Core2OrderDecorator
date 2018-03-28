using System;

namespace OrderLibrary
{
    public class PriceDecorator
    {
        public static Func<double, double> CalculateRebatePrice(Func<double, double> fn)
        {
            return price => fn(price) - 100;
        }
    }
}