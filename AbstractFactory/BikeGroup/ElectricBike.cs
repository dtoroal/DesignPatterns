namespace PatternDesign.AbstractFactory;

internal class ElectricBike : IBike
{
    public void DoSomethingBike()
    {
        Console.WriteLine("Start electric bike");
    }
}
