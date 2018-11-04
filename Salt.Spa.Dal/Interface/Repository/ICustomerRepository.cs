using Salt.Spa.Dal.Entity;
using System.Collections.Generic;

namespace Salt.Spa.Dal.Interface
{
    public interface ICustomerRepository
    {
        Customer FindByCustomerId(int customerId);
        IEnumerable<Customer> FindByLastName(string lastName);
        IEnumerable<Customer> FindByPhone(string phone);
    }
}
