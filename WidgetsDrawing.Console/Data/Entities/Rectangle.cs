namespace WidgetsDrawing.Console.Data.Entities;

public class Rectangle : Widget
{
    public int Width { get; init; }
    public int Height { get; init; }

    public override void PrintDetails()
    {
        System.Console.WriteLine($"Rectangle ({X},{Y}) width={Width} height={Height}");
    }
}