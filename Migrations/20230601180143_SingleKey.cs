using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csASP.Migrations
{
    /// <inheritdoc />
    public partial class SingleKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_zawartosc",
                table: "zawartosc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_artykuly",
                table: "artykuly");

            migrationBuilder.AddColumn<int>(
                name: "idzawartosci",
                table: "zawartosc",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "idartykulu",
                table: "artykuly",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_zawartosc",
                table: "zawartosc",
                column: "idzawartosci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_artykuly",
                table: "artykuly",
                column: "idartykulu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_zawartosc",
                table: "zawartosc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_artykuly",
                table: "artykuly");

            migrationBuilder.DropColumn(
                name: "idzawartosci",
                table: "zawartosc");

            migrationBuilder.DropColumn(
                name: "idartykulu",
                table: "artykuly");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zawartosc",
                table: "zawartosc",
                columns: new[] { "idpudelka", "idczekoladki" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_artykuly",
                table: "artykuly",
                columns: new[] { "idzamowienia", "idpudelka" });
        }
    }
}
