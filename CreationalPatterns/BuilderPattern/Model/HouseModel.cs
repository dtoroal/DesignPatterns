namespace DesignPatterns.CreationalPatterns.BuilderPattern.Model;

internal class HouseModel
{
    public int Doors { get; set; }
    public int Windows { get; set; }
    public int Rooms { get; set; }

    public void ShowHouse()
    {
        Console.WriteLine($"This house has ${Doors} doors, ${Windows} and ${Rooms} rooms");
    }
}
