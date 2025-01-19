using WidgetsDrawing.Console.Core.Entities;

namespace WidgetsDrawing.Console.Application.Commands;

public class AddWidgetCommand
{
    public WidgetTypeEnum Type { get; init; }
    public required Dictionary<string, int> Properties { get; init; }
    public string? Text { get; init; }
}