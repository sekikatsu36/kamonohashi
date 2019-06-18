using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class AddNfsServerInTenant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistoryOutputs_PreprocessHistories_PreprocessHistoryId",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropForeignKey(
                name: "FK_TensorBoardContainers_Ports_PortId",
                table: "TensorBoardContainers");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistoryAttachedFiles_TrainingHistories_TrainingHistoryId",
                table: "TrainingHistoryAttachedFiles");

            migrationBuilder.DropIndex(
                name: "IX_TensorBoardContainers_PortId",
                table: "TensorBoardContainers");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "EvaluationHistories");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "DataSets");

            migrationBuilder.AddColumn<string>(
                name: "Host",
                table: "TensorBoardContainers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PortNo",
                table: "TensorBoardContainers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "LimitMemory",
                table: "Tenants",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LimitGpu",
                table: "Tenants",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LimitCpu",
                table: "Tenants",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NfsRoot",
                table: "Tenants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NfsServer",
                table: "Tenants",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "No",
                table: "Ports",
                nullable: false,
                oldClrType: typeof(long),
                oldDefaultValueSql: "nextval('\"PortNoSeq\"')");

            migrationBuilder.DropSequence(
                name: "PortNoSeq");

            migrationBuilder.AddColumn<bool>(
                name: "TensorBoardEnabled",
                table: "Nodes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "PrivateKey",
                table: "Gits",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_Name",
                table: "Tenants",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistoryOutputs_PreprocessHistories_PreprocessHist~",
                table: "PreprocessHistoryOutputs",
                column: "PreprocessHistoryId",
                principalTable: "PreprocessHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistoryAttachedFiles_TrainingHistories_TrainingHist~",
                table: "TrainingHistoryAttachedFiles",
                column: "TrainingHistoryId",
                principalTable: "TrainingHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop view \"View_DataIndex\"");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistoryOutputs_PreprocessHistories_PreprocessHist~",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistoryAttachedFiles_TrainingHistories_TrainingHist~",
                table: "TrainingHistoryAttachedFiles");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_Name",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Host",
                table: "TensorBoardContainers");

            migrationBuilder.DropColumn(
                name: "PortNo",
                table: "TensorBoardContainers");

            migrationBuilder.DropColumn(
                name: "NfsRoot",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "NfsServer",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "TensorBoardEnabled",
                table: "Nodes");

            migrationBuilder.CreateSequence(
                name: "PortNoSeq",
                startValue: 50001L,
                minValue: 50001L,
                maxValue: 59999L,
                cyclic: true);

            migrationBuilder.AddColumn<uint>(
                name: "xmin",
                table: "TrainingHistories",
                type: "xid",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AlterColumn<decimal>(
                name: "LimitMemory",
                table: "Tenants",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LimitGpu",
                table: "Tenants",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LimitCpu",
                table: "Tenants",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "No",
                table: "Ports",
                nullable: false,
                defaultValueSql: "nextval('\"PortNoSeq\"')",
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<uint>(
                name: "xmin",
                table: "Jobs",
                type: "xid",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AlterColumn<string>(
                name: "PrivateKey",
                table: "Gits",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<uint>(
                name: "xmin",
                table: "EvaluationHistories",
                type: "xid",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "xmin",
                table: "DataSets",
                type: "xid",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.CreateIndex(
                name: "IX_TensorBoardContainers_PortId",
                table: "TensorBoardContainers",
                column: "PortId");

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistoryOutputs_PreprocessHistories_PreprocessHistoryId",
                table: "PreprocessHistoryOutputs",
                column: "PreprocessHistoryId",
                principalTable: "PreprocessHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TensorBoardContainers_Ports_PortId",
                table: "TensorBoardContainers",
                column: "PortId",
                principalTable: "Ports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistoryAttachedFiles_TrainingHistories_TrainingHistoryId",
                table: "TrainingHistoryAttachedFiles",
                column: "TrainingHistoryId",
                principalTable: "TrainingHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
