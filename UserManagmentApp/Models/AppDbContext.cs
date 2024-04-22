using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Configuration;
using UserManagmentApp.Utilities;

namespace UserManagmentApp.Models
{
    public class AppDbContext : DbContext
    {
        // Propiedades DbSet para las entidades que deseas mapear a tablas en la base de datos
        public DbSet<Area> Areas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        // Constructor que recibe opciones de configuración del contexto

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
                optionsBuilder.UseNpgsql(connectionString);
            }
        }


        // Método para configurar el modelo de datos y las relaciones entre entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Area>().ToTable("Area");
            modelBuilder.Entity<Area>().HasData(Area.AreasPredefinidas);
        }
    }
}
