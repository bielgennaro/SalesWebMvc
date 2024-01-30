using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models.Enums
{
    public enum SaleStatus
    {
        [Display(Name = "Pendente")]
        PENDING,

        [Display(Name = "Faturado")]
        BILLED,

        [Display(Name = "Cancelada")]
        CANCELED
    }
}
