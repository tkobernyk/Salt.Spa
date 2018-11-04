using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
            _context.Subscriptions.AddOrUpdate(entity);
            _context.SaveChanges();
            return GetById(entity.Id);
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
        public Subscription FindBySubscription(string number)
        {
            return _context.Subscriptions.Include(s => s.Customers)
                .FirstOrDefault(s => s.Number == number);
        }
        public IEnumerable<Subscription> GetAll()
        {
            return _context.Subscriptions;
        }
    }
}
