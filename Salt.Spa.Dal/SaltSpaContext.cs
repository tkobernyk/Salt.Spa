using System;
using System.Data.Entity;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;

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
                Customer = customer1,
                Number = "111",
                SessionCount = 10,
                StartDate = DateTime.Now
            };
            context.Subscriptions.Add(subscription1);
            var subscription2 = new Subscription
            {
                Customer = customer2,
                Number = "111",
                SessionCount = 10,
                StartDate = DateTime.Now
            };
            context.Subscriptions.Add(subscription2);
            var subscription3 = new Subscription
            {
                Customer = customer3,
                Number = "222",
                SessionCount = 10,
                StartDate = DateTime.Now
            };
            context.Subscriptions.Add(subscription3);
            var subscription4 = new Subscription
            {
                Customer = customer4,
                Number = "333",
                SessionCount = 10,
                StartDate = DateTime.Now
            };
            context.Subscriptions.Add(subscription4);
            var subscription5 = new Subscription
            {
                Customer = customer5,
                Number = "444",
                SessionCount = 10,
                StartDate = DateTime.Now
            };
            context.Subscriptions.Add(subscription5);
            var subscription6 = new Subscription
            {
                Customer = customer6,
                Number = "444",
                SessionCount = 10,
                StartDate = DateTime.Now
            };
            context.Subscriptions.Add(subscription6);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
