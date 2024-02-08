using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dotnet_M1_A2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "positionTbl",
                columns: table => new
                {
                    PositionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nominee1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nominee2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nominee3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nominee4 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positionTbl", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "studentTbl",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentTbl", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "voteTbl",
                columns: table => new
                {
                    VoteSerialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomineeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PositionID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voteTbl", x => x.VoteSerialID);
                    table.ForeignKey(
                        name: "FK_voteTbl_positionTbl_PositionID",
                        column: x => x.PositionID,
                        principalTable: "positionTbl",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_voteTbl_studentTbl_StudentID",
                        column: x => x.StudentID,
                        principalTable: "studentTbl",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "positionTbl",
                columns: new[] { "PositionID", "Nominee1", "Nominee2", "Nominee3", "Nominee4", "PositionName" },
                values: new object[] { 1, "John", "Jane", "Mike", "Sara", "President" });

            migrationBuilder.InsertData(
                table: "positionTbl",
                columns: new[] { "PositionID", "Nominee1", "Nominee2", "Nominee3", "Nominee4", "PositionName" },
                values: new object[] { 2, "Alex", "Emily", "Chris", "Lily", "Vice President" });

            migrationBuilder.CreateIndex(
                name: "IX_voteTbl_PositionID",
                table: "voteTbl",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_voteTbl_StudentID",
                table: "voteTbl",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "voteTbl");

            migrationBuilder.DropTable(
                name: "positionTbl");

            migrationBuilder.DropTable(
                name: "studentTbl");
        }
    }
}
