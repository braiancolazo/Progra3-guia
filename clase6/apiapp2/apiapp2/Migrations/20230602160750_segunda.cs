using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace apiapp2.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personas_IdCategoria",
                table: "personas",
                column: "IdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_personas_categorias_IdCategoria",
                table: "personas",
                column: "IdCategoria",
                principalTable: "categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personas_categorias_IdCategoria",
                table: "personas");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropIndex(
                name: "IX_personas_IdCategoria",
                table: "personas");
        }
    }
}
