using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;
using Salt.Spa.Infrastructure.Interface;

namespace Salt.Spa.Dal.Repository
{
    public class CustomerRepository : IRepository<Customer>, ICustomerRepository
    {
        private readonly ICustomerContext _context;
        public CustomerRepository(ICustomerContext context)
        {
            _context = context;
        }

        public int Add(Customer entity)
        {
            _context.Customers.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public Customer Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int entityId)
        {
            return _context.Customers.FirstOrDefault(c => c.Id == entityId);
        }

        public Customer FindByCustomerId(int customerId)
        {
            return _context.Customers.Include(c => c.Subscription).SingleOrDefault(c => c.Id == customerId);
        }
        public IEnumerable<Customer> FindByLastName(string lastName)
        {
            return _context.Customers.Include(c => c.Subscription)
                .Where(c => c.LastName == lastName);
        }

        public IEnumerable<Customer> FindByPhone(string phone)
        {
            return _context.Customers.Include(c => c.Subscription)
                .Where(c => c.Phone == phone);
        }
        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

    }
}
