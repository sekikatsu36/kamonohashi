using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class RenameStorage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Storage_StorageId",
                table: "Tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storage",
                table: "Storage");

            migrationBuilder.DropColumn(
                name: "StorageBucket",
                table: "Storage");

            migrationBuilder.RenameTable(
                name: "Storage",
                newName: "Storages");

            migrationBuilder.RenameColumn(
                name: "StorageServer",
                table: "Storages",
                newName: "ServerAddress");

            migrationBuilder.RenameColumn(
                name: "StorageSecretKey",
                table: "Storages",
                newName: "SecretKey");

            migrationBuilder.RenameColumn(
                name: "StorageAccessKey",
                table: "Storages",
                newName: "AccessKey");

            migrationBuilder.AddColumn<bool>(
                name: "Favorite",
                table: "TrainingHistories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Storages",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storages",
                table: "Storages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Storages_StorageId",
                table: "Tenants",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Storages_StorageId",
                table: "Tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storages",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "Favorite",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Storages");

            migrationBuilder.RenameTable(
                name: "Storages",
                newName: "Storage");

            migrationBuilder.RenameColumn(
                name: "ServerAddress",
                table: "Storage",
                newName: "StorageServer");

            migrationBuilder.RenameColumn(
                name: "SecretKey",
                table: "Storage",
                newName: "StorageSecretKey");

            migrationBuilder.RenameColumn(
                name: "AccessKey",
                table: "Storage",
                newName: "StorageAccessKey");

            migrationBuilder.AddColumn<string>(
                name: "StorageBucket",
                table: "Storage",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storage",
                table: "Storage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Storage_StorageId",
                table: "Tenants",
                column: "StorageId",
                principalTable: "Storage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
