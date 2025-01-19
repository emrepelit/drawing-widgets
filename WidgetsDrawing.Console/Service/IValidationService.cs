using WidgetsDrawing.Console.Core.Entities;

namespace WidgetsDrawing.Console.Service;

public interface IValidationService
{
    void ValidateWidgetProperties(WidgetTypeEnum type, Dictionary<string, int> properties);
}