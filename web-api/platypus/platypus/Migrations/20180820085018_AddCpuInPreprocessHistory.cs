using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddCpuInPreprocessHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Registries_RegistryId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_RegistryId",
                table: "Tenants");

            migrationBuilder.AddColumn<int>(
                name: "Cpu",
                table: "PreprocessHistories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gpu",
                table: "PreprocessHistories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Memory",
                table: "PreprocessHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Partition",
                table: "PreprocessHistories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpu",
                table: "PreprocessHistories");

            migrationBuilder.DropColumn(
                name: "Gpu",
                table: "PreprocessHistories");

            migrationBuilder.DropColumn(
                name: "Memory",
                table: "PreprocessHistories");

            migrationBuilder.DropColumn(
                name: "Partition",
                table: "PreprocessHistories");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_RegistryId",
                table: "Tenants",
                column: "RegistryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Registries_RegistryId",
                table: "Tenants",
                column: "RegistryId",
                principalTable: "Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
