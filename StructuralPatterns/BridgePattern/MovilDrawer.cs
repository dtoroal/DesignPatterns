namespace DesignPatterns.StructuralPatterns.BridgePattern;

internal class MovilDrawer : IDrawer
{
    public void DrawCircle()
    {
        Console.WriteLine("Drawing a movil circle shape");
    }

    public void DrawSquare()
    {
        Console.WriteLine("Drawing a movil sqaure shape");
    }
}
