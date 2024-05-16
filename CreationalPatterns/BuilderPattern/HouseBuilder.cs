using DesignPatterns.CreationalPatterns.BuilderPattern.Model;

namespace DesignPatterns.CreationalPatterns.BuilderPattern;

internal abstract class HouseBuilder
{
    protected HouseModel? house;

    public HouseModel? GetHouse()
    {
        return house;
    }

    public void BuildHouse()
    {
        house = new HouseModel();
    }

    public abstract void BuildDoors();
    public abstract void BuildWindows();
    public abstract void BuildRooms();
}
