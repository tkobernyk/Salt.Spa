using Salt.Spa.DataManager.Interfaces;
using System;

namespace Salt.Spa.DataManager.dto
{
    public class Session : IDto
    {
        public string LastName { get; set; }
        public string SubscriptionNumber { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int Duration { get; set; }
    }
}
