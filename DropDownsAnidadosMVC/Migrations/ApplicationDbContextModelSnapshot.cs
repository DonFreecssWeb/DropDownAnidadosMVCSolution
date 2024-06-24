﻿// <auto-generated />
using DropDownsAnidadosMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DropDownsAnidadosMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SucursalID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SucursalID");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Aperitivos",
                            SucursalID = 1
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Plato principal",
                            SucursalID = 1
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Sopa",
                            SucursalID = 2
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Postres",
                            SucursalID = 2
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Bebidas",
                            SucursalID = 3
                        });
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaID = 1,
                            Nombre = "Rollitos de primavera",
                            Precio = 4.9900000000000002
                        },
                        new
                        {
                            Id = 2,
                            CategoriaID = 2,
                            Nombre = "Hamburguesa de primavera",
                            Precio = 2.9900000000000002
                        },
                        new
                        {
                            Id = 3,
                            CategoriaID = 3,
                            Nombre = "Tarta de primavera",
                            Precio = 3.9900000000000002
                        },
                        new
                        {
                            Id = 4,
                            CategoriaID = 4,
                            Nombre = "Refresco de primavera",
                            Precio = 5.9900000000000002
                        },
                        new
                        {
                            Id = 5,
                            CategoriaID = 5,
                            Nombre = "Plato de primavera",
                            Precio = 4.9900000000000002
                        },
                        new
                        {
                            Id = 6,
                            CategoriaID = 1,
                            Nombre = "Ensalada de primavera",
                            Precio = 7.9900000000000002
                        },
                        new
                        {
                            Id = 7,
                            CategoriaID = 2,
                            Nombre = "Pastel de primavera",
                            Precio = 10.99
                        },
                        new
                        {
                            Id = 8,
                            CategoriaID = 3,
                            Nombre = "Café de primavera",
                            Precio = 2.9900000000000002
                        },
                        new
                        {
                            Id = 9,
                            CategoriaID = 4,
                            Nombre = "Pizza de primavera",
                            Precio = 7.9900000000000002
                        },
                        new
                        {
                            Id = 10,
                            CategoriaID = 5,
                            Nombre = "Sopa de primavera",
                            Precio = 3.9900000000000002
                        });
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sucursal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direccion = "123 Calle Principal",
                            Nombre = "Sucursal Principal"
                        },
                        new
                        {
                            Id = 2,
                            Direccion = "456 Calle Central",
                            Nombre = "Sucursal Central"
                        },
                        new
                        {
                            Id = 3,
                            Direccion = "789 Calle Norte",
                            Nombre = "Sucursal Norte"
                        });
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Categoria", b =>
                {
                    b.HasOne("DropDownsAnidadosMVC.Models.Sucursal", "Sucursal")
                        .WithMany("Categorias")
                        .HasForeignKey("SucursalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Producto", b =>
                {
                    b.HasOne("DropDownsAnidadosMVC.Models.Categoria", null)
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Sucursal", b =>
                {
                    b.Navigation("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
