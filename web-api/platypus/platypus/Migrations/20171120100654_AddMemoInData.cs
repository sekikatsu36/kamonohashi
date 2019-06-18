using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddMemoInData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Memo",
                table: "DataSets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Memo",
                table: "Data",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeqNum",
                table: "Roles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Memo",
                table: "DataSets");

            migrationBuilder.DropColumn(
                name: "Memo",
                table: "Data");

            migrationBuilder.DropColumn(
                name: "SeqNum",
                table: "Roles");
        }
    }
}
