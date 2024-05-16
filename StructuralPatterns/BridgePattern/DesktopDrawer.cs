namespace DesignPatterns.StructuralPatterns.BridgePattern;

internal class DesktopDrawer : IDrawer
{
    public void DrawCircle()
    {
        Console.WriteLine("Drawing a desktop circle shape");
    }

    public void DrawSquare()
    {
        Console.WriteLine("Drawing a desktop square shape");
    }
}
