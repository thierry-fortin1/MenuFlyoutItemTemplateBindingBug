using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace MenuFlyoutItemTemplateBindingBug.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new MenuFlyoutItemTemplateBindingBug.App());
            host.Run();
        }
    }
}
