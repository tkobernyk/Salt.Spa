using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Salt.Spa.Infrastructure.Interface;
using Salt.Spa.Infrastructure.Entity;

namespace Salt.Spa.Dal.Entity
{
    public class Session : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [Required]
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public int SubscriptionId { get; set; }
        [Required]
        [ForeignKey("SubscriptionId")]
        public virtual Subscription Subscription { get; set; }
        [Required]
        public DateTime DateTimeStart { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        [DefaultValue(SessionStatus.Planned)]
        public SessionStatus Status { get; set; }

    }
}
