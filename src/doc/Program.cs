using System.IO;
using System.Reflection;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Skittles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseContentRoot(WebRootPath())
                .UseWebRoot(WebRootPath())
                .UseStartup<Startup>();

        private static string WebRootPath() =>
            Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "..\\..");
    }
}
