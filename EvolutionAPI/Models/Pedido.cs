using System.ComponentModel.DataAnnotations;

namespace EvolutionAPI.Models
{
    public class Pedido
    {
        [Key]
        public int PedID { get; set; }
        public int PedUsu { get; set; }
        public int PedProd { get; set; }
        public decimal PedVrUnit { get; set; }
        public float PedCant { get; set; }
        public decimal PedSubTot { get; set; }
        public float PedIVA { get; set; }
        public decimal PedTotal { get; set; }
    }
}
