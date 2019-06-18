using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class changeRestrictAtDefaultTenantIdOnUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tenants_DefaultTenantId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tenants_DefaultTenantId",
                table: "Users",
                column: "DefaultTenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tenants_DefaultTenantId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tenants_DefaultTenantId",
                table: "Users",
                column: "DefaultTenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
