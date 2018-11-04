using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;
using Salt.Spa.Infrastructure.Interface;

namespace Salt.Spa.Dal.Repository
{
    public class SessionRepository : IRepository<Session>, ISessionRepository
    {
        private readonly ISessionContext _context;
        public SessionRepository(ISessionContext context)
        {
            _context = context;
        }

        public int Add(Session entity)
        {
            _context.Sessions.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public Session Update(Session entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Session entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public Session GetById(int entityId)
        {
            return _context.Sessions.FirstOrDefault(c => c.Id == entityId);
        }

        public IEnumerable<Session> GetAll()
        {
            return _context.Sessions;
        }

        public IEnumerable<Session> FindByCustomerId(int customerId)
        {
            return _context.Sessions.Include(s => s.Customer).Include(s => s.Subscription).Where(s => s.CustomerId == customerId);
        }
    }
}
