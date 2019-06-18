using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFMigrationTool.Migrations
{
    public partial class AddInferenceHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InferenceHistory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedBy = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    DisplayId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    DataSetId = table.Column<long>(nullable: false),
                    ModelGitId = table.Column<long>(nullable: true),
                    ModelRepository = table.Column<string>(nullable: true),
                    ModelRepositoryOwner = table.Column<string>(nullable: true),
                    ModelBranch = table.Column<string>(nullable: true),
                    ModelCommitId = table.Column<string>(nullable: true),
                    EntryPoint = table.Column<string>(nullable: false),
                    ContainerRegistryId = table.Column<long>(nullable: true),
                    ContainerImage = table.Column<string>(nullable: false),
                    ContainerTag = table.Column<string>(nullable: false),
                    Options = table.Column<string>(nullable: true),
                    ParentId = table.Column<long>(nullable: true),
                    Cpu = table.Column<int>(nullable: false),
                    Memory = table.Column<int>(nullable: false),
                    Gpu = table.Column<int>(nullable: false),
                    Partition = table.Column<string>(nullable: true),
                    Configuration = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: false),
                    StartedAt = table.Column<DateTime>(nullable: true),
                    CompletedAt = table.Column<DateTime>(nullable: true),
                    LogSummary = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    Favorite = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InferenceHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InferenceHistory_Registries_ContainerRegistryId",
                        column: x => x.ContainerRegistryId,
                        principalTable: "Registries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InferenceHistory_DataSets_DataSetId",
                        column: x => x.DataSetId,
                        principalTable: "DataSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InferenceHistory_TrainingHistories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "TrainingHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InferenceHistory_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InferenceHistoryAttachedFile",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedBy = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    InferenceHistoryId = table.Column<long>(nullable: false),
                    Key = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: false),
                    StoredPath = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InferenceHistoryAttachedFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InferenceHistoryAttachedFile_InferenceHistory_InferenceHist~",
                        column: x => x.InferenceHistoryId,
                        principalTable: "InferenceHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InferenceHistoryAttachedFile_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InferenceHistory_ContainerRegistryId",
                table: "InferenceHistory",
                column: "ContainerRegistryId");

            migrationBuilder.CreateIndex(
                name: "IX_InferenceHistory_DataSetId",
                table: "InferenceHistory",
                column: "DataSetId");

            migrationBuilder.CreateIndex(
                name: "IX_InferenceHistory_ParentId",
                table: "InferenceHistory",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_InferenceHistory_TenantId",
                table: "InferenceHistory",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_InferenceHistoryAttachedFile_InferenceHistoryId",
                table: "InferenceHistoryAttachedFile",
                column: "InferenceHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InferenceHistoryAttachedFile_TenantId",
                table: "InferenceHistoryAttachedFile",
                column: "TenantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InferenceHistoryAttachedFile");

            migrationBuilder.DropTable(
                name: "InferenceHistory");
        }
    }
}
