using Microsoft.EntityFrameworkCore;

namespace EvolutionAPI.Models
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> usuarios { get; set; }
    }
}
