using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace __tarea7.Data
{
    public class vacunadosDbContext : DbContext
    {
        #region Contructor
        public vacunadosDbContext(DbContextOptions<vacunadosDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public properties
        public DbSet<vacunados> Product { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<vacunados>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<vacunados> GetProducts()
        {
            return new List<vacunados>
            {
                new   vacunados { Id = 1001, nombre = "Laptop", apellido = "ramirez", telefono = 10, tipoVacuna ="This is a best gaming laptop"},
                new vacunados { Id = 1002, nombre = "Microsoft Office", apellido = "ramirez", telefono = 50, tipoVacuna ="This is a Office Application"},
                new vacunados { Id = 1003, nombre = "Lazer Mouse", apellido = "ramirez", telefono = 20, tipoVacuna ="The mouse that works on all surface"},
              new vacunados { Id = 1004, nombre = "USB Storage", apellido = "ramirez", telefono = 20, tipoVacuna ="To store 256GB of data", fechaNacimiento ="a",provincia= "c",fecahDosis1="f",fecahDosis2 = "f"}
            };
        }
        #endregion
    }
}
