﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Salt.Spa.Infrastructure.Interface;

namespace Salt.Spa.Dal.Entity
{
    public class Subscription : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        [ForeignKey("CustomerId")]
        public virtual  Customer Customer { get; set; }
        [Required]
        [StringLength(100)]
        public string Number { get; set; }
        [Required]
        public int SessionCount { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        [DefaultValue(SubscriptionStatus.Active)]
        public SubscriptionStatus Status { get; set; }
    }
}
