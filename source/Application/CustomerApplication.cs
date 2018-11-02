using System.Collections.Generic;
using CustomerManagement.Domain;
using CustomerManagement.Model;

namespace CustomerManagement.Application
{
    public sealed class CustomerApplication : ICustomerApplication
    {
        public CustomerApplication(ICustomerDomain customerDomain)
        {
            CustomerDomain = customerDomain;
        }

        private ICustomerDomain CustomerDomain { get; }

        public IEnumerable<Customer> List()
        {
            return CustomerDomain.List();
        }
    }
}
