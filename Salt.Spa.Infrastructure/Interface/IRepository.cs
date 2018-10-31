using System.Collections.Generic;

namespace Salt.Spa.Infrastructure.Interface
{
    public interface IRepository<T> where T: IEntity
    {
        int Add(T entity);
        T Update(T entity);
        bool Delete(T entity);
        bool Delete(int entityId);
        T GetById(int entityId);
        IEnumerable<T> GetAll();
    }
}
