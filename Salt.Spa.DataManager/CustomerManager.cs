using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;
using Salt.Spa.DataManager.dto;
using Salt.Spa.DataManager.Interfaces;
using Salt.Spa.Infrastructure.Interface;

namespace Salt.Spa.DataManager
{
    public class CustomerManager : IManager<CustomerSubscription>
    {
        private IRepository<Customer> _customerRepository;
        private IRepository<Subscription> _subscriptionRepository;
        public CustomerManager(IRepository<Customer> customerRepository,
            IRepository<Subscription> subscriptionRepository)
        {
            _customerRepository = customerRepository;
            _subscriptionRepository = subscriptionRepository;
        }

        public IEnumerable<CustomerSubscription> Search(CustomerSubscription cs)
        {
            List<CustomerSubscription> customers = new List<CustomerSubscription>();
            if (cs.CustomerId != 0)
            {
                customers.AddRange(GetCustomerSubscriptionsByCustomerId((ICustomerRepository)_customerRepository, cs.CustomerId));
            }
            if (!string.IsNullOrEmpty(cs.LastName)){
                customers.AddRange(GetCustomerSubscriptionsByLastName((ICustomerRepository)_customerRepository, cs.LastName));
            }
            if (!string.IsNullOrEmpty(cs.Phone))
            {
                customers.AddRange(GetCustomerSubscriptionsByPhone((ICustomerRepository)_customerRepository, cs.Phone));
            }
            if (!string.IsNullOrEmpty(cs.SubscriptionNumber))
            {
                customers.AddRange(GetCustomerSubscriptionsByNumber((ISubscriptionRepository)_subscriptionRepository, cs.SubscriptionNumber));
            }
            return customers.Distinct();
        }
        private CustomerSubscription CreateCustomer(CustomerSubscription cs)
        {
            var customer = new Customer{
                FirstName = cs.FirstName,
                LastName = cs.LastName,
                Phone = cs.Phone
            };
            customer.Id = _customerRepository.Add(customer);
            //TODO: Try to find subscription by number
            var subscription = new Subscription
            {
                Customers = new Collection<Customer> { customer },
                Number = cs.SubscriptionNumber,
                SessionCount = cs.SessionsCount,
                StartDate = DateTime.Now
            };
            _subscriptionRepository.Add(subscription);cs.CustomerId = customer.Id;
            return cs;
        }
        private IEnumerable<CustomerSubscription> GetCustomerSubscriptionsByCustomerId(ICustomerRepository repository, int customerId)
        {
            yield return ConvertToCustomerSubscription(repository.FindByCustomerId(customerId));
        }
        private IEnumerable<CustomerSubscription> GetCustomerSubscriptionsByLastName(ICustomerRepository repository, string lastName)
        {
            return repository.FindByLastName(lastName).Select(c => ConvertToCustomerSubscription(c));
        }
        private IEnumerable<CustomerSubscription> GetCustomerSubscriptionsByPhone(ICustomerRepository repository, string phone)
        {
            return repository.FindByPhone(phone).Select(c => ConvertToCustomerSubscription(c));
        }
        private IEnumerable<CustomerSubscription> GetCustomerSubscriptionsByNumber(ISubscriptionRepository repository, string subscriptionNumber)
        {
            foreach (var customer in repository.FindBySubscription(subscriptionNumber).Customers)
            {
                yield return ConvertToCustomerSubscription(customer);
            }
        }

        private CustomerSubscription ConvertToCustomerSubscription(Customer customer)
        {
            if (customer == null)
                return null;
            return new CustomerSubscription
            {
                CustomerId = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Phone = customer.Phone,
                SubscriptionNumber = customer.Subscription.Number,
                SessionsCount = customer.Subscription.SessionCount,
                StartDate = customer.Subscription.StartDate,
                Status = customer.Subscription.Status
            };
        }

        public CustomerSubscription CreateOrUpdate(CustomerSubscription ss)
        {
            throw new NotImplementedException();
        }
    }
}
