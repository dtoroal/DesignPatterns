namespace DesignPatterns.StructuralPatterns.BridgePattern;

internal class BridgeShape : Shape
{

    public BridgeShape(IDrawer drawer) : base(drawer) { }

    public override void Draw()
    {
        _drawer.DrawSquare();
    }
}
