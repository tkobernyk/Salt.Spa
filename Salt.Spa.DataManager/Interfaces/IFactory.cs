using System.Collections.Generic;

namespace Salt.Spa.DataManager.Interfaces
{
    public interface IFactory<T> where T : IDto
    {
        IEnumerable<T> GetOrCreateCustomer(T input);
    }
}
