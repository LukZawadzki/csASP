using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csASP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "czekoladki",
                columns: table => new
                {
                    idczekoladki = table.Column<string>(type: "TEXT", nullable: false),
                    nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    czekolada = table.Column<string>(type: "TEXT", nullable: true),
                    orzechy = table.Column<string>(type: "TEXT", nullable: true),
                    nadzienie = table.Column<string>(type: "TEXT", nullable: true),
                    opis = table.Column<string>(type: "TEXT", nullable: false),
                    koszt = table.Column<decimal>(type: "TEXT", nullable: false),
                    masa = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_czekoladki", x => x.idczekoladki);
                });

            migrationBuilder.CreateTable(
                name: "klienci",
                columns: table => new
                {
                    idklienta = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    ulica = table.Column<string>(type: "TEXT", nullable: false),
                    miejscowosc = table.Column<string>(type: "TEXT", nullable: false),
                    kod = table.Column<string>(type: "TEXT", nullable: false),
                    telefon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_klienci", x => x.idklienta);
                });

            migrationBuilder.CreateTable(
                name: "pudelka",
                columns: table => new
                {
                    idpudelka = table.Column<string>(type: "TEXT", nullable: false),
                    nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    opis = table.Column<string>(type: "TEXT", nullable: true),
                    cena = table.Column<decimal>(type: "TEXT", nullable: false),
                    stan = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pudelka", x => x.idpudelka);
                });

            migrationBuilder.CreateTable(
                name: "zamowienia",
                columns: table => new
                {
                    idzamowienia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    datarealizacji = table.Column<DateTime>(type: "TEXT", nullable: false),
                    idklienta = table.Column<int>(type: "INTEGER", nullable: false),
                    Klientidklienta = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zamowienia", x => x.idzamowienia);
                    table.ForeignKey(
                        name: "FK_zamowienia_klienci_Klientidklienta",
                        column: x => x.Klientidklienta,
                        principalTable: "klienci",
                        principalColumn: "idklienta");
                });

            migrationBuilder.CreateTable(
                name: "zawartosc",
                columns: table => new
                {
                    idpudelka = table.Column<string>(type: "TEXT", nullable: false),
                    idczekoladki = table.Column<string>(type: "TEXT", nullable: false),
                    sztuk = table.Column<int>(type: "INTEGER", nullable: false),
                    Czekoladkaidczekoladki = table.Column<string>(type: "TEXT", nullable: true),
                    Pudelkoidpudelka = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zawartosc", x => new { x.idpudelka, x.idczekoladki });
                    table.ForeignKey(
                        name: "FK_zawartosc_czekoladki_Czekoladkaidczekoladki",
                        column: x => x.Czekoladkaidczekoladki,
                        principalTable: "czekoladki",
                        principalColumn: "idczekoladki");
                    table.ForeignKey(
                        name: "FK_zawartosc_pudelka_Pudelkoidpudelka",
                        column: x => x.Pudelkoidpudelka,
                        principalTable: "pudelka",
                        principalColumn: "idpudelka");
                });

            migrationBuilder.CreateTable(
                name: "artykuly",
                columns: table => new
                {
                    idzamowienia = table.Column<int>(type: "INTEGER", nullable: false),
                    idpudelka = table.Column<string>(type: "TEXT", nullable: false),
                    sztuk = table.Column<int>(type: "INTEGER", nullable: false),
                    Pudelkoidpudelka = table.Column<string>(type: "TEXT", nullable: true),
                    Zamowienieidzamowienia = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artykuly", x => new { x.idzamowienia, x.idpudelka });
                    table.ForeignKey(
                        name: "FK_artykuly_pudelka_Pudelkoidpudelka",
                        column: x => x.Pudelkoidpudelka,
                        principalTable: "pudelka",
                        principalColumn: "idpudelka");
                    table.ForeignKey(
                        name: "FK_artykuly_zamowienia_Zamowienieidzamowienia",
                        column: x => x.Zamowienieidzamowienia,
                        principalTable: "zamowienia",
                        principalColumn: "idzamowienia");
                });

            migrationBuilder.CreateIndex(
                name: "IX_artykuly_Pudelkoidpudelka",
                table: "artykuly",
                column: "Pudelkoidpudelka");

            migrationBuilder.CreateIndex(
                name: "IX_artykuly_Zamowienieidzamowienia",
                table: "artykuly",
                column: "Zamowienieidzamowienia");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienia_Klientidklienta",
                table: "zamowienia",
                column: "Klientidklienta");

            migrationBuilder.CreateIndex(
                name: "IX_zawartosc_Czekoladkaidczekoladki",
                table: "zawartosc",
                column: "Czekoladkaidczekoladki");

            migrationBuilder.CreateIndex(
                name: "IX_zawartosc_Pudelkoidpudelka",
                table: "zawartosc",
                column: "Pudelkoidpudelka");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "artykuly");

            migrationBuilder.DropTable(
                name: "zawartosc");

            migrationBuilder.DropTable(
                name: "zamowienia");

            migrationBuilder.DropTable(
                name: "czekoladki");

            migrationBuilder.DropTable(
                name: "pudelka");

            migrationBuilder.DropTable(
                name: "klienci");
        }
    }
}
