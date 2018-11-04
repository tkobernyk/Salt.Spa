using System;
using System.Collections.Generic;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;
using Salt.Spa.DataManager.dto;
using Salt.Spa.DataManager.Interfaces;
using Salt.Spa.Infrastructure.Interface;

namespace Salt.Spa.DataManager
{
    public class SubscriptionManager : IManager<SubscriptionSubscription>
    {
        private readonly IRepository<Subscription> _repository;
        public SubscriptionManager(IRepository<Subscription> repository)
        {
            _repository = repository;
        }

        public IEnumerable<SubscriptionSubscription> Search(SubscriptionSubscription ss)
        {
            if(!string.IsNullOrEmpty(ss.Number))
                yield return GetSubscriptionByNumber(ss.Number);
        }
        public SubscriptionSubscription CreateOrUpdate(SubscriptionSubscription ss)
        {
            var subscription = ((ISubscriptionRepository)_repository).FindBySubscription(ss.Number);
            if (subscription != null)
                _repository.Update(ConvertToSubscription(ss, subscription.Customers, subscription.Id));
            else
                _repository.Add(ConvertToSubscription(ss));
            return ss;
        }
        private SubscriptionSubscription CreateSubscription(SubscriptionSubscription ss)
        {
            _repository.Add(ConvertToSubscription(ss));
            return ss;
        }

        public SubscriptionSubscription GetSubscriptionByNumber(string subscribtionNumber)
        {
            return ConvertToSubscriptionSubscription(((ISubscriptionRepository)_repository).FindBySubscription(subscribtionNumber));
        }

        private Subscription ConvertToSubscription(SubscriptionSubscription ss, ICollection<Customer> customers = null, int subscriptionId = 0)
        {
            return new Subscription
            {
                Id = subscriptionId,
                Customers = customers,
                Number = ss.Number,
                StartDate = ss.StartDate,
                SessionCount = ss.SessionCount,
                Status = ss.Status,
            };
        }

        private SubscriptionSubscription ConvertToSubscriptionSubscription(Subscription subscription)
        {
            return new SubscriptionSubscription
            {
                Number = subscription.Number,
                StartDate = subscription.StartDate,
                SessionCount = subscription.SessionCount,
                Status = subscription.Status,
            };
        }
    }
}
