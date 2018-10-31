using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salt.Spa.Infrastructure.Interface;

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
        [Required]
        public DateTime DateTimeStart { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        [DefaultValue(SessionStatus.Planned)]
        public SessionStatus Status { get; set; }

    }
}
