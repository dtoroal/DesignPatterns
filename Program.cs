using PatternDesign.AbstractFactory;
using PatternDesign.FactoryMethod;

// Factory Method
Console.WriteLine("------ Factory Method ------");
var factoryMethod = new FactoryMethod();

IVehicle car = factoryMethod.CreateVehicle("CAR");
car.DoSomething();

IVehicle ship = factoryMethod.CreateVehicle("SHIP");
ship.DoSomething();


// Abstact Factory
Console.WriteLine("------ Abstract Factory ------");

ICar electricCar = new ElectricVehicleFactory().CreateCar();
electricCar.DoSomethingCar();

IBike electricBike = new ElectricVehicleFactory().CreateBike();
electricBike.DoSomethingBike();


ICar gasCar = new GasVehicleFactory().CreateCar();
gasCar.DoSomethingCar();

IBike gasBike = new GasVehicleFactory().CreateBike();
gasBike.DoSomethingBike();

