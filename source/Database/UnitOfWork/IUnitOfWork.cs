using CustomerManagement.Database.Repositories;

namespace CustomerManagement.Database
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }

        void SaveChanges();
    }
}
