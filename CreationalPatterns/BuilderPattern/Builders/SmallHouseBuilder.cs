using DesignPatterns.CreationalPatterns.BuilderPattern;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Builders;
internal class SmallHouseBuilder : HouseBuilder
{
    public override void BuildDoors()
    {
        if (house != null)
        {
            house.Doors = 8;
        }
    }

    public override void BuildRooms()
    {
        if (house != null)
        {
            house.Rooms = 4;
        }
    }

    public override void BuildWindows()
    {
        if (house != null)
        {
            house.Windows = 7;
        }
    }
}
