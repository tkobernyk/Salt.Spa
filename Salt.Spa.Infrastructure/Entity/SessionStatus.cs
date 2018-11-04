using System.ComponentModel.DataAnnotations;

namespace Salt.Spa.Infrastructure.Entity
{
    public enum SessionStatus
    {
        [Display(Name = "")]
        None = 0,
        [Display(Name = "Запланований")]
        Planned = 1,
        [Display(Name = "Активний")]
        Active = 2,
        [Display(Name = "Завершиний")]
        Finished = 3,
        [Display(Name = "Відмінений")]
        Cancelled = 4
    }
}
