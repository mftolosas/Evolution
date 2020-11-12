using System.ComponentModel.DataAnnotations;

namespace EvolutionAPI.Models
{
    public class Producto
    {
        [Key]
        public int ProID { get; set; }
        public string ProDesc { get; set; }
        public decimal ProValor { get; set; }
    }
}
