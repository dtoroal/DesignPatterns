namespace DesignPatterns.StructuralPatterns.DecoratorPattern;

internal class Milk : CoffeeDecorator
{
    public Milk(ICoffee coffee) : base(coffee) { }

    public override string DoCoffee()
    {
        return $"{base.DoCoffee()} with milk";
    }
}
