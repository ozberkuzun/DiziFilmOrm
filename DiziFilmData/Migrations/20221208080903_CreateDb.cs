using Microsoft.EntityFrameworkCore.Migrations;

namespace DiziFilmData.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminAdi = table.Column<string>(maxLength: 60, nullable: false),
                    AdminSifre = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Kanallar",
                columns: table => new
                {
                    KanalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KanalAdi = table.Column<string>(maxLength: 60, nullable: false),
                    KanalSahibi = table.Column<string>(maxLength: 60, nullable: false),
                    KurulusYili = table.Column<string>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kanallar", x => x.KanalID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAdi = table.Column<string>(maxLength: 60, nullable: false),
                    UserSifre = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Diziler",
                columns: table => new
                {
                    DiziID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiziAdi = table.Column<string>(maxLength: 60, nullable: false),
                    DiziTür = table.Column<string>(maxLength: 60, nullable: false),
                    DiziGün = table.Column<string>(maxLength: 60, nullable: false),
                    KanalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diziler", x => x.DiziID);
                    table.ForeignKey(
                        name: "FK_Diziler_Kanallar_KanalID",
                        column: x => x.KanalID,
                        principalTable: "Kanallar",
                        principalColumn: "KanalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oyuncular",
                columns: table => new
                {
                    OyuncuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyuncuAdi = table.Column<string>(maxLength: 60, nullable: false),
                    OyuncuYas = table.Column<int>(maxLength: 60, nullable: false),
                    OyuncuCinsiyet = table.Column<string>(maxLength: 60, nullable: false),
                    DiziID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyuncular", x => x.OyuncuID);
                    table.ForeignKey(
                        name: "FK_Oyuncular_Diziler_DiziID",
                        column: x => x.DiziID,
                        principalTable: "Diziler",
                        principalColumn: "DiziID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diziler_KanalID",
                table: "Diziler",
                column: "KanalID");

            migrationBuilder.CreateIndex(
                name: "IX_Oyuncular_DiziID",
                table: "Oyuncular",
                column: "DiziID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Oyuncular");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Diziler");

            migrationBuilder.DropTable(
                name: "Kanallar");
        }
    }
}
