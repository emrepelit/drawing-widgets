using WidgetsDrawing.Console.Service.Factories;
using Xunit;

namespace WidgetsDrawing.Tests.Unit;

public class WidgetFactoryTests
{
    private readonly IWidgetFactory _factory = new WidgetFactory();

    [Fact]
    public void CreateWidget_Rectangle_ReturnsCorrectType()
    {
        var widget = _factory.CreateWidget("Rectangle", new Dictionary<string, int>
        {
            { "X", 10 }, { "Y", 10 }, { "Width", 30 }, { "Height", 40 }
        });

        Assert.Equal("Rectangle", widget.GetType().Name);
    }

    [Fact]
    public void CreateWidget_InvalidType_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            _factory.CreateWidget("InvalidType", new Dictionary<string, int>()));
    }
}