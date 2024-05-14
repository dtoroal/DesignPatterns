namespace PatternDesign.AbstractFactory;

internal interface IVehicleFactory
{
    ICar CreateCar();
    IBike CreateBike();
}
