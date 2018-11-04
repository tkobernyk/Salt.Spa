using System.Dynamic;
using Salt.Spa.Dal;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;
using Salt.Spa.Dal.Repository;
using Salt.Spa.DataManager;
using Salt.Spa.DataManager.dto;
using Salt.Spa.DataManager.Interfaces;
using Salt.Spa.Infrastructure.Interface;
using Unity;
using Unity.Lifetime;
using Session = Salt.Spa.Dal.Entity.Session;

namespace Salt.Spa.Unity
{
    public static class Resolver
    {
        private static UnityContainer _container = new UnityContainer();

        public static void InitContainer()
        {
            _container.RegisterType<ICustomerContext, SaltSpaContext>();
            _container.RegisterType<ISessionContext, SaltSpaContext>();
            _container.RegisterType<ISubscriptionContext, SaltSpaContext>();
            _container.RegisterType<IRepository<Customer>, CustomerRepository>();
            _container.RegisterType<IRepository<Session>, SessionRepository>();
            _container.RegisterType<IRepository<Subscription>, SubscriptionRepository>();
            _container.RegisterType<ICustomerRepository, CustomerRepository>();
            _container.RegisterType<ISubscriptionRepository, SubscriptionRepository>();
            _container.RegisterType<IManager<CustomerSubscription>, CustomerManager>(new SingletonLifetimeManager());
            _container.RegisterType<IManager<CustomerSession>, SessionManager>(new SingletonLifetimeManager());
            _container.RegisterType<IManager<SubscriptionSubscription>, SubscriptionManager>(new SingletonLifetimeManager());
        }

        public static T Get<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
