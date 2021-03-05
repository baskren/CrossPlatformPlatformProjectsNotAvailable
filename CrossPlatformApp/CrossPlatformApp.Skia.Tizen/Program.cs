using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace CrossPlatformApp.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new CrossPlatformApp.App(), args);
            host.Run();
        }
    }
}
