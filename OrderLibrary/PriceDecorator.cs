namespace OrderLibrary
{
    public class PriceDecorator
    {
        public static PriceDelegate CalculateRebatePrice(PriceDelegate fn)
        {
            return price => fn(price) - 100;
        }
    }
}