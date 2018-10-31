using System;
using System.Collections.Generic;
using System.Linq;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;
using Salt.Spa.DataManager.dto;
using Salt.Spa.DataManager.Interfaces;
using Salt.Spa.Infrastructure.Interface;

namespace Salt.Spa.DataManager
{
    public class CustomerFactory : IFactory<CustomerSubscription>
    {
        private IRepository<Customer> _customerRepository;
        private IRepository<Subscription> _subscriptionRepository;
        public CustomerFactory(IRepository<Customer> customerRepository,
            IRepository<Subscription> subscriptionRepository)
        {
            _customerRepository = customerRepository;
            _subscriptionRepository = subscriptionRepository;
        }

        public IEnumerable<CustomerSubscription> GetOrCreateCustomer(CustomerSubscription cs)
        {
            IEnumerable<CustomerSubscription> customers = null;
            if (!string.IsNullOrEmpty(cs.FirstName) && !string.IsNullOrEmpty(cs.LastName) &&
                !string.IsNullOrEmpty(cs.Phone) && !string.IsNullOrEmpty(cs.SubscriptionNumber) &&
                cs.SessionsCount > 0)
            {
                customers = CreateCustomer(cs);
            }
            else if (!string.IsNullOrEmpty(cs.LastName))
            {
                customers = GetCustomerByLastName((ISubscriptionRepository)_subscriptionRepository, cs.LastName);
            }
            else if (!string.IsNullOrEmpty(cs.Phone))
            {
                customers = GetCustomerByPhone((ISubscriptionRepository)_subscriptionRepository, cs.Phone);
            }
            else if (!string.IsNullOrEmpty(cs.SubscriptionNumber))
            {
                customers = GetCustomerBySubscription((ISubscriptionRepository)_subscriptionRepository, cs.SubscriptionNumber);
            }
            return customers;
        }

        private IEnumerable<CustomerSubscription> CreateCustomer(CustomerSubscription cs)
        {
            var customer = new Customer
            {FirstName = cs.FirstName,
                LastName = cs.LastName,
                Phone = cs.Phone
            };
            customer.Id = _customerRepository.Add(customer);
            var subscription = new Subscription
            {
                CustomerId = customer.Id,
                Customer = customer,
                Number = cs.SubscriptionNumber,
                SessionCount = cs.SessionsCount,
                StartDate = DateTime.Now
            };
            _subscriptionRepository.Add(subscription);
            yield return cs;
        }

        private IEnumerable<CustomerSubscription> GetCustomerByLastName(ISubscriptionRepository repository, string lastName)
        {
            return repository.FindByLastName(lastName)
                .Select(s => ConvertToCustomerSubscription(s));
        }
        private IEnumerable<CustomerSubscription> GetCustomerByPhone(ISubscriptionRepository repository, string phone)
        {
            return repository.FindByPhone(phone)
                .Select(s => ConvertToCustomerSubscription(s));
        }
        private IEnumerable<CustomerSubscription> GetCustomerBySubscription(ISubscriptionRepository repository, string subscriptionNumber)
        {
            return repository.FindBySubscription(subscriptionNumber)
                .Select(s => ConvertToCustomerSubscription(s));
        }

        private CustomerSubscription ConvertToCustomerSubscription(Subscription subscription)
        {
            return new CustomerSubscription
            {
                CustomerId = subscription.CustomerId,
                FirstName = subscription.Customer.FirstName,
                LastName = subscription.Customer.LastName,
                Phone = subscription.Customer.Phone,
                SubscriptionNumber = subscription.Number,
                SessionsCount = subscription.SessionCount,
                StartDate = subscription.StartDate,
                IsActive = subscription.Status == SubscriptionStatus.Active
            };
        }
    }
}
