namespace DesignPatterns.StructuralPatterns.BridgePattern;

internal class MobileDrawer : IDrawer
{
    public void DrawCircle()
    {
        Console.WriteLine("Drawing a Mobile circle shape");
    }

    public void DrawSquare()
    {
        Console.WriteLine("Drawing a Mobile sqaure shape");
    }
}
