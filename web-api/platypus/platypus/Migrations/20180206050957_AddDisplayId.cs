using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddDisplayId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DisplayId",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DisplayId",
                table: "DataSets",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DisplayId",
                table: "Data",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayId",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "DisplayId",
                table: "DataSets");

            migrationBuilder.DropColumn(
                name: "DisplayId",
                table: "Data");
        }
    }
}
