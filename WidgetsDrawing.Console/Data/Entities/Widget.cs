namespace WidgetsDrawing.Console.Data.Entities;

public abstract class Widget
{
    public int X { get; init; }
    public int Y { get; init; }
    
    public abstract void PrintDetails();
}