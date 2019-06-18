using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserMappings_TenantId",
                table: "UserMappings");

            migrationBuilder.DropIndex(
                name: "IX_RoleDetails_RoleId",
                table: "RoleDetails");

            migrationBuilder.CreateIndex(
                name: "IX_UserMappings_TenantId_UserId",
                table: "UserMappings",
                columns: new[] { "TenantId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleDetails_RoleId_TenantId_UserId",
                table: "RoleDetails",
                columns: new[] { "RoleId", "TenantId", "UserId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserMappings_TenantId_UserId",
                table: "UserMappings");

            migrationBuilder.DropIndex(
                name: "IX_RoleDetails_RoleId_TenantId_UserId",
                table: "RoleDetails");

            migrationBuilder.CreateIndex(
                name: "IX_UserMappings_TenantId",
                table: "UserMappings",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDetails_RoleId",
                table: "RoleDetails",
                column: "RoleId");
        }
    }
}
