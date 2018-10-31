using Salt.Spa.DataManager.Interfaces;
using System;

namespace Salt.Spa.DataManager.dto
{
    public class CustomerSubscription : IDto
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string SubscriptionNumber { get; set; }
        public int SessionsCount { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
    }
}
