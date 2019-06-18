using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddTasksForDistJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfigType",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ParentJobId",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TaskId",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TaskNum",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaskType",
                table: "Jobs",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfigType",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "ParentJobId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "TaskNum",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "TaskType",
                table: "Jobs");
        }
    }
}
