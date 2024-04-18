using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _11_cv_.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hodnocenis",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    ZkratkaPredmet = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Znamka = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hodnocenis", x => new { x.IdStudent, x.ZkratkaPredmet });
                });

            migrationBuilder.CreateTable(
                name: "Predmets",
                columns: table => new
                {
                    PredmetId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmets", x => x.PredmetId);
                });

            migrationBuilder.CreateTable(
                name: "StudentPredmets",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    ZkratkaPredmet = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPredmets", x => new { x.IdStudent, x.ZkratkaPredmet });
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jmeno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prijmeni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumNarozeni = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hodnocenis");

            migrationBuilder.DropTable(
                name: "Predmets");

            migrationBuilder.DropTable(
                name: "StudentPredmets");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
