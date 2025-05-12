using System.ComponentModel.DataAnnotations;

namespace Negocio.Clases
{
    public class Electronico : Producto
    {
        [Required]
        public string? tiempo_garantia {  get; set; }
        [Required]
        public string? voltaje_trabajo { get; set; }
    }
}
