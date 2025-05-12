using System.ComponentModel.DataAnnotations;

namespace Negocio.Clases
{
    public class Libro : Producto
    {
        [Required]
        public string? editorial {  get; set; }
        [Required]
        public string? categoria { get; set; }
        [Required]
        public string? autor {  get; set; }
    }
}
