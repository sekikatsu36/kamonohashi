using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddUniqueKeyOnUserTenantGitMaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserTenantGitMaps_UserId",
                table: "UserTenantGitMaps");

            migrationBuilder.CreateIndex(
                name: "IX_UserTenantGitMaps_UserId_TenantGitMapId",
                table: "UserTenantGitMaps",
                columns: new[] { "UserId", "TenantGitMapId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserTenantGitMaps_UserId_TenantGitMapId",
                table: "UserTenantGitMaps");

            migrationBuilder.CreateIndex(
                name: "IX_UserTenantGitMaps_UserId",
                table: "UserTenantGitMaps",
                column: "UserId");
        }
    }
}
