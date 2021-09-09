using Microsoft.AspNetCore.Hosting;

namespace NorthWind.Areas.Identity.Pages
{
    public class IdentityHostingStartup: IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}