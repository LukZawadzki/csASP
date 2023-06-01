using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csASP.Migrations
{
    /// <inheritdoc />
    public partial class FloatCzekoladka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "masa",
                table: "czekoladki",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<float>(
                name: "koszt",
                table: "czekoladki",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "masa",
                table: "czekoladki",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<decimal>(
                name: "koszt",
                table: "czekoladki",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");
        }
    }
}
