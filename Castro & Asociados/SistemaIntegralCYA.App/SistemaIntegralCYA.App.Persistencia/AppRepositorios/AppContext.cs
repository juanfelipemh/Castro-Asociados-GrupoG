using Microsoft.EntityFrameworkCore;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Tecnicos> Tecnicos { get; set; }
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Historial> Historial { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Server=tcp:juanfelipe.database.windows.net,1433;Initial Catalog=SistemaIntegralCYA.App.Frontend;Persist Security Info=False;User ID=admin_1;Password=A2121584a.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}