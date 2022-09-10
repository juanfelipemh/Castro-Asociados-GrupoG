using Microsoft.EntityFrameworkCore;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Tecnicos> Tecnicos {get; set;}
        public DbSet<Administrador> Administrador {get; set;}
        public DbSet<Servicio> Servicios {get; set;}
        public DbSet<Historial> Historial {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SistemaIntegralCYAData");
            }
        }
    }
}