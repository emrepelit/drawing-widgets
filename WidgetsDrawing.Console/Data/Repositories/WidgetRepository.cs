using WidgetsDrawing.Console.Data.Entities;

namespace WidgetsDrawing.Console.Data.Repositories;

public class WidgetRepository : IWidgetRepository
{
    private readonly List<Widget> _widgets = [];

    public void AddWidget(Widget widget)
    {
        _widgets.Add(widget);
    }

    public IEnumerable<Widget> GetAllWidgets()
    {
        return _widgets;
    }
}