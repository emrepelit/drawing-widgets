using Microsoft.Extensions.DependencyInjection;
using WidgetsDrawing.Console.Application.Commands;
using WidgetsDrawing.Console.Application.Controllers;
using WidgetsDrawing.Console.Application.Queries;
using WidgetsDrawing.Console.Core.Entities;
using WidgetsDrawing.Console.Data.Repositories;
using WidgetsDrawing.Console.Service.Factories;
using WidgetsDrawing.Console.Service;

namespace WidgetsDrawing.Console;

internal static class Program
    {
        private static void Main()
        {
            var serviceProvider = ConfigureServices();
            
            var app = serviceProvider.GetService<AppRunner>();
            app?.Run();
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            
            services.AddSingleton<IWidgetRepository, WidgetRepository>();
            services.AddSingleton<IWidgetFactory, WidgetFactory>();
            services.AddSingleton<IValidationService, ValidationService>();
            
            services.AddSingleton<AddWidgetCommandHandler>();
            services.AddSingleton<GetWidgetsQueryHandler>();
            
            services.AddSingleton<WidgetController>();
            services.AddSingleton<AppRunner>();

            return services.BuildServiceProvider();
        }
    }

    public class AppRunner(WidgetController controller)
    {
        public void Run()
        {
            controller.AddWidget(WidgetTypeEnum.Rectangle, new Dictionary<string, int>
            {
                { "X", 10 }, { "Y", 10 }, { "Width", 30 }, { "Height", 40 }
            });

            controller.AddWidget(WidgetTypeEnum.Square, new Dictionary<string, int>
            {
                { "X", 15 }, { "Y", 30 }, { "Size", 35 }
            });

            controller.AddWidget(WidgetTypeEnum.Ellipse, new Dictionary<string, int>
            {
                { "X", 100 }, { "Y", 150 }, { "HorizontalDiameter", 300 }, { "VerticalDiameter", 200 }
            });

            controller.AddWidget(WidgetTypeEnum.Circle, new Dictionary<string, int>
            {
                { "X", 1 }, { "Y", 1 }, { "Size", 300 }
            });

            controller.AddWidget(WidgetTypeEnum.Textbox, new Dictionary<string, int>
            {
                { "X", 5 }, { "Y", 5 }, { "Width", 200 }, { "Height", 100 }
            }, "sample text");
            
            System.Console.WriteLine("----------------------------------------------------------------");
            System.Console.WriteLine("Requested Drawing");
            System.Console.WriteLine("----------------------------------------------------------------");

            foreach (var widget in controller.GetWidgets())
            {
                widget.PrintDetails();
            }

            System.Console.WriteLine("----------------------------------------------------------------");
        }
    }