using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetProgramı.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KullaniciSoyadi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KullaniciYasi = table.Column<int>(type: "int", nullable: false),
                    KullaniciKilo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KullaniciBoy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yemekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kalori = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
                    Kategorileri = table.Column<int>(type: "int", nullable: false),
                    YemekAdi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yemekler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunIsmi = table.Column<int>(type: "int", nullable: false),
                    OgunVakti = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YemekPorsiyon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YenilenKalori = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YemekId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogunler_Yemekler_YemekId",
                        column: x => x.YemekId,
                        principalTable: "Yemekler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogunler_YemekId",
                table: "Ogunler",
                column: "YemekId");

            migrationBuilder.CreateIndex(
                name: "IX_Yemekler_KullaniciId",
                table: "Yemekler",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Yemekler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
