using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Persistence.Migrations
{
    public partial class AddStudio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "IsPremiumMember", "Password", "Role", "Username" },
                values: new object[] { 4, 20, true, "Studio", "Studio", "Studio" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
