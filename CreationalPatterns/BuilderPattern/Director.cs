using DesignPatterns.CreationalPatterns.BuilderPattern.Model;

namespace DesignPatterns.CreationalPatterns.BuilderPattern;

internal class Director
{
    private HouseBuilder? _houseBuilder;

    public void SetHouseBuilder(HouseBuilder houseBuilder)
    {
        _houseBuilder = houseBuilder;
    }

    public HouseModel? GetHouse()
    {
        return _houseBuilder?.GetHouse();
    }

    public void BuildHouse()
    {
        _houseBuilder?.BuildHouse();
        _houseBuilder?.BuildWindows();
        _houseBuilder?.BuildRooms();
        _houseBuilder?.BuildDoors();
    }
}
