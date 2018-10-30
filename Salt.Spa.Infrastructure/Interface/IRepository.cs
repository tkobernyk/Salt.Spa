using System.Collections.Generic;

namespace Salt.Spa.Infrastructure.Interface
{
    public interface IRepository<T> where T: IEntity
    {
        int Add(T entity);
        IEntity Update(T entity);
        bool Delete(T entity);
        bool Delete(int entityId);
        IEntity GetById(int entityId);
        IEnumerable<T> GetAll();
    }
}
