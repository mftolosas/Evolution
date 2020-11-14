using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EvolutionAPI.Models
{
    public partial class EvolutionContext : DbContext
    {
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        public EvolutionContext(DbContextOptions<EvolutionContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.PedId)
                    .HasName("PK__Pedido__50CF4A2596D32BD6");

                entity.ToTable("Pedido");

                entity.Property(e => e.PedId).HasColumnName("PedID");

                entity.Property(e => e.PedIva).HasColumnName("PedIVA");

                entity.Property(e => e.PedSubTot).HasColumnType("money");

                entity.Property(e => e.PedTotal).HasColumnType("money");

                entity.Property(e => e.PedVrUnit).HasColumnType("money");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.ProId)
                    .HasName("PK__Producto__620295F061B4E0B2");

                entity.ToTable("Producto");

                entity.Property(e => e.ProId).HasColumnName("ProID");

                entity.Property(e => e.ProDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProValor).HasColumnType("money");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuId)
                    .HasName("PK__Usuarios__685263A3C35B0745");

                entity.Property(e => e.UsuId).HasColumnName("UsuID");

                entity.Property(e => e.UsuNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuPass)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
