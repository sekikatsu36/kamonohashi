using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFMigrationTool.Migrations
{
    public partial class ReconstractTenantStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistoryOutputs_Data_OutputDataId",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingHistories_Preprocesses_PreprocessId",
                table: "TrainingHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tenants_DefaultTenantId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "AccessibleMenus");

            migrationBuilder.DropTable(
                name: "Annotations");

            migrationBuilder.DropTable(
                name: "AttachFiles");

            migrationBuilder.DropTable(
                name: "EvaluationHistories");

            migrationBuilder.DropTable(
                name: "InputPersonalSettings");

            migrationBuilder.DropTable(
                name: "InputSettingDetails");

            migrationBuilder.DropTable(
                name: "ItemDefs");

            migrationBuilder.DropTable(
                name: "JobEvents");

            migrationBuilder.DropTable(
                name: "LookUps");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Ports");

            migrationBuilder.DropTable(
                name: "RoleDetails");

            migrationBuilder.DropTable(
                name: "SearchConditionDetails");

            migrationBuilder.DropTable(
                name: "SearchPersonalSettings");

            migrationBuilder.DropTable(
                name: "SearchResultDetails");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "SystemMessages");

            migrationBuilder.DropTable(
                name: "InputSettings");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "SearchSettings");

            migrationBuilder.DropIndex(
                name: "IX_TrainingHistories_PreprocessId",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "ContainerStdErrStoredPath",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "ContainerStdOutStoredPath",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "EvalArgument",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "GpuDriver",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "PreprocessId",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "TestLogFileName",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "TestLogStoredPath",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "TrainArgument",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "TrainLogFileName",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "TrainLogStoredPath",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "TrainedParameterFileName",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "TrainedParameterStoredPath",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "UseParentAsPreTrain",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "User",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "PortId",
                table: "TensorBoardContainers");

            migrationBuilder.DropColumn(
                name: "RoleType",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "RegistryType",
                table: "Registries");

            migrationBuilder.DropColumn(
                name: "AnnotationFileName",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropColumn(
                name: "AnnotationStoredPath",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropColumn(
                name: "ImageStoredPath",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "PreprocessHistories");

            migrationBuilder.DropColumn(
                name: "GitType",
                table: "Gits");

            migrationBuilder.DropColumn(
                name: "Host",
                table: "Gits");

            migrationBuilder.DropColumn(
                name: "PortNo",
                table: "Gits");

            migrationBuilder.DropColumn(
                name: "PrivateKey",
                table: "Gits");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Gits");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Data");

            migrationBuilder.DropColumn(
                name: "StoredPath",
                table: "Data");

            migrationBuilder.RenameColumn(
                name: "AnnotationId",
                table: "Data",
                newName: "ParentDataId");

            migrationBuilder.AlterColumn<long>(
                name: "DefaultTenantId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "TrainingHistories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingHistories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EntryPoint",
                table: "TrainingHistories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContainerTag",
                table: "TrainingHistories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartedAt",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PortNo",
                table: "TensorBoardContainers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<long>(
                name: "StorageId",
                table: "Tenants",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEditable",
                table: "TenantRegistryMaps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<long>(
                name: "OutputDataId",
                table: "PreprocessHistoryOutputs",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContainerIdentifier",
                table: "PreprocessHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "PreprocessHistories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartedAt",
                table: "PreprocessHistories",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Gits",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedBy = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    StorageServer = table.Column<string>(nullable: false),
                    StorageBucket = table.Column<string>(nullable: false),
                    StorageAccessKey = table.Column<string>(nullable: false),
                    StorageSecretKey = table.Column<string>(nullable: false),
                    NfsServer = table.Column<string>(nullable: false),
                    NfsRoot = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TenantGitMap",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedBy = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    GitId = table.Column<long>(nullable: false),
                    IsEditable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantGitMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenantGitMap_Gits_GitId",
                        column: x => x.GitId,
                        principalTable: "Gits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TenantGitMap_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_RegistryId",
                table: "Tenants",
                column: "RegistryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_StorageId",
                table: "Tenants",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Data_ParentDataId",
                table: "Data",
                column: "ParentDataId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantGitMap_GitId",
                table: "TenantGitMap",
                column: "GitId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantGitMap_TenantId",
                table: "TenantGitMap",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Data_Data_ParentDataId",
                table: "Data",
                column: "ParentDataId",
                principalTable: "Data",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistoryOutputs_Data_OutputDataId",
                table: "PreprocessHistoryOutputs",
                column: "OutputDataId",
                principalTable: "Data",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Registries_RegistryId",
                table: "Tenants",
                column: "RegistryId",
                principalTable: "Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Storage_StorageId",
                table: "Tenants",
                column: "StorageId",
                principalTable: "Storage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tenants_DefaultTenantId",
                table: "Users",
                column: "DefaultTenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Data_Data_ParentDataId",
                table: "Data");

            migrationBuilder.DropForeignKey(
                name: "FK_PreprocessHistoryOutputs_Data_OutputDataId",
                table: "PreprocessHistoryOutputs");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Registries_RegistryId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Storage_StorageId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tenants_DefaultTenantId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "TenantGitMap");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_RegistryId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_StorageId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Data_ParentDataId",
                table: "Data");

            migrationBuilder.DropColumn(
                name: "StartedAt",
                table: "TrainingHistories");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "IsEditable",
                table: "TenantRegistryMaps");

            migrationBuilder.DropColumn(
                name: "ContainerIdentifier",
                table: "PreprocessHistories");

            migrationBuilder.DropColumn(
                name: "Options",
                table: "PreprocessHistories");

            migrationBuilder.DropColumn(
                name: "StartedAt",
                table: "PreprocessHistories");

            migrationBuilder.RenameColumn(
                name: "ParentDataId",
                table: "Data",
                newName: "AnnotationId");

            migrationBuilder.AlterColumn<long>(
                name: "DefaultTenantId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "TrainingHistories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingHistories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EntryPoint",
                table: "TrainingHistories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ContainerTag",
                table: "TrainingHistories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ContainerStdErrStoredPath",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContainerStdOutStoredPath",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvalArgument",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GpuDriver",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PreprocessId",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestLogFileName",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestLogStoredPath",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainArgument",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainLogFileName",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainLogStoredPath",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainedParameterFileName",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainedParameterStoredPath",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UseParentAsPreTrain",
                table: "TrainingHistories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "TrainingHistories",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PortNo",
                table: "TensorBoardContainers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PortId",
                table: "TensorBoardContainers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "RoleType",
                table: "Roles",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RegistryType",
                table: "Registries",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OutputDataId",
                table: "PreprocessHistoryOutputs",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<string>(
                name: "AnnotationFileName",
                table: "PreprocessHistoryOutputs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnnotationStoredPath",
                table: "PreprocessHistoryOutputs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "PreprocessHistoryOutputs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageStoredPath",
                table: "PreprocessHistoryOutputs",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StatusId",
                table: "PreprocessHistories",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Gits",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "GitType",
                table: "Gits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host",
                table: "Gits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PortNo",
                table: "Gits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrivateKey",
                table: "Gits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Gits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Data",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoredPath",
                table: "Data",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccessibleMenus",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    MenuCode = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    RoleName = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessibleMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessibleMenus_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Annotations",
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
                    table.PrimaryKey("PK_Annotations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Annotations_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttachFiles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Data = table.Column<byte[]>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttachFiles_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationHistories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Argument = table.Column<string>(nullable: false),
                    CompletedAt = table.Column<DateTime>(nullable: true),
                    Container = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DataSetId = table.Column<long>(nullable: true),
                    EvalLogFileName = table.Column<string>(nullable: true),
                    EvalLogStoredPath = table.Column<string>(nullable: true),
                    EvalResultFileName = table.Column<string>(nullable: true),
                    EvalResultStoredPath = table.Column<string>(nullable: true),
                    GpuDriver = table.Column<string>(nullable: true),
                    LogSummary = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    ModelCommitId = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    TrainingHistoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationHistories_DataSets_DataSetId",
                        column: x => x.DataSetId,
                        principalTable: "DataSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvaluationHistories_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvaluationHistories_TrainingHistories_TrainingHistoryId",
                        column: x => x.TrainingHistoryId,
                        principalTable: "TrainingHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InputSettings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DefaultSortOrder = table.Column<int>(nullable: true),
                    DisplayName = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    RoleId = table.Column<long>(nullable: true),
                    ShareType = table.Column<string>(nullable: false),
                    TargetType = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    UseType = table.Column<string>(nullable: false),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InputSettings_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemDefs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DataType = table.Column<string>(nullable: true),
                    DefaultValue1 = table.Column<string>(nullable: true),
                    DefaultValue2 = table.Column<string>(nullable: true),
                    DefaultValue3 = table.Column<string>(nullable: true),
                    DefaultValue4 = table.Column<string>(nullable: true),
                    DefaultValue5 = table.Column<string>(nullable: true),
                    Digit = table.Column<int>(nullable: true),
                    DisplayWidth = table.Column<int>(nullable: true),
                    GroupId = table.Column<string>(nullable: true),
                    ItemCode = table.Column<string>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    Locale = table.Column<string>(nullable: false),
                    MaxValue = table.Column<string>(nullable: true),
                    MinValue = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Required = table.Column<string>(nullable: true),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDefs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemDefs_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AllArgument1 = table.Column<string>(nullable: true),
                    AllArgument2 = table.Column<string>(nullable: true),
                    AllArgument3 = table.Column<string>(nullable: true),
                    AllArgument4 = table.Column<string>(nullable: true),
                    AllArgument5 = table.Column<string>(nullable: true),
                    Argument1 = table.Column<string>(nullable: true),
                    Argument2 = table.Column<string>(nullable: true),
                    Argument3 = table.Column<string>(nullable: true),
                    Argument4 = table.Column<string>(nullable: true),
                    Argument5 = table.Column<string>(nullable: true),
                    AssignedPort1 = table.Column<string>(nullable: true),
                    AssignedPort2 = table.Column<string>(nullable: true),
                    AssignedPort3 = table.Column<string>(nullable: true),
                    AssignedPort4 = table.Column<string>(nullable: true),
                    AssignedPort5 = table.Column<string>(nullable: true),
                    ConfigType = table.Column<string>(nullable: true),
                    Configuration = table.Column<string>(nullable: true),
                    Container = table.Column<string>(nullable: false),
                    ContainerStdErrStoredPath = table.Column<string>(nullable: true),
                    ContainerStdOutStoredPath = table.Column<string>(nullable: true),
                    Cpu = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    EndAt = table.Column<DateTime>(nullable: true),
                    EntryPoint1 = table.Column<string>(nullable: true),
                    EntryPoint2 = table.Column<string>(nullable: true),
                    EntryPoint3 = table.Column<string>(nullable: true),
                    EntryPoint4 = table.Column<string>(nullable: true),
                    EntryPoint5 = table.Column<string>(nullable: true),
                    ExecUserId = table.Column<long>(nullable: false),
                    ExecUserName = table.Column<string>(nullable: false),
                    Gpu = table.Column<int>(nullable: false),
                    GpuDriver = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    InParam1 = table.Column<string>(nullable: true),
                    InParam2 = table.Column<string>(nullable: true),
                    InParam3 = table.Column<string>(nullable: true),
                    InParam4 = table.Column<string>(nullable: true),
                    InParam5 = table.Column<string>(nullable: true),
                    InputDataType = table.Column<string>(nullable: false),
                    JobType = table.Column<string>(nullable: false),
                    LogSummary = table.Column<string>(nullable: true),
                    MailAddress = table.Column<string>(nullable: true),
                    MailType = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    Memory = table.Column<int>(nullable: false),
                    ModelCommitId = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    NodeName = table.Column<string>(nullable: true),
                    OutParam1 = table.Column<string>(nullable: true),
                    OutParam10 = table.Column<string>(nullable: true),
                    OutParam2 = table.Column<string>(nullable: true),
                    OutParam3 = table.Column<string>(nullable: true),
                    OutParam4 = table.Column<string>(nullable: true),
                    OutParam5 = table.Column<string>(nullable: true),
                    OutParam6 = table.Column<string>(nullable: true),
                    OutParam7 = table.Column<string>(nullable: true),
                    OutParam8 = table.Column<string>(nullable: true),
                    OutParam9 = table.Column<string>(nullable: true),
                    ParentJobId = table.Column<long>(nullable: true),
                    Partition = table.Column<string>(nullable: true),
                    PortId1 = table.Column<long>(nullable: true),
                    PortId2 = table.Column<long>(nullable: true),
                    PortId3 = table.Column<long>(nullable: true),
                    PortId4 = table.Column<long>(nullable: true),
                    PortId5 = table.Column<long>(nullable: true),
                    PrevJobId = table.Column<long>(nullable: true),
                    Repository = table.Column<string>(nullable: true),
                    StartAt = table.Column<DateTime>(nullable: true),
                    StartUpType = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    SubmitAt = table.Column<DateTime>(nullable: true),
                    TaskId = table.Column<long>(nullable: true),
                    TaskNum = table.Column<long>(nullable: true),
                    TaskType = table.Column<string>(nullable: true),
                    TenantId = table.Column<long>(nullable: false),
                    Timeout = table.Column<long>(nullable: true),
                    TruncLogAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LookUps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    GroupId = table.Column<string>(nullable: false),
                    Locale = table.Column<string>(nullable: false),
                    LookUpId = table.Column<string>(nullable: false),
                    LookUpName = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    SortOrder = table.Column<long>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LookUps_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Action = table.Column<string>(nullable: true),
                    Controller = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Locale = table.Column<string>(nullable: false),
                    MenuCode = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ParentMenuCode = table.Column<string>(nullable: false),
                    ShowTopFlag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ports",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Host = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    No = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AssignType = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    RoleId = table.Column<long>(nullable: false),
                    TenantId = table.Column<long>(nullable: true),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleDetails_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleDetails_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SearchSettings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DisplayName = table.Column<string>(nullable: false),
                    FirstSortItem = table.Column<string>(nullable: true),
                    FirstSortType = table.Column<string>(nullable: true),
                    LineNumber = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    RoleId = table.Column<long>(nullable: true),
                    SecondSortItem = table.Column<string>(nullable: true),
                    SecondSortType = table.Column<string>(nullable: true),
                    ShareType = table.Column<string>(nullable: false),
                    TargetType = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    UseType = table.Column<string>(nullable: false),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SearchSettings_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statuses_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemMessages",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Body = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Locale = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    NotifiedAt = table.Column<DateTime>(nullable: false),
                    SeqNum = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InputPersonalSettings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    InputSettingId = table.Column<long>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    PrimaryFlag = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: true),
                    TenantId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputPersonalSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InputPersonalSettings_InputSettings_InputSettingId",
                        column: x => x.InputSettingId,
                        principalTable: "InputSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InputPersonalSettings_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InputSettingDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    InputSettingId = table.Column<long>(nullable: false),
                    ItemCode = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    SeqNum = table.Column<int>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    Value1 = table.Column<string>(nullable: true),
                    Value2 = table.Column<string>(nullable: true),
                    Value3 = table.Column<string>(nullable: true),
                    Value4 = table.Column<string>(nullable: true),
                    Value5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputSettingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InputSettingDetails_InputSettings_InputSettingId",
                        column: x => x.InputSettingId,
                        principalTable: "InputSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InputSettingDetails_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobEvents",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Count = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    FirstTimestamp = table.Column<DateTime>(nullable: false),
                    JobId = table.Column<long>(nullable: false),
                    LastTimestamp = table.Column<DateTime>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Reason = table.Column<string>(nullable: true),
                    TenantId = table.Column<long>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Uid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobEvents_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobEvents_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SearchConditionDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ItemCode = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    SearchSettingId = table.Column<long>(nullable: false),
                    SearchType = table.Column<string>(nullable: true),
                    SeqNum = table.Column<int>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    Value1 = table.Column<string>(nullable: true),
                    Value2 = table.Column<string>(nullable: true),
                    Value3 = table.Column<string>(nullable: true),
                    Value4 = table.Column<string>(nullable: true),
                    Value5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchConditionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SearchConditionDetails_SearchSettings_SearchSettingId",
                        column: x => x.SearchSettingId,
                        principalTable: "SearchSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SearchConditionDetails_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SearchPersonalSettings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    PrimaryFlag = table.Column<string>(nullable: true),
                    SearchSettingId = table.Column<long>(nullable: false),
                    SortOrder = table.Column<int>(nullable: true),
                    TenantId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchPersonalSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SearchPersonalSettings_SearchSettings_SearchSettingId",
                        column: x => x.SearchSettingId,
                        principalTable: "SearchSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SearchPersonalSettings_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SearchResultDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DisplayFlag = table.Column<string>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    SearchSettingId = table.Column<long>(nullable: false),
                    SeqNum = table.Column<int>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchResultDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SearchResultDetails_SearchSettings_SearchSettingId",
                        column: x => x.SearchSettingId,
                        principalTable: "SearchSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SearchResultDetails_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistories_PreprocessId",
                table: "TrainingHistories",
                column: "PreprocessId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessibleMenus_TenantId_MenuCode_RoleName",
                table: "AccessibleMenus",
                columns: new[] { "TenantId", "MenuCode", "RoleName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_TenantId",
                table: "Annotations",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachFiles_TenantId",
                table: "AttachFiles",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationHistories_DataSetId",
                table: "EvaluationHistories",
                column: "DataSetId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationHistories_TenantId",
                table: "EvaluationHistories",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationHistories_TrainingHistoryId",
                table: "EvaluationHistories",
                column: "TrainingHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InputPersonalSettings_InputSettingId",
                table: "InputPersonalSettings",
                column: "InputSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_InputPersonalSettings_TenantId_InputSettingId_UserId",
                table: "InputPersonalSettings",
                columns: new[] { "TenantId", "InputSettingId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InputSettingDetails_InputSettingId",
                table: "InputSettingDetails",
                column: "InputSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_InputSettingDetails_TenantId_InputSettingId_SeqNum",
                table: "InputSettingDetails",
                columns: new[] { "TenantId", "InputSettingId", "SeqNum" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InputSettings_TenantId",
                table: "InputSettings",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDefs_TenantId_ItemCode_Locale",
                table: "ItemDefs",
                columns: new[] { "TenantId", "ItemCode", "Locale" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobEvents_JobId",
                table: "JobEvents",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobEvents_TenantId",
                table: "JobEvents",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_TenantId",
                table: "Jobs",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_LookUps_TenantId_GroupId_LookUpId_Locale",
                table: "LookUps",
                columns: new[] { "TenantId", "GroupId", "LookUpId", "Locale" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuCode_Locale",
                table: "Menus",
                columns: new[] { "MenuCode", "Locale" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleDetails_TenantId",
                table: "RoleDetails",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDetails_UserId",
                table: "RoleDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDetails_RoleId_TenantId_UserId",
                table: "RoleDetails",
                columns: new[] { "RoleId", "TenantId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SearchConditionDetails_SearchSettingId",
                table: "SearchConditionDetails",
                column: "SearchSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchConditionDetails_TenantId_SearchSettingId_SeqNum",
                table: "SearchConditionDetails",
                columns: new[] { "TenantId", "SearchSettingId", "SeqNum" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SearchPersonalSettings_SearchSettingId",
                table: "SearchPersonalSettings",
                column: "SearchSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchPersonalSettings_TenantId_SearchSettingId_UserId",
                table: "SearchPersonalSettings",
                columns: new[] { "TenantId", "SearchSettingId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SearchResultDetails_SearchSettingId",
                table: "SearchResultDetails",
                column: "SearchSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchResultDetails_TenantId_SearchSettingId_SeqNum",
                table: "SearchResultDetails",
                columns: new[] { "TenantId", "SearchSettingId", "SeqNum" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SearchSettings_TenantId",
                table: "SearchSettings",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_TenantId",
                table: "Statuses",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemMessages_SeqNum_Locale",
                table: "SystemMessages",
                columns: new[] { "SeqNum", "Locale" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PreprocessHistoryOutputs_Data_OutputDataId",
                table: "PreprocessHistoryOutputs",
                column: "OutputDataId",
                principalTable: "Data",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingHistories_Preprocesses_PreprocessId",
                table: "TrainingHistories",
                column: "PreprocessId",
                principalTable: "Preprocesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tenants_DefaultTenantId",
                table: "Users",
                column: "DefaultTenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
