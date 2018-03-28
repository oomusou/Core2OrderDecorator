namespace OrderLibrary
{
    public class DiscountComponent : PriceInterface
    {
        public double calculatePrice(double price)
        {
            return price * 0.8;
        }
    }
}