namespace WidgetsDrawing.Console.Data.Entities;

public class Square : Widget
{
    public int Size { get; init; }

    public override void PrintDetails()
    {
        System.Console.WriteLine($"Square ({X},{Y}) size={Size}");
    }
}