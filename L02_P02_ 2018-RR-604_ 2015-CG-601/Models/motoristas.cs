using System.ComponentModel.DataAnnotations;

namespace L02_P02__2018_RR_604__2015_CG_601.Models
{
    public class motoristas
    {
        [Key]
        [Display(Name = "ID del motorista")]
        public int motoristaId { get; set; }

        [Display(Name = "Nombre de motorista")]
        public string? nombreMotorista { get; set; }
    }
}
