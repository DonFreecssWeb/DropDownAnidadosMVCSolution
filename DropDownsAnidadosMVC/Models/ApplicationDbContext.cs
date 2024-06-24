using Microsoft.EntityFrameworkCore;

namespace DropDownsAnidadosMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {            
        }

        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sucursal>().HasData(
                new Sucursal() { Id = 1 , Nombre = "Sucursal Principal", Direccion = "123 Calle Principal"},
                new Sucursal() { Id = 2, Nombre = "Sucursal Central", Direccion = "456 Calle Central" },
                new Sucursal() { Id = 3, Nombre = "Sucursal Norte", Direccion = "789 Calle Norte" }
                );

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria() { Id = 1, Nombre = "Aperitivos", SucursalID = 1 },
                new Categoria() { Id = 2, Nombre = "Plato principal", SucursalID = 1 },
                new Categoria() { Id = 3, Nombre = "Sopa", SucursalID = 2 },
                new Categoria() { Id = 4, Nombre = "Postres", SucursalID = 2 },
                new Categoria() { Id = 5, Nombre = "Bebidas", SucursalID = 3 }
                );

            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, Nombre = "Rollitos de primavera", Precio = 4.99, CategoriaID = 1},
                new Producto { Id = 2, Nombre = "Hamburguesa de primavera", Precio = 2.99, CategoriaID = 2 },
                new Producto { Id = 3, Nombre = "Tarta de primavera", Precio = 3.99, CategoriaID = 3 },
                new Producto { Id = 4, Nombre = "Refresco de primavera", Precio = 5.99, CategoriaID = 4 },
                new Producto { Id = 5, Nombre = "Plato de primavera", Precio = 4.99, CategoriaID = 5 },
                new Producto { Id = 6, Nombre = "Ensalada de primavera", Precio = 7.99, CategoriaID = 1 },
                new Producto { Id = 7, Nombre = "Pastel de primavera", Precio = 10.99, CategoriaID = 2 },
                new Producto { Id = 8, Nombre = "Café de primavera", Precio = 2.99, CategoriaID = 3 },
                new Producto { Id = 9, Nombre = "Pizza de primavera", Precio = 7.99, CategoriaID = 4 },
                new Producto { Id = 10, Nombre = "Sopa de primavera", Precio = 3.99, CategoriaID = 5 }
                );
        }
    }
}
