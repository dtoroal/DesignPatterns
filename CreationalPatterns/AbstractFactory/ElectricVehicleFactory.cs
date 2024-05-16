using DesignPatterns.CreationalPatterns.AbstractFactory.BikeGroup;
using DesignPatterns.CreationalPatterns.AbstractFactory.VehicleGroup;

namespace DesignPatterns.CreationalPatterns.AbstractFactory;

internal class ElectricVehicleFactory : IVehicleFactory
{
    public IBike CreateBike()
    {
        return new ElectricBike();
    }

    public ICar CreateCar()
    {
        return new ElectricCar();
    }
}
