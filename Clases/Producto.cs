using System.ComponentModel.DataAnnotations;

namespace Negocio.Clases
{
    public class Producto
    {
        [Required]
        [StringLength(6,
        ErrorMessage = "Identifier too long (16 character limit).")]
        public string? codigo {  get; set; }
        [Required]
        public string? nombre_producto { get; set; }
        [Required]
        public string? descripcion { get; set; }
        [Required]
        public string? precio_compra {  get; set; }
        [Required]
        public string? precio_venta { get; set; }
    }
}
