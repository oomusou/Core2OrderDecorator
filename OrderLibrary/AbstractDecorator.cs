namespace OrderLibrary
{
    public abstract class AbstractDecorator: PriceInterface
    {
        protected PriceInterface _component;

        protected AbstractDecorator(PriceInterface component)
        {
            _component = component;
        }
        
        public abstract double calculatePrice(double price);
    }
}