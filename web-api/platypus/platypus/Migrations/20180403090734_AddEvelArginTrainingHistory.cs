using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFMigrationTool.Migrations
{
    public partial class AddEvelArginTrainingHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Argument",
                table: "TrainingHistories",
                newName: "TrainArgument");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "TrainingHistoryAttachedFiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvalArgument",
                table: "TrainingHistories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "TrainingHistoryAttachedFiles");

            migrationBuilder.DropColumn(
                name: "EvalArgument",
                table: "TrainingHistories");

            migrationBuilder.RenameColumn(
                name: "TrainArgument",
                table: "TrainingHistories",
                newName: "Argument");
        }
    }
}
