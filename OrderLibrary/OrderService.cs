using System;

namespace OrderLibrary
{
    public class OrderService
    {
        public double GetPrice(double price)
        {
            if (price < 1000)
            {
                PriceInterface discountComponent = new DiscountComponent();
                return discountComponent.calculatePrice(price);
            }
            else
            {
                PriceInterface discountComponent = new DiscountComponent();
                var rebateDecorator = new RebateDecorator().Decorate(discountComponent);
                
                return rebateDecorator.calculatePrice(price);
            }
        }
    }
}