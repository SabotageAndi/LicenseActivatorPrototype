using Avalonia;
using Avalonia.Markup.Xaml;

namespace LicenseActivatorPrototype
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}