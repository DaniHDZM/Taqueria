using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taqueria.Migrations
{
    /// <inheritdoc />
    public partial class platillo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlatilloId",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Platillos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platillos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_PlatilloId",
                table: "Personas",
                column: "PlatilloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Platillos_PlatilloId",
                table: "Personas",
                column: "PlatilloId",
                principalTable: "Platillos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Platillos_PlatilloId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Platillos");

            migrationBuilder.DropIndex(
                name: "IX_Personas_PlatilloId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "PlatilloId",
                table: "Personas");
        }
    }
}
