using WidgetsDrawing.Console.Data.Entities;

namespace WidgetsDrawing.Console.Service.Factories;

public interface IWidgetFactory
{
    Widget CreateWidget(string type, Dictionary<string, int> properties, string? text = null);
}