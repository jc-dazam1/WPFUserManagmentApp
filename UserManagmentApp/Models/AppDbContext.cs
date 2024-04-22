using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace UserManagmentApp.Models
{
    public class AppDbContext : DbContext
    {
        // Propiedades DbSet para las entidades que deseas mapear a tablas en la base de datos
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Area> Areas { get; set; }

        // Constructor que recibe opciones de configuración del contexto
        public AppDbContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseNpgsql(connectionString);
                }
            }
            catch (Exception err){ 
            
            }
           
        }

        // Método para configurar el modelo de datos y las relaciones entre entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Area>().ToTable("Areas");
            modelBuilder.Entity<Area>().HasData(Area.AreasPredefinidas);
        }
    }
}

