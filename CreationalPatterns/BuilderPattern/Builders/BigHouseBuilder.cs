using DesignPatterns.CreationalPatterns.BuilderPattern;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Builders;
internal class BigHouseBuilder : HouseBuilder
{
    public override void BuildDoors()
    {
        if (house != null)
        {
            house.Doors = 12;
        }
    }

    public override void BuildRooms()
    {
        if (house != null)
        {
            house.Rooms = 8;
        }
    }

    public override void BuildWindows()
    {
        if (house != null)
        {
            house.Windows = 14;
        }
    }
}
