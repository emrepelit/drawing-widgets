namespace WidgetsDrawing.Console.Data.Entities;

public class Circle : Widget
{
    public int Size { get; init; }

    public override void PrintDetails()
    {
        System.Console.WriteLine($"Circle ({X},{Y}) size={Size}");
    }
}