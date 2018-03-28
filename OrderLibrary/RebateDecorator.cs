namespace OrderLibrary
{
    public class RebateDecorator: AbstractDecorator
    {
        public RebateDecorator(PriceInterface component) : base(component)
        {
        }

        public override double calculatePrice(double price)
        {
            return _component.calculatePrice(price) - 100;
        }
    }
}