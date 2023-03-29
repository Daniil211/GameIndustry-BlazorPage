using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbAccess.Migrations
{
    public partial class GameDeveloperNullableFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameModels_GameDevelopers_DeveloperId",
                table: "GameModels");

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperId",
                table: "GameModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_GameModels_GameDevelopers_DeveloperId",
                table: "GameModels",
                column: "DeveloperId",
                principalTable: "GameDevelopers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameModels_GameDevelopers_DeveloperId",
                table: "GameModels");

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperId",
                table: "GameModels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GameModels_GameDevelopers_DeveloperId",
                table: "GameModels",
                column: "DeveloperId",
                principalTable: "GameDevelopers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
