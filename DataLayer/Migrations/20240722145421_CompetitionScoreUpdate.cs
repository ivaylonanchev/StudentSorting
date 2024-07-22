using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class CompetitionScoreUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionsScores_Profiles_ProfileID",
                table: "CompetitionsScores");

            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionsScores_Student_Studentid",
                table: "CompetitionsScores");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompetitionsScores",
                table: "CompetitionsScores");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionsScores_ProfileID",
                table: "CompetitionsScores");

            migrationBuilder.DropColumn(
                name: "Studentid",
                table: "CompetitionsScores");

            migrationBuilder.RenameColumn(
                name: "ProfileID",
                table: "CompetitionsScores",
                newName: "ProfileId");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "CompetitionsScores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompetitionsScores",
                table: "CompetitionsScores",
                columns: new[] { "ProfileId", "CompetitionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionsScores_Profiles_ProfileId",
                table: "CompetitionsScores",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionsScores_Profiles_ProfileId",
                table: "CompetitionsScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompetitionsScores",
                table: "CompetitionsScores");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "CompetitionsScores",
                newName: "ProfileID");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileID",
                table: "CompetitionsScores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Studentid",
                table: "CompetitionsScores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompetitionsScores",
                table: "CompetitionsScores",
                columns: new[] { "Studentid", "CompetitionId" });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profile_FKID = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EGN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Profiles_Profile_FKID",
                        column: x => x.Profile_FKID,
                        principalTable: "Profiles",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionsScores_ProfileID",
                table: "CompetitionsScores",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Profile_FKID",
                table: "Student",
                column: "Profile_FKID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionsScores_Profiles_ProfileID",
                table: "CompetitionsScores",
                column: "ProfileID",
                principalTable: "Profiles",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionsScores_Student_Studentid",
                table: "CompetitionsScores",
                column: "Studentid",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
