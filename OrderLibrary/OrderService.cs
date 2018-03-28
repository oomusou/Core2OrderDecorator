using System;

namespace OrderLibrary
{
    public class OrderService
    {
        public double GetPrice(double price)
        {
            if (price < 1000)
            {
                Func<double, double> calculateDiscountPrice = PriceComponent.CalculateDiscountPrice; 
                return calculateDiscountPrice(price);
            }
            else
            {
                Func<double, double> calculateDiscountPrice = PriceComponent.CalculateDiscountPrice;
                Func<double, double> calculateRebatePrice = PriceDecorator.CalculateRebatePrice(calculateDiscountPrice);
                
                return calculateRebatePrice(price);
            }
        }
    }
}