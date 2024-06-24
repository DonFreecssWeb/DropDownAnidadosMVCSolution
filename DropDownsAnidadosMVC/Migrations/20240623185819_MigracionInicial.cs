using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DropDownsAnidadosMVC.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SucursalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categoria_Sucursal_SucursalID",
                        column: x => x.SucursalID,
                        principalTable: "Sucursal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sucursal",
                columns: new[] { "Id", "Direccion", "Nombre" },
                values: new object[,]
                {
                    { 1, "123 Calle Principal", "Sucursal Principal" },
                    { 2, "456 Calle Central", "Sucursal Central" },
                    { 3, "789 Calle Norte", "Sucursal Norte" }
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nombre", "SucursalID" },
                values: new object[,]
                {
                    { 1, "Aperitivos", 1 },
                    { 2, "Plato principal", 1 },
                    { 3, "Sopa", 2 },
                    { 4, "Postres", 2 },
                    { 5, "Bebidas", 3 }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "Id", "CategoriaID", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, 1, "Rollitos de primavera", 4.9900000000000002 },
                    { 2, 2, "Hamburguesa de primavera", 2.9900000000000002 },
                    { 3, 3, "Tarta de primavera", 3.9900000000000002 },
                    { 4, 4, "Refresco de primavera", 5.9900000000000002 },
                    { 5, 5, "Plato de primavera", 4.9900000000000002 },
                    { 6, 1, "Ensalada de primavera", 7.9900000000000002 },
                    { 7, 2, "Pastel de primavera", 10.99 },
                    { 8, 3, "Café de primavera", 2.9900000000000002 },
                    { 9, 4, "Pizza de primavera", 7.9900000000000002 },
                    { 10, 5, "Sopa de primavera", 3.9900000000000002 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_SucursalID",
                table: "Categoria",
                column: "SucursalID");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaID",
                table: "Producto",
                column: "CategoriaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Sucursal");
        }
    }
}
