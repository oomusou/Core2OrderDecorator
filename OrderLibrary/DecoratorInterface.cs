namespace OrderLibrary
{
    public interface DecoratorInterface
    {
        PriceInterface Decorate(PriceInterface component);
    }
}