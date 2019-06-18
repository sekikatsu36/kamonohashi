using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddNodeInTrainingHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Gits_GitId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "NfsRoot",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "NfsServer",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "StorageAccessKey",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "StorageSecretKey",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "StorageServer",
                table: "Tenants");

            migrationBuilder.RenameColumn(
                name: "GitId",
                table: "Tenants",
                newName: "DefaultGitId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_GitId",
                table: "Tenants",
                newName: "IX_Tenants_DefaultGitId");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Registries",
                newName: "ProjectName");

            migrationBuilder.AddColumn<string>(
                name: "Node",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Node",
                table: "InferenceHistory",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Gits_DefaultGitId",
                table: "Tenants",
                column: "DefaultGitId",
                principalTable: "Gits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Gits_DefaultGitId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Node",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "Node",
                table: "InferenceHistory");

            migrationBuilder.RenameColumn(
                name: "DefaultGitId",
                table: "Tenants",
                newName: "GitId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_DefaultGitId",
                table: "Tenants",
                newName: "IX_Tenants_GitId");

            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "Registries",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "NfsRoot",
                table: "Tenants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NfsServer",
                table: "Tenants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorageAccessKey",
                table: "Tenants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorageSecretKey",
                table: "Tenants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorageServer",
                table: "Tenants",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Gits_GitId",
                table: "Tenants",
                column: "GitId",
                principalTable: "Gits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
