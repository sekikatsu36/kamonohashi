using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFMigrationTool.Migrations
{
    public partial class ReconstractDataStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedAt",
                table: "PreprocessHistories",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.DropForeignKey(
                name: "FK_Data_Annotations_AnnotationId",
                table: "Data");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessedImages_PreprocessHistories_PreprocessHistoryId",
                table: "PreprocessedImages");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessedImages_Tenants_TenantId",
                table: "PreprocessedImages");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistories_Data_DataId",
                table: "PreprocessHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistories_Preprocesses_PreprocessId",
                table: "PreprocessHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistories_Statuses_StatusId",
                table: "PreprocessHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistories_TrainingHistories_PreTrainingHistoryId",
                table: "TrainingHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistories_Preprocesses_PreprocessId",
                table: "TrainingHistories");

            migrationBuilder.DropIndex(
                name: "IX_PreprocessHistories_StatusId",
                table: "PreprocessHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PreprocessedImages",
                table: "PreprocessedImages");

            migrationBuilder.DropIndex(
                name: "IX_Data_AnnotationId",
                table: "Data");

            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "PreprocessedImages");

            migrationBuilder.RenameTable(
                name: "PreprocessedImages",
                newName: "PreprocessHistoryOutputs");

            migrationBuilder.RenameColumn(
                name: "ExecutedAt",
                table: "PreprocessHistories",
                newName: "CompletedAt");

            migrationBuilder.RenameColumn(
                name: "PreTrainingHistoryId",
                table: "TrainingHistories",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingHistories_PreTrainingHistoryId",
                table: "TrainingHistories",
                newName: "IX_TrainingHistories_ParentId");

            migrationBuilder.RenameColumn(
                name: "DataId",
                table: "PreprocessHistories",
                newName: "InputDataId");

            migrationBuilder.RenameIndex(
                name: "IX_PreprocessHistories_DataId",
                table: "PreprocessHistories",
                newName: "IX_PreprocessHistories_InputDataId");

            migrationBuilder.RenameIndex(
                name: "IX_PreprocessedImages_TenantId",
                table: "PreprocessHistoryOutputs",
                newName: "IX_PreprocessHistoryOutputs_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_PreprocessedImages_PreprocessHistoryId",
                table: "PreprocessHistoryOutputs",
                newName: "IX_PreprocessHistoryOutputs_PreprocessHistoryId");

            migrationBuilder.AlterColumn<long>(
                name: "PreprocessId",
                table: "TrainingHistories",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "PreprocessId",
                table: "PreprocessHistories",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<string>(
                name: "Memo",
                table: "PreprocessHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "PreprocessHistories",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageStoredPath",
                table: "PreprocessHistoryOutputs",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ImageFileName",
                table: "PreprocessHistoryOutputs",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<long>(
                name: "OutputDataId",
                table: "PreprocessHistoryOutputs",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RepositoryName",
                table: "Preprocesses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EntryPoint",
                table: "Preprocesses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Container",
                table: "Preprocesses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CommitId",
                table: "Preprocesses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PreprocessHistoryOutputs",
                table: "PreprocessHistoryOutputs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DataFiles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    FileName = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    StoredPath = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataFiles_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataProperties",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DataFileId = table.Column<long>(nullable: false),
                    DataId = table.Column<long>(nullable: false),
                    DataString = table.Column<string>(nullable: true),
                    Key = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataProperties_DataFiles_DataFileId",
                        column: x => x.DataFileId,
                        principalTable: "DataFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataProperties_Data_DataId",
                        column: x => x.DataId,
                        principalTable: "Data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataProperties_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TagMaps_DataId",
                table: "TagMaps",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_PreprocessHistoryOutputs_OutputDataId",
                table: "PreprocessHistoryOutputs",
                column: "OutputDataId");

            migrationBuilder.CreateIndex(
                name: "IX_DataFiles_TenantId",
                table: "DataFiles",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_DataProperties_DataFileId",
                table: "DataProperties",
                column: "DataFileId");

            migrationBuilder.CreateIndex(
                name: "IX_DataProperties_DataId",
                table: "DataProperties",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_DataProperties_TenantId",
                table: "DataProperties",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistoryOutputs_Data_OutputDataId",
                table: "PreprocessHistoryOutputs",
                column: "OutputDataId",
                principalTable: "Data",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistoryOutputs_PreprocessHistories_PreprocessHistoryId",
                table: "PreprocessHistoryOutputs",
                column: "PreprocessHistoryId",
                principalTable: "PreprocessHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistoryOutputs_Tenants_TenantId",
                table: "PreprocessHistoryOutputs",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistories_Data_InputDataId",
                table: "PreprocessHistories",
                column: "InputDataId",
                principalTable: "Data",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistories_Preprocesses_PreprocessId",
                table: "PreprocessHistories",
                column: "PreprocessId",
                principalTable: "Preprocesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TagMaps_Data_DataId",
                table: "TagMaps",
                column: "DataId",
                principalTable: "Data",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistories_TrainingHistories_ParentId",
                table: "TrainingHistories",
                column: "ParentId",
                principalTable: "TrainingHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistories_Preprocesses_PreprocessId",
                table: "TrainingHistories",
                column: "PreprocessId",
                principalTable: "Preprocesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistoryOutputs_Data_OutputDataId",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistoryOutputs_PreprocessHistories_PreprocessHistoryId",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistoryOutputs_Tenants_TenantId",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistories_Data_InputDataId",
                table: "PreprocessHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistories_Preprocesses_PreprocessId",
                table: "PreprocessHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_TagMaps_Data_DataId",
                table: "TagMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistories_TrainingHistories_ParentId",
                table: "TrainingHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistories_Preprocesses_PreprocessId",
                table: "TrainingHistories");

            migrationBuilder.DropTable(
                name: "DataProperties");

            migrationBuilder.DropTable(
                name: "DataFiles");

            migrationBuilder.DropIndex(
                name: "IX_TagMaps_DataId",
                table: "TagMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PreprocessHistoryOutputs",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropIndex(
                name: "IX_PreprocessHistoryOutputs_OutputDataId",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropColumn(
                name: "Memo",
                table: "PreprocessHistories");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "PreprocessHistories");

            migrationBuilder.DropColumn(
                name: "OutputDataId",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.RenameTable(
                name: "PreprocessHistoryOutputs",
                newName: "PreprocessedImages");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "TrainingHistories",
                newName: "PreTrainingHistoryId");

            migrationBuilder.RenameColumn(
                name: "CompletedAt",
                table: "PreprocessHistories",
                newName: "ExecutedAt");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingHistories_ParentId",
                table: "TrainingHistories",
                newName: "IX_TrainingHistories_PreTrainingHistoryId");

            migrationBuilder.RenameColumn(
                name: "InputDataId",
                table: "PreprocessHistories",
                newName: "DataId");

            migrationBuilder.RenameIndex(
                name: "IX_PreprocessHistories_InputDataId",
                table: "PreprocessHistories",
                newName: "IX_PreprocessHistories_DataId");

            migrationBuilder.RenameIndex(
                name: "IX_PreprocessHistoryOutputs_TenantId",
                table: "PreprocessedImages",
                newName: "IX_PreprocessedImages_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_PreprocessHistoryOutputs_PreprocessHistoryId",
                table: "PreprocessedImages",
                newName: "IX_PreprocessedImages_PreprocessHistoryId");

            migrationBuilder.AlterColumn<long>(
                name: "PreprocessId",
                table: "TrainingHistories",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PreprocessId",
                table: "PreprocessHistories",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExecutedAt",
                table: "PreprocessHistories",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageStoredPath",
                table: "PreprocessedImages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageFileName",
                table: "PreprocessedImages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sequence",
                table: "PreprocessedImages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "RepositoryName",
                table: "Preprocesses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EntryPoint",
                table: "Preprocesses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Container",
                table: "Preprocesses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CommitId",
                table: "Preprocesses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PreprocessedImages",
                table: "PreprocessedImages",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PreprocessHistories_StatusId",
                table: "PreprocessHistories",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Data_AnnotationId",
                table: "Data",
                column: "AnnotationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Data_Annotations_AnnotationId",
                table: "Data",
                column: "AnnotationId",
                principalTable: "Annotations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessedImages_PreprocessHistories_PreprocessHistoryId",
                table: "PreprocessedImages",
                column: "PreprocessHistoryId",
                principalTable: "PreprocessHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessedImages_Tenants_TenantId",
                table: "PreprocessedImages",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistories_Data_DataId",
                table: "PreprocessHistories",
                column: "DataId",
                principalTable: "Data",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistories_Preprocesses_PreprocessId",
                table: "PreprocessHistories",
                column: "PreprocessId",
                principalTable: "Preprocesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistories_Statuses_StatusId",
                table: "PreprocessHistories",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistories_TrainingHistories_PreTrainingHistoryId",
                table: "TrainingHistories",
                column: "PreTrainingHistoryId",
                principalTable: "TrainingHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistories_Preprocesses_PreprocessId",
                table: "TrainingHistories",
                column: "PreprocessId",
                principalTable: "Preprocesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
