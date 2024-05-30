using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.AbstractFactory.BikeGroup;
using DesignPatterns.CreationalPatterns.AbstractFactory.VehicleGroup;
using DesignPatterns.CreationalPatterns.BuilderPattern;
using DesignPatterns.CreationalPatterns.BuilderPattern.Builders;
using DesignPatterns.CreationalPatterns.BuilderPattern.Model;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using DesignPatterns.StructuralPatterns.AdapterPattern;
using DesignPatterns.StructuralPatterns.BridgePattern;
using DesignPatterns.StructuralPatterns.DecoratorPattern;


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


// Builder Pattern
Console.WriteLine("------ Builder Pattern ------");
Director director = new();
HouseBuilder houseBuilder;

// Building a big house
houseBuilder = new BigHouseBuilder();
director.SetHouseBuilder(houseBuilder);
director.BuildHouse();
HouseModel? bigHouse = houseBuilder.GetHouse();
if (bigHouse != null)
{
    bigHouse.ShowHouse();
}

// Building a small house
houseBuilder = new SmallHouseBuilder();
director.SetHouseBuilder(houseBuilder);
houseBuilder.BuildHouse();
HouseModel? smallHouse = houseBuilder.GetHouse();
if (smallHouse != null)
{
    smallHouse.ShowHouse();
}


// Adapater Pattern

Console.WriteLine("------ Adapter Pattern ------");

IEmail adapter =  new EmailAdapter();
ClientAdapter clientAdapter = new (adapter);

clientAdapter.SendAnEmail("Someone", "Email subject", "Some text...");



// Bridge Pattern

Console.WriteLine("------ Bridge Pattern ------");

Shape desktopShape = new BridgeShape(new DesktopDrawer());
desktopShape.Draw();

Shape MobileShape = new BridgeShape(new MobileDrawer());
MobileShape.Draw();


// Decorator Pattern

Console.WriteLine("------ Decorator Pattern ------");

ICoffee simpleCoffee = new Coffee();
Console.WriteLine(simpleCoffee.DoCoffee());

ICoffee milkCoffee = new Milk(simpleCoffee);
Console.WriteLine(milkCoffee.DoCoffee());

ICoffee sugarCoffee = new Sugar(simpleCoffee);
Console.WriteLine(sugarCoffee.DoCoffee());

ICoffee sugarAndMilkCoffee = new Sugar(new Milk(simpleCoffee));
Console.WriteLine(sugarAndMilkCoffee.DoCoffee());