using System.ComponentModel.DataAnnotations;


namespace L02_P02__2018_RR_604__2015_CG_601.Models
{
    public class platos
    {

        [Key]


        [Display(Name = "PlatoId")]
        public int platoId { get; set; }
        [Display(Name = "Nombre Plato")]
        public string? nombrePlato { get; set;}
        [Display(Name = "Precio")]

        public decimal precio { get;set; }
    }
}
