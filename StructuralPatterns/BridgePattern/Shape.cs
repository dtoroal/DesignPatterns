namespace DesignPatterns.StructuralPatterns.BridgePattern;

internal abstract class Shape
{
    protected IDrawer _drawer;

    protected Shape(IDrawer drawer)
    {
        _drawer = drawer;
    }

    public abstract void Draw();
}
