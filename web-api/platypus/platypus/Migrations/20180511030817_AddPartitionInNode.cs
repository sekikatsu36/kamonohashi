using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFMigrationTool.Migrations
{
    public partial class AddPartitionInNode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistories_Partitions_PartitionId",
                table: "TrainingHistories");

            migrationBuilder.DropTable(
                name: "NodePartitionMaps");

            migrationBuilder.DropTable(
                name: "Partitions");

            migrationBuilder.DropIndex(
                name: "IX_TrainingHistories_PartitionId",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "PartitionId",
                table: "TrainingHistories");

            migrationBuilder.AddColumn<string>(
                name: "Partition",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Memo",
                table: "Nodes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Partition",
                table: "Nodes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Partition",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "Memo",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "Partition",
                table: "Nodes");

            migrationBuilder.AddColumn<long>(
                name: "PartitionId",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Partitions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NodePartitionMaps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    NodeId = table.Column<long>(nullable: false),
                    PartitionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NodePartitionMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NodePartitionMaps_Nodes_NodeId",
                        column: x => x.NodeId,
                        principalTable: "Nodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NodePartitionMaps_Partitions_PartitionId",
                        column: x => x.PartitionId,
                        principalTable: "Partitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistories_PartitionId",
                table: "TrainingHistories",
                column: "PartitionId");

            migrationBuilder.CreateIndex(
                name: "IX_NodePartitionMaps_NodeId",
                table: "NodePartitionMaps",
                column: "NodeId");

            migrationBuilder.CreateIndex(
                name: "IX_NodePartitionMaps_PartitionId",
                table: "NodePartitionMaps",
                column: "PartitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistories_Partitions_PartitionId",
                table: "TrainingHistories",
                column: "PartitionId",
                principalTable: "Partitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
