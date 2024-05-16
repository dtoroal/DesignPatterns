namespace DesignPatterns.StructuralPatterns.DecoratorPattern;

internal abstract class CoffeeDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string DoCoffee()
    {
        return _coffee.DoCoffee();
    }
}
