using System.Collections.Generic;
using CustomerManagement.Database;
using CustomerManagement.Model;

namespace CustomerManagement.Domain
{
    public sealed class CustomerDomain : ICustomerDomain
    {
        public CustomerDomain(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        private IUnitOfWork UnitOfWork { get; }

        public IEnumerable<Customer> List()
        {
            return UnitOfWork.CustomerRepository.List();
        }
    }
}
