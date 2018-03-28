namespace OrderLibrary
{
    public abstract class AbstractDecorator: PriceInterface, DecoratorInterface
    {
        protected PriceInterface _component;

        public abstract double calculatePrice(double price);
        public PriceInterface Decorate(PriceInterface component)
        {
            _component = component;
            return this;
        }
    }
}