
namespace WidgetsDrawing.Console.Data.Entities;

public class Textbox : Widget
{
    public int Width { get; init; }
    public int Height { get; init; }
    public string? Text { get; init; }

    public override void PrintDetails()
    {
        System.Console.WriteLine($"Textbox ({X},{Y}) width={Width} height={Height} Text=\"{Text}\"");
    }
}