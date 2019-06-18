using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFMigrationTool.Migrations
{
    public partial class AddMenuRoleMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClusterToken",
                table: "UserMappings",
                nullable: true);

            migrationBuilder.RenameTable(
                name: "UserMappings",
                newName: "UserTenantMaps"
                );

            migrationBuilder.RenameColumn(
                name: "Mem",
                table: "TrainingHistories",
                newName: "Memory");

            migrationBuilder.RenameColumn(
                name: "Gpus",
                table: "TrainingHistories",
                newName: "Gpu");

            migrationBuilder.RenameColumn(
                name: "Cpus",
                table: "TrainingHistories",
                newName: "Cpu");

            migrationBuilder.AddColumn<bool>(
                name: "IsForAdmin",
                table: "Roles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "TenantId",
                table: "Roles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "DataTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MenuRoleMaps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    MenuCode = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    RoleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRoleMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuRoleMaps_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleMaps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    RoleId = table.Column<long>(nullable: false),
                    TenantId = table.Column<long>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoleMaps_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleMaps_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoleMaps_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_TenantId",
                table: "Roles",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRoleMaps_RoleId",
                table: "MenuRoleMaps",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMaps_RoleId",
                table: "UserRoleMaps",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMaps_TenantId",
                table: "UserRoleMaps",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMaps_UserId",
                table: "UserRoleMaps",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Tenants_TenantId",
                table: "Roles",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Tenants_TenantId",
                table: "Roles");

            migrationBuilder.DropTable(
                name: "MenuRoleMaps");

            migrationBuilder.DropTable(
                name: "UserRoleMaps");

            migrationBuilder.DropIndex(
                name: "IX_Roles_TenantId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsForAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "DataTypes");

            migrationBuilder.RenameColumn(
                name: "Memory",
                table: "TrainingHistories",
                newName: "Mem");

            migrationBuilder.RenameColumn(
                name: "Gpu",
                table: "TrainingHistories",
                newName: "Gpus");

            migrationBuilder.RenameColumn(
                name: "Cpu",
                table: "TrainingHistories",
                newName: "Cpus");

            migrationBuilder.RenameTable(
                name: "UserTenantMaps",
                newName: "UserMappings"
                );

            migrationBuilder.DropColumn(
                name: "ClusterToken",
                table: "UserMappings");
        }
    }
}
