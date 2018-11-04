using System.Collections.Generic;
using System.Linq;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;
using Salt.Spa.DataManager.dto;
using Salt.Spa.DataManager.Interfaces;
using Salt.Spa.Infrastructure.Interface;

namespace Salt.Spa.DataManager
{
    public class SessionManager : IManager<CustomerSession>
    {
        private readonly IRepository<Session> _repository;
        private readonly IRepository<Customer> _cRepository;
        private readonly ISubscriptionRepository _sRepository;

        public SessionManager(IRepository<Session> repository, IRepository<Customer> cRepository, ISubscriptionRepository sRepository)
        {
            _repository = repository;
            _cRepository = cRepository;
            _sRepository = sRepository;
        }

        public IEnumerable<CustomerSession> Search(CustomerSession cs)
        {
            List<CustomerSession> sessions = new List<CustomerSession>();
            if (cs.CustomerId > 0)
            {
                sessions.AddRange(GetSessionsByCustomerId((ISessionRepository)_repository, cs.CustomerId));
            }
            return sessions;
        }

        private IEnumerable<CustomerSession> GetSessionsByCustomerId(ISessionRepository repository, int customerId)
        {
            return repository.FindByCustomerId(customerId).Select(s => ConvertToCustomerSession(s));
        }

        public CustomerSession CreateSession(CustomerSession cs)
        {
            var session = ConvertToSession(cs);
            _repository.Add(session);
            return cs;
        }

        private Session ConvertToSession(CustomerSession cs)
        {
            var subscription = _sRepository.FindBySubscription(cs.SubscriptionNumber);
            return new Session
            {
                Id = cs.SessionId,
                Customer = _cRepository.GetById(cs.CustomerId),
                CustomerId = cs.CustomerId,
                Subscription = subscription,
                SubscriptionId = subscription.Id,
                DateTimeStart = cs.Date.Add(cs.Time.TimeOfDay),
                Duration = cs.Duration
            };
        }

        private CustomerSession ConvertToCustomerSession(Session session)
        {
            return new CustomerSession
            {
                SessionId = session.Id,
                CustomerId = session.CustomerId,
                FirstName = session.Customer.FirstName,
                LastName = session.Customer.LastName,
                SubscriptionNumber = session.Subscription.Number,
                Date = session.DateTimeStart.Date,
                Time = session.DateTimeStart,
                Duration = session.Duration
            };
        }

        public CustomerSession CreateOrUpdate(CustomerSession cs)
        {
            var session = _repository.GetById(cs.SessionId);
            if (session != null)
                _repository.Update(ConvertToSession(cs));
            else
                _repository.Add(ConvertToSession(cs));
            return cs;
        }
    }
}
