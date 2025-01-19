using WidgetsDrawing.Console.Application.Commands;
using WidgetsDrawing.Console.Application.Queries;
using WidgetsDrawing.Console.Core.Entities;
using WidgetsDrawing.Console.Data.Entities;

namespace WidgetsDrawing.Console.Application.Controllers;

public class WidgetController(AddWidgetCommandHandler addHandler, GetWidgetsQueryHandler queryHandler)
{
    public void AddWidget(WidgetTypeEnum type, Dictionary<string, int> properties, string? text = null)
    {
        var command = new AddWidgetCommand
        {
            Type = type,
            Properties = properties,
            Text = text
        };
        
        addHandler.Handle(command);
    }

    public IEnumerable<Widget> GetWidgets()
    {
        var query = new GetWidgetsQuery();
        
        return queryHandler.Handle(query);
    }
}