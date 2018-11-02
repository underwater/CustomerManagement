using CustomerManagement.Database;
using CustomerManagement.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace CustomerManagement.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            DependencyInjector.RegisterServices(services);
            DependencyInjector.AddDbContextInMemoryDatabase<DatabaseContext>();
        }

        public static void AddMvcJson(this IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(opt => opt.SerializerSettings.NullValueHandling = NullValueHandling.Ignore);
        }

        public static void AddSpaStaticFiles(this IServiceCollection services)
        {
            services.AddSpaStaticFiles(spa => spa.RootPath = "Frontend/dist");
        }
    }
}
