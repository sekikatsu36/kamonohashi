using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class ChangeDataFileIdToNullableInDataProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataProperties_DataFiles_DataFileId",
                table: "DataProperties");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Storages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DataFileId",
                table: "DataProperties",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_DataProperties_DataFiles_DataFileId",
                table: "DataProperties",
                column: "DataFileId",
                principalTable: "DataFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataProperties_DataFiles_DataFileId",
                table: "DataProperties");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Storages",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<long>(
                name: "DataFileId",
                table: "DataProperties",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DataProperties_DataFiles_DataFileId",
                table: "DataProperties",
                column: "DataFileId",
                principalTable: "DataFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
