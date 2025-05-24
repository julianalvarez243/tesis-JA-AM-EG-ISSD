using System;
using capaEntidad;
using Microsoft.EntityFrameworkCore;

namespace capaEF
{
    public class GescomDBContext : DbContext
    {
        public DbSet<Comida> Comidas { get; set; }
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<EstadoComanda> EstadosComanda { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<EstadoMesa> EstadosMesa { get; set; }
        public DbSet<Tamanio> Tamanios { get; set; }
        public DbSet<Mozo> Mozos { get; set; }
        public DbSet<EstadoMozo> EstadosMozo { get; set; }
        public DbSet<Caja> Cajas { get; set; }
        public DbSet<EstadoCaja> EstadosCaja { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Aquí podrías configurar relaciones, llaves compuestas, etc.
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Cadena hardcodeada SOLO para migraciones y diseño
                optionsBuilder.UseSqlServer("Server=localhost;Database=GESCOM_DB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
