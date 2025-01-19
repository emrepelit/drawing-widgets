using WidgetsDrawing.Console.Data.Entities;

namespace WidgetsDrawing.Console.Data.Repositories;

public interface IWidgetRepository
{
    void AddWidget(Widget widget);
    IEnumerable<Widget> GetAllWidgets();
}