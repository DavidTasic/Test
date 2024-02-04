using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    public partial class TrecaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kontakt_Studenti_StudentId",
                table: "Kontakt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kontakt",
                table: "Kontakt");

            migrationBuilder.RenameTable(
                name: "Kontakt",
                newName: "Kontakti");

            migrationBuilder.RenameIndex(
                name: "IX_Kontakt_StudentId",
                table: "Kontakti",
                newName: "IX_Kontakti_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kontakti",
                table: "Kontakti",
                column: "KontakId");

            migrationBuilder.CreateTable(
                name: "Predmeti",
                columns: table => new
                {
                    PredmetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmeti", x => x.PredmetId);
                    table.ForeignKey(
                        name: "FK_Predmeti_Studenti_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Studenti",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Predmeti_StudentId",
                table: "Predmeti",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kontakti_Studenti_StudentId",
                table: "Kontakti",
                column: "StudentId",
                principalTable: "Studenti",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kontakti_Studenti_StudentId",
                table: "Kontakti");

            migrationBuilder.DropTable(
                name: "Predmeti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kontakti",
                table: "Kontakti");

            migrationBuilder.RenameTable(
                name: "Kontakti",
                newName: "Kontakt");

            migrationBuilder.RenameIndex(
                name: "IX_Kontakti_StudentId",
                table: "Kontakt",
                newName: "IX_Kontakt_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kontakt",
                table: "Kontakt",
                column: "KontakId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kontakt_Studenti_StudentId",
                table: "Kontakt",
                column: "StudentId",
                principalTable: "Studenti",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
