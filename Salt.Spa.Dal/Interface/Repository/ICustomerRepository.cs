using Salt.Spa.Dal.Entity;
using System.Collections.Generic;

namespace Salt.Spa.Dal.Interface
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> FindByLastName(string lastName);
        IEnumerable<Customer> FindByPhone(string phone);
    }
}
