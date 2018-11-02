using System.Collections.Generic;
using CustomerManagement.Model;

namespace CustomerManagement.Domain
{
    public interface ICustomerDomain
    {
        IEnumerable<Customer> List();
    }
}
