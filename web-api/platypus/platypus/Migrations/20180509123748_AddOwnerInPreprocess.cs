using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFMigrationTool.Migrations
{
    public partial class AddOwnerInPreprocess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Container",
                table: "Preprocesses",
                newName: "ContainerImage"); 

            migrationBuilder.RenameColumn(
                name: "CommitId",
                table: "Preprocesses",
                newName: "RepositoryCommitId");

            migrationBuilder.AddColumn<string>(
                name: "RepositoryOwner",
                table: "Preprocesses",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ContainerRegistryId",
                table: "Preprocesses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContainerTag",
                table: "Preprocesses",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DisplayId",
                table: "Preprocesses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RepositoryBranch",
                table: "Preprocesses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Preprocesses_ContainerRegistryId",
                table: "Preprocesses",
                column: "ContainerRegistryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Preprocesses_Registries_ContainerRegistryId",
                table: "Preprocesses",
                column: "ContainerRegistryId",
                principalTable: "Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preprocesses_Registries_ContainerRegistryId",
                table: "Preprocesses");

            migrationBuilder.DropIndex(
                name: "IX_Preprocesses_ContainerRegistryId",
                table: "Preprocesses");

            migrationBuilder.DropColumn(
                name: "RepositoryOwner",
                table: "Preprocesses");

            migrationBuilder.DropColumn(
                name: "ContainerRegistryId",
                table: "Preprocesses");

            migrationBuilder.DropColumn(
                name: "ContainerTag",
                table: "Preprocesses");

            migrationBuilder.DropColumn(
                name: "DisplayId",
                table: "Preprocesses");

            migrationBuilder.DropColumn(
                name: "RepositoryBranch",
                table: "Preprocesses");

            migrationBuilder.RenameColumn(
                name: "ContainerImage", 
                table: "Preprocesses",
                newName: "Container");

            migrationBuilder.RenameColumn(
                name: "RepositoryCommitId",
                table: "Preprocesses",
                newName: "CommitId");
        }
    }
}
