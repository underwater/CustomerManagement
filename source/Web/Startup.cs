using CustomerManagement.Web.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerManagement.Web
{
    public class Startup
    {
        public void Configure(IApplicationBuilder application)
        {
            application.UseStaticFiles();
            application.UseSpaStaticFiles();
            application.UseMvcWithDefaultRoute();
            application.UseSpa();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependencyInjection();
            services.AddMvcJson();
            services.AddSpaStaticFiles();
        }
    }
}
