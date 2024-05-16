using DesignPatterns.CreationalPatterns.FactoryMethod;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Vehicles;
internal class Ship : IVehicle
{
    public void DoSomething()
    {
        Console.WriteLine("I'm a ship");
    }
}
