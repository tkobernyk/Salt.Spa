using System;
using System.Collections.Generic;
using System.Linq;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;
using Salt.Spa.Infrastructure.Interface;

namespace Salt.Spa.Dal.Repository
{
    public class ClientRepository : IRepository<Client>
    {
        private IClientContext _context;
        public ClientRepository(IClientContext context)
        {
            _context = context;
        }

        public int Add(Client entity)
        {
            _context.Clients.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public IEntity Update(Client entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Client entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public IEntity GetById(int entityId)
        {
            return _context.Clients.FirstOrDefault(c => c.Id == entityId);
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients;
        }
    }
}
