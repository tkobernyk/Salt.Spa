using System.Data.Entity;
using Salt.Spa.Dal.Entity;
using Salt.Spa.Dal.Interface;

namespace Salt.Spa.Dal
{
    public class SaltSpaContext : DbContext, IClientContext, ISubscriptionContext
    {
        static SaltSpaContext()
        {
            Database.SetInitializer(new DbInitializer());
            using (var db = new SaltSpaContext())
                db.Database.Initialize(false);
        }
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Subscription> Subscriptions { get; set; }
    }

    class DbInitializer : DropCreateDatabaseAlways<SaltSpaContext>
    {
        protected override void Seed(SaltSpaContext context)
        {
            base.Seed(context);
        }
    }
}
