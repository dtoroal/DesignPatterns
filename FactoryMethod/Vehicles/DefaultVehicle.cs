namespace PatternDesign.FactoryMethod;

internal class DefaultVehicle : IVehicle
{
    public void DoSomething()
    {
        Console.WriteLine("I'm a default vehicle");
    }
}
