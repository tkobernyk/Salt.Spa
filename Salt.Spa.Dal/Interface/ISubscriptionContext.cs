using Salt.Spa.Dal.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salt.Spa.Dal.Interface
{
    public interface ISubscriptionContext : IDisposable
    {
        IDbSet<Subscription> Subscriptions { get; set; }
        int SaveChanges();
    }
}
