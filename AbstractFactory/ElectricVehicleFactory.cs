namespace PatternDesign.AbstractFactory;

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
