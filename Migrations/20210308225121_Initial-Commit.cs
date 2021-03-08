using Microsoft.EntityFrameworkCore.Migrations;

namespace __tarea7.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(type: "TEXT", nullable: true),
                    apellido = table.Column<string>(type: "TEXT", nullable: true),
                    telefono = table.Column<long>(type: "INTEGER", nullable: false),
                    fechaNacimiento = table.Column<string>(type: "TEXT", nullable: true),
                    tipoVacuna = table.Column<string>(type: "TEXT", nullable: true),
                    provincia = table.Column<string>(type: "TEXT", nullable: true),
                    fecahDosis1 = table.Column<string>(type: "TEXT", nullable: true),
                    fecahDosis2 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "apellido", "fecahDosis1", "fecahDosis2", "fechaNacimiento", "nombre", "provincia", "telefono", "tipoVacuna" },
                values: new object[] { 1001, "ramirez", null, null, null, "Laptop", null, 10L, "This is a best gaming laptop" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "apellido", "fecahDosis1", "fecahDosis2", "fechaNacimiento", "nombre", "provincia", "telefono", "tipoVacuna" },
                values: new object[] { 1002, "ramirez", null, null, null, "Microsoft Office", null, 50L, "This is a Office Application" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "apellido", "fecahDosis1", "fecahDosis2", "fechaNacimiento", "nombre", "provincia", "telefono", "tipoVacuna" },
                values: new object[] { 1003, "ramirez", null, null, null, "Lazer Mouse", null, 20L, "The mouse that works on all surface" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "apellido", "fecahDosis1", "fecahDosis2", "fechaNacimiento", "nombre", "provincia", "telefono", "tipoVacuna" },
                values: new object[] { 1004, "ramirez", "f", "f", "a", "USB Storage", "c", 20L, "To store 256GB of data" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
