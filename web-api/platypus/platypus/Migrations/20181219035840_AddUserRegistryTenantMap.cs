using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFMigrationTool.Migrations
{
    public partial class AddUserRegistryTenantMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserTenantGitMaps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedBy = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    TenantGitMapId = table.Column<long>(nullable: false),
                    GitToken = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTenantGitMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTenantGitMaps_TenantGitMap_TenantGitMapId",
                        column: x => x.TenantGitMapId,
                        principalTable: "TenantGitMap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTenantGitMaps_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTenantRegistryMaps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedBy = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    TenantRegistryMapId = table.Column<long>(nullable: false),
                    RegistryUserName = table.Column<string>(nullable: true),
                    RegistryPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTenantRegistryMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTenantRegistryMaps_TenantRegistryMaps_TenantRegistryMap~",
                        column: x => x.TenantRegistryMapId,
                        principalTable: "TenantRegistryMaps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTenantRegistryMaps_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTenantGitMaps_TenantGitMapId",
                table: "UserTenantGitMaps",
                column: "TenantGitMapId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTenantGitMaps_UserId",
                table: "UserTenantGitMaps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTenantRegistryMaps_TenantRegistryMapId",
                table: "UserTenantRegistryMaps",
                column: "TenantRegistryMapId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTenantRegistryMaps_UserId",
                table: "UserTenantRegistryMaps",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTenantGitMaps");

            migrationBuilder.DropTable(
                name: "UserTenantRegistryMaps");
        }
    }
}
