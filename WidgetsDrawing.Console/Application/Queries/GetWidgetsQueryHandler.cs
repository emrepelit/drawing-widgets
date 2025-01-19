using WidgetsDrawing.Console.Data.Entities;
using WidgetsDrawing.Console.Data.Repositories;

namespace WidgetsDrawing.Console.Application.Queries;

public class GetWidgetsQueryHandler(IWidgetRepository repository)
{
    public IEnumerable<Widget> Handle(GetWidgetsQuery? query)
    {
        //TODO: We could add more detailed logic here using actual query.
        return repository.GetAllWidgets();
    }
}