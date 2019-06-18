using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddGitIdInTrainingHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TenantGitMap_Gits_GitId",
                table: "TenantGitMap");

            migrationBuilder.DropForeignKey(
                name: "FK_TenantGitMap_Tenants_TenantId",
                table: "TenantGitMap");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTenantGitMaps_TenantGitMap_TenantGitMapId",
                table: "UserTenantGitMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TenantGitMap",
                table: "TenantGitMap");

            migrationBuilder.RenameTable(
                name: "TenantGitMap",
                newName: "TenantGitMaps");

            migrationBuilder.RenameIndex(
                name: "IX_TenantGitMap_TenantId",
                table: "TenantGitMaps",
                newName: "IX_TenantGitMaps_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_TenantGitMap_GitId",
                table: "TenantGitMaps",
                newName: "IX_TenantGitMaps_GitId");

            migrationBuilder.AddColumn<long>(
                name: "ModelGitId",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Memory",
                table: "Preprocesses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Gpu",
                table: "Preprocesses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cpu",
                table: "Preprocesses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RepositoryGitId",
                table: "Preprocesses",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TenantGitMaps",
                table: "TenantGitMaps",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TenantGitMaps_Gits_GitId",
                table: "TenantGitMaps",
                column: "GitId",
                principalTable: "Gits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TenantGitMaps_Tenants_TenantId",
                table: "TenantGitMaps",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTenantGitMaps_TenantGitMaps_TenantGitMapId",
                table: "UserTenantGitMaps",
                column: "TenantGitMapId",
                principalTable: "TenantGitMaps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TenantGitMaps_Gits_GitId",
                table: "TenantGitMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_TenantGitMaps_Tenants_TenantId",
                table: "TenantGitMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTenantGitMaps_TenantGitMaps_TenantGitMapId",
                table: "UserTenantGitMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TenantGitMaps",
                table: "TenantGitMaps");

            migrationBuilder.DropColumn(
                name: "ModelGitId",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "RepositoryGitId",
                table: "Preprocesses");

            migrationBuilder.RenameTable(
                name: "TenantGitMaps",
                newName: "TenantGitMap");

            migrationBuilder.RenameIndex(
                name: "IX_TenantGitMaps_TenantId",
                table: "TenantGitMap",
                newName: "IX_TenantGitMap_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_TenantGitMaps_GitId",
                table: "TenantGitMap",
                newName: "IX_TenantGitMap_GitId");

            migrationBuilder.AlterColumn<int>(
                name: "Memory",
                table: "Preprocesses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Gpu",
                table: "Preprocesses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Cpu",
                table: "Preprocesses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TenantGitMap",
                table: "TenantGitMap",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TenantGitMap_Gits_GitId",
                table: "TenantGitMap",
                column: "GitId",
                principalTable: "Gits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TenantGitMap_Tenants_TenantId",
                table: "TenantGitMap",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTenantGitMaps_TenantGitMap_TenantGitMapId",
                table: "UserTenantGitMaps",
                column: "TenantGitMapId",
                principalTable: "TenantGitMap",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
