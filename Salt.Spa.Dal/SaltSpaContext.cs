using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;
using Salt.Spa.Infrastructure.Entity;

namespace Salt.Spa.Dal
{
    public class SaltSpaContext : DbContext, ICustomerContext, ISubscriptionContext, ISessionContext
    {
        static SaltSpaContext()
        {
            Database.SetInitializer(new DbInitializer());
            using (var db = new SaltSpaContext())
                db.Database.Initialize(false);
        }
        public SaltSpaContext() : base()
        {
        }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Subscription> Subscriptions { get; set; }
        public IDbSet<Session> Sessions { get; set; }
    }

    class DbInitializer : DropCreateDatabaseAlways<SaltSpaContext>
    {
        protected override void Seed(SaltSpaContext context)
        {
            if (context.Customers.Count() > 0)
                return;
            var customer1 = new Customer
            {
                FirstName = "Тарас",
                LastName = "Коберник",
                Phone = "+380935044888"
            };
            context.Customers.Add(customer1);
            var customer2 = new Customer
            {
                FirstName = "Юрій",
                LastName = "Коберник",
                Phone = "+380931111111"
            };
            context.Customers.Add(customer2);
            var customer3 = new Customer
            {
                FirstName = "Богдан",
                LastName = "Коберник",
                Phone = "+380931111111"
            };
            context.Customers.Add(customer3);
            var customer4 = new Customer
            {
                FirstName = "Марія",
                LastName = "Коберник",
                Phone = "+380931111111"
            };
            context.Customers.Add(customer4);
            var customer5 = new Customer
            {
                FirstName = "Ігор",
                LastName = "Коберник",
                Phone = "+380931111111"
            };
            context.Customers.Add(customer5);
            var customer6 = new Customer
            {
                FirstName = "Леся",
                LastName = "Коберник",
                Phone = "+380931111111"
            };
            context.Customers.Add(customer6);
            var subscription1 = new Subscription
            {
                Customers = new Collection<Customer> { customer1, customer2 },
                Number = "111",
                SessionCount = 10,
                StartDate = DateTime.Now,
                Status = SubscriptionStatus.Active
            };
            context.Subscriptions.Add(subscription1);
            var subscription3 = new Subscription
            {
                Customers = new Collection<Customer> { customer3 },
                Number = "222",
                SessionCount = 10,
                StartDate = DateTime.Now,
                Status = SubscriptionStatus.Active
            };
            context.Subscriptions.Add(subscription3);
            var subscription4 = new Subscription
            {
                Customers = new Collection<Customer> { customer4 },
                Number = "333",
                SessionCount = 10,
                StartDate = DateTime.Now,
                Status = SubscriptionStatus.Active
            };
            context.Subscriptions.Add(subscription4);
            var subscription5 = new Subscription
            {
                Customers = new Collection<Customer> { customer5, customer6 },
                Number = "444",
                SessionCount = 10,
                StartDate = DateTime.Now,
                Status = SubscriptionStatus.Active
            };
            context.Subscriptions.Add(subscription5);context.SaveChanges();
            var session1 = new Session
            {
                Customer = customer1,
                CustomerId = customer1.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now,
                Duration = 45
            };
            context.Sessions.Add(session1);
            var session2 = new Session
            {
                Customer = customer1,
                CustomerId = customer1.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-3),
                Duration = 45
            };
            context.Sessions.Add(session2);
            var session3 = new Session
            {
                Customer = customer1,
                CustomerId = customer1.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-6),
                Duration = 45
            };
            context.Sessions.Add(session3);
            var session4 = new Session
            {
                Customer = customer1,
                CustomerId = customer1.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-9),
                Duration = 45
            };
            context.Sessions.Add(session4);
            var session5 = new Session
            {
                Customer = customer1,
                CustomerId = customer1.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-12),
                Duration = 45
            };
            context.Sessions.Add(session5);
            var session6 = new Session
            {
                Customer = customer1,
                CustomerId = customer1.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-15),
                Duration = 45
            };
            context.Sessions.Add(session6);
            var session7 = new Session
            {
                Customer = customer1,
                CustomerId = customer1.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-18),
                Duration = 45
            };
            context.Sessions.Add(session7);
            var session8 = new Session
            {
                Customer = customer1,
                CustomerId = customer1.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-21),
                Duration = 45
            };
            context.Sessions.Add(session8);
            var session9 = new Session
            {
                Customer = customer1,
                CustomerId = customer1.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-24),
                Duration = 45
            };
            context.Sessions.Add(session9);
            var session10 = new Session
            {
                Customer = customer1,
                CustomerId = customer1.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-27),
                Duration = 45
            };
            context.Sessions.Add(session10);
            var session11 = new Session
            {
                Customer = customer2,
                CustomerId = customer2.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now,
                Duration = 45
            };
            context.Sessions.Add(session11);
            var session12 = new Session
            {
                Customer = customer2,
                CustomerId = customer2.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-4),
                Duration = 45
            };
            context.Sessions.Add(session12);
            var session13 = new Session
            {
                Customer = customer2,
                CustomerId = customer2.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-8),
                Duration = 45
            };
            context.Sessions.Add(session13);
            var session14 = new Session
            {
                Customer = customer2,
                CustomerId = customer2.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-12),
                Duration = 45
            };
            context.Sessions.Add(session14);
            var session15 = new Session
            {
                Customer = customer2,
                CustomerId = customer2.Id,
                Subscription = subscription1,
                SubscriptionId = subscription1.Id,
                DateTimeStart = DateTime.Now.AddDays(-15),
                Duration = 45
            };
            context.Sessions.Add(session15);
            base.Seed(context);
        }
    }
}
