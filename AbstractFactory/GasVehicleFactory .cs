namespace PatternDesign.AbstractFactory;

internal class GasVehicleFactory : IVehicleFactory
{
    public IBike CreateBike()
    {
        return new GasBike();
    }

    public ICar CreateCar()
    {
        return new GasCar();
    }
}
