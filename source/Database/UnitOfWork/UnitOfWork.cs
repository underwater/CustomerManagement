using CustomerManagement.Database.Repositories;

namespace CustomerManagement.Database
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(DatabaseContext context, ICustomerRepository customerRepository)
        {
            Context = context;
            Context.Seed();
            CustomerRepository = customerRepository;
        }

        public ICustomerRepository CustomerRepository { get; }

        private DatabaseContext Context { get; }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
