using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csASP.Migrations
{
    /// <inheritdoc />
    public partial class FloatTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "cena",
                table: "pudelka",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "cena",
                table: "pudelka",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");
        }
    }
}
