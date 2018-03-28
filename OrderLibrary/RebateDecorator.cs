namespace OrderLibrary
{
    public class RebateDecorator: AbstractDecorator
    {
        public override double calculatePrice(double price)
        {
            return _component.calculatePrice(price) - 100;
        }
    }
}