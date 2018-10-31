using System.ComponentModel.DataAnnotations;
using Salt.Spa.Infrastructure.Interface;

namespace Salt.Spa.Dal.Entity
{
    public class Customer : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(13)]
        public string Phone { get; set; }
    }
}
