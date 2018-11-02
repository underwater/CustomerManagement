using CustomerManagement.Model;

namespace CustomerManagement.Database.Repositories
{
    public sealed class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
