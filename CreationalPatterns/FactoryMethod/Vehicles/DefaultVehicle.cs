using DesignPatterns.CreationalPatterns.FactoryMethod;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Vehicles;

internal class DefaultVehicle : IVehicle
{
    public void DoSomething()
    {
        Console.WriteLine("I'm a default vehicle");
    }
}
