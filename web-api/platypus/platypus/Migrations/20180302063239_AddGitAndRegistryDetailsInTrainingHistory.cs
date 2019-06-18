using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFMigrationTool.Migrations
{
    public partial class AddGitAndRegistryDetailsInTrainingHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "TagMaps",
                newName: "DataTagMaps");

            migrationBuilder.RenameColumn(
                name: "Repository",
                table: "TrainingHistories",
                newName: "ModelRepository");

            migrationBuilder.RenameColumn(
                name: "Container",
                table: "TrainingHistories",
                newName: "ContainerImage");

            migrationBuilder.AddColumn<long>(
                name: "ContainerRegistryId",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContainerTag",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModelBranch",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PortNo",
                table: "Gits",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Host",
                table: "Gits",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Gits",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TrainingHistoryTagMaps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    TagId = table.Column<long>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    TrainingHistoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingHistoryTagMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingHistoryTagMaps_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingHistoryTagMaps_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingHistoryTagMaps_TrainingHistories_TrainingHistoryId",
                        column: x => x.TrainingHistoryId,
                        principalTable: "TrainingHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistories_ContainerRegistryId",
                table: "TrainingHistories",
                column: "ContainerRegistryId");

            migrationBuilder.RenameIndex(
                name: "IX_TagMaps_DataId",
                table: "DataTagMaps",
                newName: "IX_DataTagMaps_DataId");

            migrationBuilder.RenameIndex(
                name: "IX_TagMaps_TagId",
                table: "DataTagMaps",
                newName: "IX_DataTagMaps_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_TagMaps_TenantId",
                table: "DataTagMaps",
                newName: "IX_DataTagMaps_TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistoryTagMaps_TagId",
                table: "TrainingHistoryTagMaps",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistoryTagMaps_TenantId",
                table: "TrainingHistoryTagMaps",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistoryTagMaps_TrainingHistoryId",
                table: "TrainingHistoryTagMaps",
                column: "TrainingHistoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistories_Registries_ContainerRegistryId",
                table: "TrainingHistories",
                column: "ContainerRegistryId",
                principalTable: "Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistories_Registries_ContainerRegistryId",
                table: "TrainingHistories");

            migrationBuilder.DropTable(
                name: "TrainingHistoryTagMaps");

            migrationBuilder.DropIndex(
                name: "IX_TrainingHistories_ContainerRegistryId",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "ContainerRegistryId",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "ContainerTag",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "ModelBranch",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "Options",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Gits");

            migrationBuilder.RenameColumn(
                name: "ModelRepository",
                table: "TrainingHistories",
                newName: "Repository");

            migrationBuilder.RenameColumn(
                name: "ContainerImage",
                table: "TrainingHistories",
                newName: "Container");

            migrationBuilder.AlterColumn<int>(
                name: "PortNo",
                table: "Gits",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Host",
                table: "Gits",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.RenameTable(
                name: "DataTagMaps",
                newName: "TagMaps");

            migrationBuilder.RenameIndex(
                name: "IX_DataTagMaps_DataId",
                table: "TagMaps",
                newName: "IX_TagMaps_DataId");

            migrationBuilder.RenameIndex(
                name: "IX_DataTagMaps_TagId",
                table: "TagMaps",
                newName: "IX_TagMaps_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_DataTagMaps_TenantId",
                table: "TagMaps",
                newName: "IX_TagMaps_TenantId");
        }
    }
}
