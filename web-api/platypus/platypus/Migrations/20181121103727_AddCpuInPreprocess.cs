using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddCpuInPreprocess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attribute",
                table: "Data");

            migrationBuilder.DropColumn(
                name: "IsRaw",
                table: "Data");

            migrationBuilder.AddColumn<int>(
                name: "Cpu",
                table: "Preprocesses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gpu",
                table: "Preprocesses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Memory",
                table: "Preprocesses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpu",
                table: "Preprocesses");

            migrationBuilder.DropColumn(
                name: "Gpu",
                table: "Preprocesses");

            migrationBuilder.DropColumn(
                name: "Memory",
                table: "Preprocesses");

            migrationBuilder.AddColumn<string>(
                name: "Attribute",
                table: "Data",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRaw",
                table: "Data",
                nullable: false,
                defaultValue: false);
        }
    }
}
