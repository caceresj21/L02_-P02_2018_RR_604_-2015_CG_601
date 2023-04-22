using System.ComponentModel.DataAnnotations;


namespace L02_P02__2018_RR_604__2015_CG_601.Models
{
    public class pedidos
    {

        [Key]

        [Display(Name = "PedidoID")]
        public int pedidoId { get; set; }
        [Display(Name = "MotoristaID")]
        public int motoristaId { get; set; }
        [Display(Name = "ClienteID")]
        public int clienteId { get; set; }
        [Display(Name = "PlatoID")]
        public int platoId { get; set; }
        [Display(Name = "Cantidad")]
        public int cantidad { get; set; }
        [Display(Name = "Precio")]

        public decimal precio { get; set; }
        


    }
}
