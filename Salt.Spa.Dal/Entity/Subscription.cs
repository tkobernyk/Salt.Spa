using System;
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
        public int ClientId { get; set; }
        [Required]
        [ForeignKey("ClientId")]
        public virtual  Client Client { get; set; }[Required]
        [StringLength(100)]
        public string Number { get; set; }
        [Required]
        public int SessionCount { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
    }
}
