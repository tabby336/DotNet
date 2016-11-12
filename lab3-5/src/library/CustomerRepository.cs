using System.Collections.Generic;
using System.Linq;

namespace DataLayer 
{
    public class CustomerRepository
    {
        private readonly ProductManagement Customers;

        public CustomerRepository()
        {
            Customers = new ProductManagement();
        }

        public IEnumerable<Customer> GetCustomersByEmail(string email)
        {
            return Customers.Customers.Where(custom => custom.Email == email);
        }
    }
}