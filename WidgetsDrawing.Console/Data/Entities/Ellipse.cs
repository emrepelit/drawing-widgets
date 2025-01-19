namespace WidgetsDrawing.Console.Data.Entities;

public class Ellipse : Widget
{
    public int HorizontalDiameter { get; init; }
    public int VerticalDiameter { get; init; }

    public override void PrintDetails()
    {
        System.Console.WriteLine($"Ellipse ({X},{Y}) diameterH={HorizontalDiameter} diameterV={VerticalDiameter}");
    }
}