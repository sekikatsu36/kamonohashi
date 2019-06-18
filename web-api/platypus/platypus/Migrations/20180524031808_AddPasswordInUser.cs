using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFMigrationTool.Migrations
{
    public partial class AddPasswordInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleMaps_Tenants_TenantId",
                table: "UserRoleMaps");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "UserRoleMaps",
                newName: "TenantMapId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoleMaps_TenantId",
                table: "UserRoleMaps",
                newName: "IX_UserRoleMaps_TenantMapId");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceType",
                table: "Users",
                nullable: false,
                defaultValue: 2); //LDAPで初期化

            migrationBuilder.AlterColumn<string>(
                name: "RegistryType",
                table: "Registries",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ServiceType",
                table: "Registries",
                nullable: false,
                defaultValue: 1); //DockerHubで初期化

            migrationBuilder.AlterColumn<string>(
                name: "GitType",
                table: "Gits",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ServiceType",
                table: "Gits",
                nullable: false,
                defaultValue: 2); //GitHubで初期化

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleMaps_UserTenantMaps_TenantMapId",
                table: "UserRoleMaps",
                column: "TenantMapId",
                principalTable: "UserTenantMaps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleMaps_UserTenantMaps_TenantMapId",
                table: "UserRoleMaps");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "Registries");

            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "Gits");

            migrationBuilder.RenameColumn(
                name: "TenantMapId",
                table: "UserRoleMaps",
                newName: "TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoleMaps_TenantMapId",
                table: "UserRoleMaps",
                newName: "IX_UserRoleMaps_TenantId");

            migrationBuilder.AlterColumn<string>(
                name: "RegistryType",
                table: "Registries",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GitType",
                table: "Gits",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleMaps_Tenants_TenantId",
                table: "UserRoleMaps",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
