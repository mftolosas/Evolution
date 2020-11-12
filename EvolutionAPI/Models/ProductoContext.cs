using Microsoft.EntityFrameworkCore;

namespace EvolutionAPI.Models
{
    public class ProductoContext : DbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> productos { get; set; }
    }
}
