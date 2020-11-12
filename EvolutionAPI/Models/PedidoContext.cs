using Microsoft.EntityFrameworkCore;

namespace EvolutionAPI.Models
{
    public class PedidoContext : DbContext
    {
        public PedidoContext(DbContextOptions<PedidoContext> options)
            : base(options)
        {
        }

        public DbSet<Pedido> pedidos { get; set; }
    }
}
