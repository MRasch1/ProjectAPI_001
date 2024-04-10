using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAPI_001_Repository.Migrations
{
    public partial class samuraiNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_samurai",
                table: "samurai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ninja",
                table: "ninja");

            migrationBuilder.RenameTable(
                name: "samurai",
                newName: "Samurai");

            migrationBuilder.RenameTable(
                name: "ninja",
                newName: "Ninja");

            migrationBuilder.RenameColumn(
                name: "Descripton",
                table: "Samurai",
                newName: "Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Samurai",
                table: "Samurai",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ninja",
                table: "Ninja",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Samurai",
                table: "Samurai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ninja",
                table: "Ninja");

            migrationBuilder.RenameTable(
                name: "Samurai",
                newName: "samurai");

            migrationBuilder.RenameTable(
                name: "Ninja",
                newName: "ninja");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "samurai",
                newName: "Descripton");

            migrationBuilder.AddPrimaryKey(
                name: "PK_samurai",
                table: "samurai",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ninja",
                table: "ninja",
                column: "Id");
        }
    }
}
