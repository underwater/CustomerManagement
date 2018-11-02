using System.Collections.Generic;
using CustomerManagement.Application;
using CustomerManagement.Model;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Web
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        public CustomerController(ICustomerApplication customerApplication)
        {
            CustomerApplication = customerApplication;
        }

        private ICustomerApplication CustomerApplication { get; }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return CustomerApplication.List();
        }
    }
}
