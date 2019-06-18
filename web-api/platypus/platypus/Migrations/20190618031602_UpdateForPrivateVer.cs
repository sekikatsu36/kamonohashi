using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFMigrationTool.Migrations
{
    public partial class UpdateForPrivateVer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistory_Registries_ContainerRegistryId",
                table: "InferenceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistory_DataSets_DataSetId",
                table: "InferenceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistory_TrainingHistories_ParentId",
                table: "InferenceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistory_Tenants_TenantId",
                table: "InferenceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistoryAttachedFile_InferenceHistory_InferenceHist~",
                table: "InferenceHistoryAttachedFile");

            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistoryAttachedFile_Tenants_TenantId",
                table: "InferenceHistoryAttachedFile");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Gits_DefaultGitId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Registries_RegistryId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistories_Registries_ContainerRegistryId",
                table: "TrainingHistories");

            migrationBuilder.DropIndex(
                name: "IX_UserTenantRegistryMaps_UserId",
                table: "UserTenantRegistryMaps");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleMaps_UserId",
                table: "UserRoleMaps");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_RegistryId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_TenantRegistryMaps_TenantId",
                table: "TenantRegistryMaps");

            migrationBuilder.DropIndex(
                name: "IX_TenantGitMaps_TenantId",
                table: "TenantGitMaps");

            migrationBuilder.DropIndex(
                name: "IX_NodeTenantMaps_NodeId",
                table: "NodeTenantMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InferenceHistoryAttachedFile",
                table: "InferenceHistoryAttachedFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InferenceHistory",
                table: "InferenceHistory");

            migrationBuilder.AlterColumn<long>(
                name: "RegistryId",
                table: "Tenants",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.RenameColumn(
                name: "RegistryId",
                newName: "DefaultRegistryId",
                table: "Tenants");

            migrationBuilder.RenameTable(
                name: "InferenceHistoryAttachedFile",
                newName: "InferenceHistoryAttachedFiles");

            migrationBuilder.RenameTable(
                name: "InferenceHistory",
                newName: "InferenceHistories");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistoryAttachedFile_TenantId",
                table: "InferenceHistoryAttachedFiles",
                newName: "IX_InferenceHistoryAttachedFiles_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistoryAttachedFile_InferenceHistoryId",
                table: "InferenceHistoryAttachedFiles",
                newName: "IX_InferenceHistoryAttachedFiles_InferenceHistoryId");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistory_TenantId",
                table: "InferenceHistories",
                newName: "IX_InferenceHistories_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistory_ParentId",
                table: "InferenceHistories",
                newName: "IX_InferenceHistories_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistory_DataSetId",
                table: "InferenceHistories",
                newName: "IX_InferenceHistories_DataSetId");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistory_ContainerRegistryId",
                table: "InferenceHistories",
                newName: "IX_InferenceHistories_ContainerRegistryId");

            migrationBuilder.AlterColumn<long>(
                name: "ContainerRegistryId",
                table: "TrainingHistories",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DefaultGitId",
                table: "Tenants",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModelRepositoryOwner",
                table: "InferenceHistories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModelRepository",
                table: "InferenceHistories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ModelGitId",
                table: "InferenceHistories",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModelCommitId",
                table: "InferenceHistories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ContainerRegistryId",
                table: "InferenceHistories",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InferenceHistoryAttachedFiles",
                table: "InferenceHistoryAttachedFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InferenceHistories",
                table: "InferenceHistories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedBy = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    EnsureSingleRow = table.Column<int>(nullable: false),
                    ApiSecurityTokenPass = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTenantRegistryMaps_UserId_TenantRegistryMapId",
                table: "UserTenantRegistryMaps",
                columns: new[] { "UserId", "TenantRegistryMapId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMaps_UserId_RoleId_TenantMapId",
                table: "UserRoleMaps",
                columns: new[] { "UserId", "RoleId", "TenantMapId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_DefaultRegistryId",
                table: "Tenants",
                column: "DefaultRegistryId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantRegistryMaps_TenantId_RegistryId",
                table: "TenantRegistryMaps",
                columns: new[] { "TenantId", "RegistryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TenantGitMaps_TenantId_GitId",
                table: "TenantGitMaps",
                columns: new[] { "TenantId", "GitId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NodeTenantMaps_NodeId_TenantId",
                table: "NodeTenantMaps",
                columns: new[] { "NodeId", "TenantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuRoleMaps_MenuCode_RoleId",
                table: "MenuRoleMaps",
                columns: new[] { "MenuCode", "RoleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Settings_ApiSecurityTokenPass",
                table: "Settings",
                column: "ApiSecurityTokenPass",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistories_Registries_ContainerRegistryId",
                table: "InferenceHistories",
                column: "ContainerRegistryId",
                principalTable: "Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistories_DataSets_DataSetId",
                table: "InferenceHistories",
                column: "DataSetId",
                principalTable: "DataSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistories_TrainingHistories_ParentId",
                table: "InferenceHistories",
                column: "ParentId",
                principalTable: "TrainingHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistories_Tenants_TenantId",
                table: "InferenceHistories",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistoryAttachedFiles_InferenceHistories_InferenceH~",
                table: "InferenceHistoryAttachedFiles",
                column: "InferenceHistoryId",
                principalTable: "InferenceHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistoryAttachedFiles_Tenants_TenantId",
                table: "InferenceHistoryAttachedFiles",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Gits_DefaultGitId",
                table: "Tenants",
                column: "DefaultGitId",
                principalTable: "Gits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Registries_DefaultRegistryId",
                table: "Tenants",
                column: "DefaultRegistryId",
                principalTable: "Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistories_Registries_ContainerRegistryId",
                table: "TrainingHistories",
                column: "ContainerRegistryId",
                principalTable: "Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistories_Registries_ContainerRegistryId",
                table: "InferenceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistories_DataSets_DataSetId",
                table: "InferenceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistories_TrainingHistories_ParentId",
                table: "InferenceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistories_Tenants_TenantId",
                table: "InferenceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistoryAttachedFiles_InferenceHistories_InferenceH~",
                table: "InferenceHistoryAttachedFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_InferenceHistoryAttachedFiles_Tenants_TenantId",
                table: "InferenceHistoryAttachedFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Gits_DefaultGitId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Registries_DefaultRegistryId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistories_Registries_ContainerRegistryId",
                table: "TrainingHistories");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropIndex(
                name: "IX_UserTenantRegistryMaps_UserId_TenantRegistryMapId",
                table: "UserTenantRegistryMaps");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleMaps_UserId_RoleId_TenantMapId",
                table: "UserRoleMaps");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_DefaultRegistryId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_TenantRegistryMaps_TenantId_RegistryId",
                table: "TenantRegistryMaps");

            migrationBuilder.DropIndex(
                name: "IX_TenantGitMaps_TenantId_GitId",
                table: "TenantGitMaps");

            migrationBuilder.DropIndex(
                name: "IX_NodeTenantMaps_NodeId_TenantId",
                table: "NodeTenantMaps");

            migrationBuilder.DropIndex(
                name: "IX_MenuRoleMaps_MenuCode_RoleId",
                table: "MenuRoleMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InferenceHistoryAttachedFiles",
                table: "InferenceHistoryAttachedFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InferenceHistories",
                table: "InferenceHistories");

            migrationBuilder.RenameTable(
                name: "InferenceHistoryAttachedFiles",
                newName: "InferenceHistoryAttachedFile");

            migrationBuilder.RenameTable(
                name: "InferenceHistories",
                newName: "InferenceHistory");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistoryAttachedFiles_TenantId",
                table: "InferenceHistoryAttachedFile",
                newName: "IX_InferenceHistoryAttachedFile_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistoryAttachedFiles_InferenceHistoryId",
                table: "InferenceHistoryAttachedFile",
                newName: "IX_InferenceHistoryAttachedFile_InferenceHistoryId");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistories_TenantId",
                table: "InferenceHistory",
                newName: "IX_InferenceHistory_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistories_ParentId",
                table: "InferenceHistory",
                newName: "IX_InferenceHistory_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistories_DataSetId",
                table: "InferenceHistory",
                newName: "IX_InferenceHistory_DataSetId");

            migrationBuilder.RenameIndex(
                name: "IX_InferenceHistories_ContainerRegistryId",
                table: "InferenceHistory",
                newName: "IX_InferenceHistory_ContainerRegistryId");

            migrationBuilder.AlterColumn<long>(
                name: "ContainerRegistryId",
                table: "TrainingHistories",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "DefaultGitId",
                table: "Tenants",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "RegistryId",
                table: "Tenants",
                nullable: true);

            migrationBuilder.RenameColumn(
                name: "DefaultRegistryId",
                newName: "RegistryId",
                table: "Tenants");

            migrationBuilder.AlterColumn<long>(
                name: "RegistryId",
                table: "Tenants",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "ModelRepositoryOwner",
                table: "InferenceHistory",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ModelRepository",
                table: "InferenceHistory",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<long>(
                name: "ModelGitId",
                table: "InferenceHistory",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "ModelCommitId",
                table: "InferenceHistory",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<long>(
                name: "ContainerRegistryId",
                table: "InferenceHistory",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddPrimaryKey(
                name: "PK_InferenceHistoryAttachedFile",
                table: "InferenceHistoryAttachedFile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InferenceHistory",
                table: "InferenceHistory",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserTenantRegistryMaps_UserId",
                table: "UserTenantRegistryMaps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMaps_UserId",
                table: "UserRoleMaps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_RegistryId",
                table: "Tenants",
                column: "RegistryId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantRegistryMaps_TenantId",
                table: "TenantRegistryMaps",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantGitMaps_TenantId",
                table: "TenantGitMaps",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_NodeTenantMaps_NodeId",
                table: "NodeTenantMaps",
                column: "NodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistory_Registries_ContainerRegistryId",
                table: "InferenceHistory",
                column: "ContainerRegistryId",
                principalTable: "Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistory_DataSets_DataSetId",
                table: "InferenceHistory",
                column: "DataSetId",
                principalTable: "DataSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistory_TrainingHistories_ParentId",
                table: "InferenceHistory",
                column: "ParentId",
                principalTable: "TrainingHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistory_Tenants_TenantId",
                table: "InferenceHistory",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistoryAttachedFile_InferenceHistory_InferenceHist~",
                table: "InferenceHistoryAttachedFile",
                column: "InferenceHistoryId",
                principalTable: "InferenceHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InferenceHistoryAttachedFile_Tenants_TenantId",
                table: "InferenceHistoryAttachedFile",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Gits_DefaultGitId",
                table: "Tenants",
                column: "DefaultGitId",
                principalTable: "Gits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Registries_RegistryId",
                table: "Tenants",
                column: "RegistryId",
                principalTable: "Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistories_Registries_ContainerRegistryId",
                table: "TrainingHistories",
                column: "ContainerRegistryId",
                principalTable: "Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
