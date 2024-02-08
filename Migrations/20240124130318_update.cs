using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dotnet_M1_A2.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "positionTbl",
                columns: new[] { "PositionID", "Nominee1", "Nominee2", "Nominee3", "Nominee4", "PositionName" },
                values: new object[] { 3, "Yash", "Jill", "Daniel", "Peter", "Captain" });

            migrationBuilder.InsertData(
                table: "positionTbl",
                columns: new[] { "PositionID", "Nominee1", "Nominee2", "Nominee3", "Nominee4", "PositionName" },
                values: new object[] { 4, "Michale", "jack", "Deni", "Dory", "Secretary" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "positionTbl",
                keyColumn: "PositionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "positionTbl",
                keyColumn: "PositionID",
                keyValue: 4);
        }
    }
}
