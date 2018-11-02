using System;
using System.Linq;
using CustomerManagement.Model;

namespace CustomerManagement.Database
{
    public static class DatabaseContextExtensions
    {
        public static void Seed(this DatabaseContext databaseContext)
        {
            if (databaseContext.Set<Customer>().Any())
            {
                return;
            }

            for (var i = 1; i <= 10; i++)
            {
                databaseContext.Set<Customer>().Add(new Customer
                {
                    Id = i,
                    Name = $"Name {i}",
                    DateOfBirth = new DateTime(1980 + i, 1 + i, 2 * i),
                    Salary = 100000 * i
                });

                databaseContext.SaveChanges();
            }
        }
    }
}
