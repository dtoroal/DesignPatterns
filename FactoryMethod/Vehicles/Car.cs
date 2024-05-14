namespace PatternDesign.FactoryMethod;

internal class Car : IVehicle
{
    public void DoSomething()
    {
        Console.WriteLine("I'm a car");
    }
}
