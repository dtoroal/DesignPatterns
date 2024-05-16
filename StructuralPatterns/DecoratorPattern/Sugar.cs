namespace DesignPatterns.StructuralPatterns.DecoratorPattern;

internal class Sugar : CoffeeDecorator
{
    public Sugar(ICoffee coffee) : base(coffee) { }

    public override string DoCoffee()
    {
        return $"{base.DoCoffee()} with sugar";
    }
}
