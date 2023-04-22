using System.ComponentModel.DataAnnotations;

namespace L02_P02__2018_RR_604__2015_CG_601.Models
{
    public class clientes
    {
        [Key]
        [Display(Name = "ID del cliente")]
        public int clienteId { get; set; }

        [Display(Name = "Nombre del cliente")]
        public string? nombreCliente { get; set; }
    }
}
