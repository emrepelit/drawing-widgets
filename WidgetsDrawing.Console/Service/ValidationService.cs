using WidgetsDrawing.Console.Core.Entities;

namespace WidgetsDrawing.Console.Service;

public class ValidationService : IValidationService
{
    public void ValidateWidgetProperties(WidgetTypeEnum type, Dictionary<string, int> properties)
    {
        if (properties == null || properties.Count == 0)
        {
            throw new ArgumentException("Properties cannot be null or empty.");
        }

        switch (type)
        {
            case WidgetTypeEnum.Rectangle:
            case WidgetTypeEnum.Textbox:
                if (!properties.ContainsKey("Width") || !properties.ContainsKey("Height"))
                {
                    throw new ArgumentException("Rectangle or Textbox must have Width and Height.");
                }
                break;
            case WidgetTypeEnum.Square:
                if (!properties.ContainsKey("Size"))
                {
                    throw new ArgumentException("Square must have Size.");
                }
                break;
            case WidgetTypeEnum.Ellipse:
                if (!properties.ContainsKey("HorizontalDiameter") || !properties.ContainsKey("VerticalDiameter"))
                {
                    throw new ArgumentException("Ellipse must have HorizontalDiameter and VerticalDiameter.");
                }
                break;
            case WidgetTypeEnum.Circle:
                if (!properties.ContainsKey("Size"))
                {
                    throw new ArgumentException("Circle must have Size.");
                }
                break;
            default:
                throw new ArgumentException("Invalid WidgetType.");
        }
    }
}