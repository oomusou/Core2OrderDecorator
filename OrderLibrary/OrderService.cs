using System;

namespace OrderLibrary
{
    public class OrderService
    {
        public double GetPrice(double price)
        {
            if (price < 1000)
            {
                PriceDelegate calculateDiscountPrice = PriceComponent.CalculateDiscountPrice; 
                return calculateDiscountPrice(price);
            }
            else
            {
                PriceDelegate calculateDiscountPrice = PriceComponent.CalculateDiscountPrice;
                PriceDelegate calculateRebatePrice = PriceDecorator.CalculateRebatePrice(calculateDiscountPrice);
                
                return calculateRebatePrice(price);
            }
        }
    }
}