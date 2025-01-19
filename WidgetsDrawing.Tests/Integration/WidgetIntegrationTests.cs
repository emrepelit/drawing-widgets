using WidgetsDrawing.Console.Application.Commands;
using WidgetsDrawing.Console.Application.Controllers;
using WidgetsDrawing.Console.Application.Queries;
using WidgetsDrawing.Console.Core.Entities;
using WidgetsDrawing.Console.Data.Repositories;
using WidgetsDrawing.Console.Service.Factories;
using WidgetsDrawing.Console.Service;
using Xunit;

namespace WidgetsDrawing.Tests.Integration;

public class WidgetIntegrationTests
{
    private readonly WidgetController _controller;

    public WidgetIntegrationTests()
    {
        var factory = new WidgetFactory();
        var repository = new WidgetRepository();
        var validationService = new ValidationService();

        var addHandler = new AddWidgetCommandHandler(factory, repository, validationService);
        var queryHandler = new GetWidgetsQueryHandler(repository);

        _controller = new WidgetController(addHandler, queryHandler);
    }

    [Fact]
    public void AddAndRetrieveWidgets_Success()
    {
        _controller.AddWidget(WidgetTypeEnum.Rectangle, new Dictionary<string, int>
        {
            { "X", 10 }, { "Y", 10 }, { "Width", 30 }, { "Height", 40 }
        });

        _controller.AddWidget(WidgetTypeEnum.Square, new Dictionary<string, int>
        {
            { "X", 15 }, { "Y", 30 }, { "Size", 35 }
        });

        var widgets = _controller.GetWidgets();

        Assert.Equal(2, widgets.Count());
    }

    [Fact]
    public void AddInvalidWidget_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
            _controller.AddWidget(WidgetTypeEnum.Rectangle, new Dictionary<string, int>
            {
                //missing width and height:
                { "X", 10 }, { "Y", 10 }
            }));
    }
}