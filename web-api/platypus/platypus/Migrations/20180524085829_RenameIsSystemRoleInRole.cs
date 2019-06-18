using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFMigrationTool.Migrations
{
    public partial class RenameIsSystemRoleInRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsForAdmin",
                table: "Roles",
                newName: "IsSystemRole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSystemRole",
                table: "Roles",
                newName: "IsForAdmin");
        }
    }
}
