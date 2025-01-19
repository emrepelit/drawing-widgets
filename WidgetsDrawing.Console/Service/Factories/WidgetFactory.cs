using WidgetsDrawing.Console.Data.Entities;

namespace WidgetsDrawing.Console.Service.Factories;

public class WidgetFactory : IWidgetFactory
{
    public Widget CreateWidget(string type, Dictionary<string, int> properties, string? text = null)
    {
        return type switch
        {
            "Rectangle" => new Rectangle
            {
                X = properties["X"],
                Y = properties["Y"],
                Width = properties["Width"],
                Height = properties["Height"]
            },
            "Square" => new Square
            {
                X = properties["X"],
                Y = properties["Y"],
                Size = properties["Size"]
            },
            "Ellipse" => new Ellipse
            {
                X = properties["X"],
                Y = properties["Y"],
                HorizontalDiameter = properties["HorizontalDiameter"],
                VerticalDiameter = properties["VerticalDiameter"]
            },
            "Circle" => new Circle
            {
                X = properties["X"],
                Y = properties["Y"],
                Size = properties["Size"]
            },
            "Textbox" => new Textbox
            {
                X = properties["X"],
                Y = properties["Y"],
                Width = properties["Width"],
                Height = properties["Height"],
                Text = text
            },
            _ => throw new ArgumentException("Invalid widget type")
        };
    }
}