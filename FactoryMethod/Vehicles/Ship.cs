namespace PatternDesign.FactoryMethod;
internal class Ship: IVehicle
{
    public void DoSomething() 
    {
        Console.WriteLine("I'm a ship");
    }
}
