using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddMaxMinItemDef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaxValue",
                table: "ItemDefs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinValue",
                table: "ItemDefs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxValue",
                table: "ItemDefs");

            migrationBuilder.DropColumn(
                name: "MinValue",
                table: "ItemDefs");
        }
    }
}
