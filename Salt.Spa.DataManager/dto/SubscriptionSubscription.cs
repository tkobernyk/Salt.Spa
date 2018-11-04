using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salt.Spa.DataManager.Interfaces;
using Salt.Spa.Infrastructure.Entity;

namespace Salt.Spa.DataManager.dto
{
    public class SubscriptionSubscription : IViewModel
    {
        public string Number { get; set; }
        public int SessionCount { get; set; }
        public DateTime StartDate { get; set; }
        public SubscriptionStatus Status { get; set; }
    }
}
