using CustomerManagement.Application;
using CustomerManagement.Database;
using CustomerManagement.Database.Repositories;
using CustomerManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerManagement.DependencyInjection
{
    public static class DependencyInjector
    {
        private static IServiceCollection Services { get; set; }

        public static void AddDbContextInMemoryDatabase<T>() where T : DbContext
        {
            Services.AddDbContextPool<T>(options => options.UseInMemoryDatabase(typeof(T).Name));
        }

        public static T GetService<T>()
        {
            return Services.BuildServiceProvider().GetService<T>();
        }

        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            Services = services;

            Services.AddScoped<ICustomerApplication, CustomerApplication>();
            Services.AddScoped<ICustomerDomain, CustomerDomain>();
            Services.AddScoped<ICustomerRepository, CustomerRepository>();
            Services.AddScoped<IUnitOfWork, UnitOfWork>();

            return Services;
        }
    }
}
