using System.Collections.Generic;

namespace Salt.Spa.DataManager.Interfaces
{
    public interface IManager<T> where T : IViewModel
    {
        IEnumerable<T> Search(T input);
        T CreateOrUpdate(T input);
    }
}
