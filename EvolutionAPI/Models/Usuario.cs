using System.ComponentModel.DataAnnotations;

namespace EvolutionAPI.Models
{
    public class Usuario
    {
        [Key]
        public int UsuID { get; set; }
        public string UsuNombre { get; set; }
        public string UsuPass { get; set; }
    }
}
