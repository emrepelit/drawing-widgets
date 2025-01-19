using WidgetsDrawing.Console.Data.Repositories;
using WidgetsDrawing.Console.Service.Factories;
using WidgetsDrawing.Console.Service;

namespace WidgetsDrawing.Console.Application.Commands;

public class AddWidgetCommandHandler(
    IWidgetFactory factory,
    IWidgetRepository repository,
    IValidationService validationService)
{
    public void Handle(AddWidgetCommand command)
    {
        validationService.ValidateWidgetProperties(command.Type, command.Properties);
        var widget = factory.CreateWidget(command.Type.ToString(), command.Properties, command.Text);
        repository.AddWidget(widget);
    }
}