using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Salt.Spa.DataManager.Interfaces;
using Salt.Spa.Infrastructure.Entity;

namespace Salt.Spa.DataManager.dto
{
    public class CustomerSession : IViewModel
    {
        [Display(AutoGenerateField = false)]
        public int SessionId { get; set; }
        [Display(AutoGenerateField = false)]
        public int CustomerId { get; set; }
        [DisplayName("Ім'я")]
        public string FirstName { get; set; }
        [DisplayName("Прізвище")]
        public string LastName { get; set; }
        [DisplayName("Номер абонементу")]
        public string SubscriptionNumber { get; set; }
        [DisplayName("Дата сеансу")]
        public DateTime Date { get; set; }
        [DisplayName("Час сеансу")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTime Time { get; set; }
        [DisplayName("Тривалість")]
        [DisplayFormat(DataFormatString = "{0} хв")]
        public int Duration { get; set; }
        [DisplayName("Статус")]
        public SessionStatus Status { get; set; }
    }
}
