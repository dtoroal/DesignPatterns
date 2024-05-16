using DesignPatterns.CreationalPatterns.AbstractFactory.BikeGroup;
using DesignPatterns.CreationalPatterns.AbstractFactory.VehicleGroup;

namespace DesignPatterns.CreationalPatterns.AbstractFactory;

internal interface IVehicleFactory
{
    ICar CreateCar();
    IBike CreateBike();
}
