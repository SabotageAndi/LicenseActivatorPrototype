using System;
using Avalonia;
using LicenseActivatorPrototype.Views;
using LicenseActivatorPrototype.ViewModels;

namespace LicenseActivatorPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .Start<MainWindow>(GetDataContext);
        }

        private static object GetDataContext()
        {
            return new MainViewModel();
        }
    }
}
