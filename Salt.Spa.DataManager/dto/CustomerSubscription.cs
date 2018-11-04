using Salt.Spa.DataManager.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Salt.Spa.Infrastructure.Entity;

namespace Salt.Spa.DataManager.dto
{
    public class CustomerSubscription : IViewModel
    {
        [DisplayName("Номер клієнта")]
        public int CustomerId { get; set; }
        [DisplayName("Ім'я")]
        public string FirstName { get; set; }
        [DisplayName("Прізвище")]
        public string LastName { get; set; }
        [DisplayName("Телефон")]
        public string Phone { get; set; }
        [DisplayName("Номер абонементу")]
        public string SubscriptionNumber { get; set; }
        [DisplayName("Кількість сеансів")]
        public int SessionsCount { get; set; }
        [DisplayName("Дата купівлі")]
        public DateTime StartDate { get; set; }
        [DisplayName("Статус")]
        public SubscriptionStatus Status { get; set; }
        public override bool Equals(object obj)
        {
            return Equals(obj as CustomerSubscription);
        }
        public bool Equals(CustomerSubscription cs)
        {
            return cs != null && cs.CustomerId == CustomerId && cs.FirstName == FirstName &&
                   cs.LastName == LastName && cs.Phone == Phone && cs.SubscriptionNumber == SubscriptionNumber &&
                   cs.SessionsCount == SessionsCount && cs.StartDate == StartDate && cs.Status == Status;
        }

        public override int GetHashCode()
        {
            var hashCode = 3434434;
            hashCode = hashCode * -231231231 + CustomerId.GetHashCode();
            hashCode = hashCode * -231231231 + FirstName.GetHashCode();
            hashCode = hashCode * -231231231 + LastName.GetHashCode();
            hashCode = hashCode * -231231231 + Phone.GetHashCode();
            hashCode = hashCode * -231231231 + SubscriptionNumber.GetHashCode();
            hashCode = hashCode * -231231231 + SessionsCount.GetHashCode();
            hashCode = hashCode * -231231231 + StartDate.GetHashCode();
            hashCode = hashCode * -231231231 + Status.GetHashCode();
            return hashCode;
        }
    }
}
