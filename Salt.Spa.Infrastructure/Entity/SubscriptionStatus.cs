using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Salt.Spa.Infrastructure.Entity
{
    public enum SubscriptionStatus
    {
        [Display(Name = "")]
        None = 0,
        [Display(Name = "Активний")]
        Active = 1,
        [Display(Name = "Завершився")]
        Finished = 2,
        [Display(Name = "Загублений")]
        Lost = 3,
    }
}
