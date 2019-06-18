using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class RemoveAnnotationRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnnotationStoredPath",
                table: "PreprocessedImages",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AnnotationFileName",
                table: "PreprocessedImages",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnnotationStoredPath",
                table: "PreprocessedImages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnnotationFileName",
                table: "PreprocessedImages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
