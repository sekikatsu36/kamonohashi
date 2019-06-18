using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFMigrationTool.Migrations
{
    public partial class AddOwnerInTrainingHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataType",
                table: "DataTagMaps");

            migrationBuilder.AlterColumn<string>(
                name: "ModelCommitId",
                table: "TrainingHistories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Argument",
                table: "TrainingHistories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ModelRepositoryOwner",
                table: "TrainingHistories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModelRepositoryOwner",
                table: "TrainingHistories");

            migrationBuilder.AlterColumn<string>(
                name: "ModelCommitId",
                table: "TrainingHistories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Argument",
                table: "TrainingHistories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataType",
                table: "DataTagMaps",
                nullable: false,
                defaultValue: "");
        }
    }
}
