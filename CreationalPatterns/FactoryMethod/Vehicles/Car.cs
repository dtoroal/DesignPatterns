using DesignPatterns.CreationalPatterns.FactoryMethod;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Vehicles;

internal class Car : IVehicle
{
    public void DoSomething()
    {
        Console.WriteLine("I'm a car");
    }
}
