using System.Collections.Generic;
using CustomerManagement.Model;

namespace CustomerManagement.Application
{
    public interface ICustomerApplication
    {
        IEnumerable<Customer> List();
    }
}
