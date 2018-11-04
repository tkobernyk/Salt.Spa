using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Salt.Spa.Infrastructure.Interface;
using Salt.Spa.Infrastructure.Entity;

namespace Salt.Spa.Dal.Entity
{
    public class Subscription : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual  ICollection<Customer> Customers { get; set; }
        [Required]
        [StringLength(100)]
        public string Number { get; set; }
        [Required]
        public int SessionCount { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public SubscriptionStatus Status { get; set; }
    }
}
