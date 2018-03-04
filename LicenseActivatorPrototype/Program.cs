using System;
using Avalonia;
using LicenseActivatorPrototype.Views;

namespace LicenseActivatorPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .Start<MainWindow>();
        }
    }
}
