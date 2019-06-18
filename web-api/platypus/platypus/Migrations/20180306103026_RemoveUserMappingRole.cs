using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class RemoveUserMappingRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMappings_Roles_RoleId",
                table: "UserMappings");

            migrationBuilder.DropIndex(
                name: "IX_UserMappings_RoleId",
                table: "UserMappings");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "UserMappings");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDetails_RoleId",
                table: "RoleDetails",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDetails_TenantId",
                table: "RoleDetails",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDetails_UserId",
                table: "RoleDetails",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleDetails_Roles_RoleId",
                table: "RoleDetails",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleDetails_Tenants_TenantId",
                table: "RoleDetails",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleDetails_Users_UserId",
                table: "RoleDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.Sql("INSERT INTO \"UserMappings\"(\"UserId\", \"TenantId\", \"CreatedBy\",\"CreatedAt\",\"ModifiedBy\",\"ModifiedAt\") SELECT U.\"UserId\", U.\"TenantId\", '---', now(), '---', now() FROM \"UserMappings\" U GROUP BY U.\"UserId\", U.\"TenantId\"");
            migrationBuilder.Sql("DELETE FROM \"UserMappings\" WHERE \"CreatedBy\" != '---'");
            migrationBuilder.Sql("UPDATE \"UserMappings\" SET \"CreatedBy\" = 'admin', \"ModifiedBy\" = 'admin'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleDetails_Roles_RoleId",
                table: "RoleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleDetails_Tenants_TenantId",
                table: "RoleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleDetails_Users_UserId",
                table: "RoleDetails");

            migrationBuilder.DropIndex(
                name: "IX_RoleDetails_RoleId",
                table: "RoleDetails");

            migrationBuilder.DropIndex(
                name: "IX_RoleDetails_TenantId",
                table: "RoleDetails");

            migrationBuilder.DropIndex(
                name: "IX_RoleDetails_UserId",
                table: "RoleDetails");

            migrationBuilder.AddColumn<long>(
                name: "RoleId",
                table: "UserMappings",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_UserMappings_RoleId",
                table: "UserMappings",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMappings_Roles_RoleId",
                table: "UserMappings",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
