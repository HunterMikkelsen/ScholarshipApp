using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WCS
{
    public class Program
    {
        public static bool AllowStudentLogin { get; set; }

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .ConfigureKestrel((context, options) =>
            {
               // Set properties and call methods on options
             });
    }
}
