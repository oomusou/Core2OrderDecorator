using System;

namespace OrderLibrary
{
    public class OrderService
    {
        public double GetPrice(double price)
        {
            if (price < 1000)
            {
                return price * 0.8;
            }
            else
            {
                return price * 0.8 - 100;
            }
        }
    }
}