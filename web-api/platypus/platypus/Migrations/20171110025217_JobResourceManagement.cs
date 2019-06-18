using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class JobResourceManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompletedAt",
                table: "Jobs",
                newName: "SubmitAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndAt",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MailAddress",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MailType",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Partition",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Timeout",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "JobTimeout",
                table: "Tenants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndAt",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "MailAddress",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "MailType",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Partition",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Timeout",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobTimeout",
                table: "Tenants");

            migrationBuilder.RenameColumn(
                name: "SubmitAt",
                table: "Jobs",
                newName: "CompletedAt");
        }
    }
}
