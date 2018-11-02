using System;

namespace CustomerManagement.Model
{
    public class Customer
    {
        public DateTime DateOfBirth { get; set; }

        public long Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }
    }
}
