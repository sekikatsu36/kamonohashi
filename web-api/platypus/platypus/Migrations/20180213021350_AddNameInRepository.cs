using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFMigrationTool.Migrations
{
    public partial class AddNameInRepository : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegistryPath",
                table: "Registries",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "TruncLogAt",
                table: "Jobs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registries_Name",
                table: "Registries",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Registries_Name",
                table: "Registries");

            migrationBuilder.DropColumn(
                name: "TruncLogAt",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Registries",
                newName: "RegistryPath");
        }
    }
}
