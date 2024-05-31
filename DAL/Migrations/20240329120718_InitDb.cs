using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albumler",
                columns: table => new
                {
                    AlbumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumAdi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    AlbumunSanatcisi_Grubu = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    AlbumCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlbumFiyati = table.Column<decimal>(type: "money", nullable: false),
                    IndirimOrani = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    SatisDevamEdiyorMu = table.Column<bool>(type: "bit", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumler", x => x.AlbumID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdSoyad = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    KullaniciAdi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "Album_Kullanicilar",
                columns: table => new
                {
                    Album_KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumID = table.Column<int>(type: "int", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album_Kullanicilar", x => x.Album_KullaniciID);
                    table.ForeignKey(
                        name: "FK_Album_Kullanicilar_Albumler_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albumler",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Album_Kullanicilar_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_Kullanicilar_AlbumID",
                table: "Album_Kullanicilar",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_Album_Kullanicilar_KullaniciID",
                table: "Album_Kullanicilar",
                column: "KullaniciID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album_Kullanicilar");

            migrationBuilder.DropTable(
                name: "Albumler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
