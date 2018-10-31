using Salt.Spa.Dal.Entity;
using System.Collections.Generic;

namespace Salt.Spa.Dal.Interface
{
    public interface ISubscriptionRepository
    {
        IEnumerable<Subscription> FindBySubscription(string number);
        IEnumerable<Subscription> FindByLastName(string lastName);
        IEnumerable<Subscription> FindByPhone(string phone);
    }
}
