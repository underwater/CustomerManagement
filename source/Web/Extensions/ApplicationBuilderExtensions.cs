using CustomerManagement.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;

namespace CustomerManagement.Web.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        private static IHostingEnvironment Environment { get; } = DependencyInjector.GetService<IHostingEnvironment>();

        public static void UseSpa(this IApplicationBuilder application)
        {
            application.UseSpa(spa =>
            {
                spa.Options.SourcePath = "Frontend";

                if (Environment.IsDevelopment())
                {
                    spa.UseAngularCliServer("serve");
                }
            });
        }
    }
}
