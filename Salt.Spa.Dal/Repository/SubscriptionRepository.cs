using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;
using Salt.Spa.Infrastructure.Interface;

namespace Salt.Spa.Dal.Repository
{
    public class SubscriptionRepository : IRepository<Subscription>, ISubscriptionRepository
    {
        private readonly ISubscriptionContext _context;
        public SubscriptionRepository(ISubscriptionContext context)
        {
            _context = context;
        }

        public int Add(Subscription entity)
        {
            _context.Subscriptions.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public Subscription Update(Subscription entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Subscription entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public Subscription GetById(int entityId)
        {
            return _context.Subscriptions.FirstOrDefault(c => c.Id == entityId);
        }
        public IEnumerable<Subscription> FindBySubscription(string number)
        {
            return _context.Subscriptions
                .Include(s => s.Customer)
                .Where(s => s.Number == number);
        }
        public IEnumerable<Subscription> FindByLastName(string lastName)
        {
            return _context.Subscriptions.Include(s => s.Customer)
                .Where(s => s.Customer.LastName == lastName);
        }

        public IEnumerable<Subscription> FindByPhone(string phone)
        {
            return _context.Subscriptions.Include(s => s.Customer)
                .Where(s => s.Customer.Phone == phone);
        }
        public IEnumerable<Subscription> GetAll()
        {
            return _context.Subscriptions;
        }
    }
}
