using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFMigrationTool.Migrations
{
    public partial class CreateAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "PortNoSeq",
                startValue: 50001L,
                minValue: 50001L,
                maxValue: 59999L,
                cyclic: true);

            migrationBuilder.CreateTable(
                name: "Gits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ApiUrl = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    GitType = table.Column<string>(nullable: false),
                    Host = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    PortNo = table.Column<int>(nullable: false),
                    PrivateKey = table.Column<string>(nullable: false),
                    RepositoryUrl = table.Column<string>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gits", x => x.Id);
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
                    No = table.Column<long>(nullable: false, defaultValueSql: "nextval('\"PortNoSeq\"')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ApiUrl = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Host = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    PortNo = table.Column<int>(nullable: false),
                    RegistryPath = table.Column<string>(nullable: false),
                    RegistryType = table.Column<string>(nullable: false),
                    RegistryUrl = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DisplayName = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DisplayName = table.Column<string>(nullable: false),
                    GitId = table.Column<long>(nullable: true),
                    LimitCpu = table.Column<decimal>(nullable: true),
                    LimitGpu = table.Column<decimal>(nullable: true),
                    LimitMemory = table.Column<decimal>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    RegistryId = table.Column<long>(nullable: true),
                    StorageAccessKey = table.Column<string>(nullable: true),
                    StorageBucket = table.Column<string>(nullable: true),
                    StorageSecretKey = table.Column<string>(nullable: true),
                    StorageServer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tenants_Gits_GitId",
                        column: x => x.GitId,
                        principalTable: "Gits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tenants_Registries_RegistryId",
                        column: x => x.RegistryId,
                        principalTable: "Registries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClusterTokens",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    KubeToken = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClusterTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClusterTokens_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClusterTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "DataSets",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    xmin = table.Column<uint>(type: "xid", nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataSets_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataTypes",
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
                    table.PrimaryKey("PK_DataTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataTypes_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
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
                    CompletedAt = table.Column<DateTime>(nullable: true),
                    xmin = table.Column<uint>(type: "xid", nullable: false),
                    Configuration = table.Column<string>(nullable: true),
                    Container = table.Column<string>(nullable: false),
                    ContainerStdErrStoredPath = table.Column<string>(nullable: true),
                    ContainerStdOutStoredPath = table.Column<string>(nullable: true),
                    Cpu = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
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
                    TenantId = table.Column<long>(nullable: false)
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
                name: "Preprocesses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CommitId = table.Column<string>(nullable: false),
                    Container = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    EntryPoint = table.Column<string>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    RepositoryName = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preprocesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preprocesses_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Tags",
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
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMappings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    RoleId = table.Column<long>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMappings_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMappings_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMappings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AnnotationId = table.Column<long>(nullable: true),
                    Attribute = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    FileName = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    StoredPath = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Data_Annotations_AnnotationId",
                        column: x => x.AnnotationId,
                        principalTable: "Annotations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Data_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "TrainingHistories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Argument = table.Column<string>(nullable: false),
                    CompletedAt = table.Column<DateTime>(nullable: true),
                    xmin = table.Column<uint>(type: "xid", nullable: false),
                    Configuration = table.Column<string>(nullable: true),
                    Container = table.Column<string>(nullable: false),
                    ContainerStdErrStoredPath = table.Column<string>(nullable: true),
                    ContainerStdOutStoredPath = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DataSetId = table.Column<long>(nullable: false),
                    EntryPoint = table.Column<string>(nullable: true),
                    GpuDriver = table.Column<string>(nullable: true),
                    LogSummary = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    ModelCommitId = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PreTrainingHistoryId = table.Column<long>(nullable: true),
                    PreprocessId = table.Column<long>(nullable: false),
                    Repository = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TenantId = table.Column<long>(nullable: false),
                    TestLogFileName = table.Column<string>(nullable: true),
                    TestLogStoredPath = table.Column<string>(nullable: true),
                    TrainLogFileName = table.Column<string>(nullable: true),
                    TrainLogStoredPath = table.Column<string>(nullable: true),
                    TrainedParameterFileName = table.Column<string>(nullable: true),
                    TrainedParameterStoredPath = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingHistories_DataSets_DataSetId",
                        column: x => x.DataSetId,
                        principalTable: "DataSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingHistories_TrainingHistories_PreTrainingHistoryId",
                        column: x => x.PreTrainingHistoryId,
                        principalTable: "TrainingHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingHistories_Preprocesses_PreprocessId",
                        column: x => x.PreprocessId,
                        principalTable: "Preprocesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingHistories_Tenants_TenantId",
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

            migrationBuilder.CreateTable(
                name: "TagMaps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DataId = table.Column<long>(nullable: false),
                    DataType = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    TagId = table.Column<long>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagMaps_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagMaps_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataSetEntries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DataId = table.Column<long>(nullable: false),
                    DataSetId = table.Column<long>(nullable: false),
                    DataTypeId = table.Column<long>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSetEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataSetEntries_Data_DataId",
                        column: x => x.DataId,
                        principalTable: "Data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataSetEntries_DataSets_DataSetId",
                        column: x => x.DataSetId,
                        principalTable: "DataSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataSetEntries_DataTypes_DataTypeId",
                        column: x => x.DataTypeId,
                        principalTable: "DataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataSetEntries_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreprocessHistories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    DataId = table.Column<long>(nullable: false),
                    ExecutedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    PreprocessId = table.Column<long>(nullable: false),
                    StatusId = table.Column<long>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreprocessHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreprocessHistories_Data_DataId",
                        column: x => x.DataId,
                        principalTable: "Data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreprocessHistories_Preprocesses_PreprocessId",
                        column: x => x.PreprocessId,
                        principalTable: "Preprocesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreprocessHistories_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreprocessHistories_Tenants_TenantId",
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
                    xmin = table.Column<uint>(type: "xid", nullable: false),
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
                name: "TrainingHistoryAttachedFiles",
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
                    TenantId = table.Column<long>(nullable: false),
                    TrainingHistoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingHistoryAttachedFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingHistoryAttachedFiles_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingHistoryAttachedFiles_TrainingHistories_TrainingHistoryId",
                        column: x => x.TrainingHistoryId,
                        principalTable: "TrainingHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TensorBoardContainers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PortId = table.Column<long>(nullable: false),
                    StartedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    TrainingHistoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TensorBoardContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TensorBoardContainers_Ports_PortId",
                        column: x => x.PortId,
                        principalTable: "Ports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TensorBoardContainers_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TensorBoardContainers_TrainingHistories_TrainingHistoryId",
                        column: x => x.TrainingHistoryId,
                        principalTable: "TrainingHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreprocessedImages",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AnnotationFileName = table.Column<string>(nullable: false),
                    AnnotationStoredPath = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ImageFileName = table.Column<string>(nullable: false),
                    ImageStoredPath = table.Column<string>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    PreprocessHistoryId = table.Column<long>(nullable: false),
                    Sequence = table.Column<int>(nullable: false),
                    TenantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreprocessedImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreprocessedImages_PreprocessHistories_PreprocessHistoryId",
                        column: x => x.PreprocessHistoryId,
                        principalTable: "PreprocessHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreprocessedImages_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClusterTokens_TenantId",
                table: "ClusterTokens",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_ClusterTokens_UserId",
                table: "ClusterTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuCode_Locale",
                table: "Menus",
                columns: new[] { "MenuCode", "Locale" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SystemMessages_SeqNum_Locale",
                table: "SystemMessages",
                columns: new[] { "SeqNum", "Locale" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_GitId",
                table: "Tenants",
                column: "GitId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_RegistryId",
                table: "Tenants",
                column: "RegistryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessibleMenus_TenantId",
                table: "AccessibleMenus",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessibleMenus_MenuCode_RoleName",
                table: "AccessibleMenus",
                columns: new[] { "MenuCode", "RoleName" },
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
                name: "IX_Data_AnnotationId",
                table: "Data",
                column: "AnnotationId");

            migrationBuilder.CreateIndex(
                name: "IX_Data_TenantId",
                table: "Data",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSets_TenantId",
                table: "DataSets",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSetEntries_DataId",
                table: "DataSetEntries",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSetEntries_DataSetId",
                table: "DataSetEntries",
                column: "DataSetId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSetEntries_DataTypeId",
                table: "DataSetEntries",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSetEntries_TenantId",
                table: "DataSetEntries",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_DataTypes_TenantId",
                table: "DataTypes",
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
                name: "IX_InputPersonalSettings_TenantId",
                table: "InputPersonalSettings",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_InputPersonalSettings_InputSettingId_UserId",
                table: "InputPersonalSettings",
                columns: new[] { "InputSettingId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InputSettings_TenantId",
                table: "InputSettings",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_InputSettingDetails_TenantId",
                table: "InputSettingDetails",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_InputSettingDetails_InputSettingId_SeqNum",
                table: "InputSettingDetails",
                columns: new[] { "InputSettingId", "SeqNum" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemDefs_TenantId",
                table: "ItemDefs",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDefs_ItemCode_Locale",
                table: "ItemDefs",
                columns: new[] { "ItemCode", "Locale" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_TenantId",
                table: "Jobs",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_LookUps_TenantId",
                table: "LookUps",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_LookUps_GroupId_LookUpId_Locale",
                table: "LookUps",
                columns: new[] { "GroupId", "LookUpId", "Locale" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Preprocesses_TenantId",
                table: "Preprocesses",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_PreprocessedImages_PreprocessHistoryId",
                table: "PreprocessedImages",
                column: "PreprocessHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PreprocessedImages_TenantId",
                table: "PreprocessedImages",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_PreprocessHistories_DataId",
                table: "PreprocessHistories",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_PreprocessHistories_PreprocessId",
                table: "PreprocessHistories",
                column: "PreprocessId");

            migrationBuilder.CreateIndex(
                name: "IX_PreprocessHistories_StatusId",
                table: "PreprocessHistories",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PreprocessHistories_TenantId",
                table: "PreprocessHistories",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchConditionDetails_TenantId",
                table: "SearchConditionDetails",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchConditionDetails_SearchSettingId_SeqNum",
                table: "SearchConditionDetails",
                columns: new[] { "SearchSettingId", "SeqNum" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SearchPersonalSettings_TenantId",
                table: "SearchPersonalSettings",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchPersonalSettings_SearchSettingId_UserId",
                table: "SearchPersonalSettings",
                columns: new[] { "SearchSettingId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SearchResultDetails_TenantId",
                table: "SearchResultDetails",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchResultDetails_SearchSettingId_SeqNum",
                table: "SearchResultDetails",
                columns: new[] { "SearchSettingId", "SeqNum" },
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
                name: "IX_Tags_TenantId",
                table: "Tags",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TagMaps_TagId",
                table: "TagMaps",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_TagMaps_TenantId",
                table: "TagMaps",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistories_DataSetId",
                table: "TrainingHistories",
                column: "DataSetId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistories_PreTrainingHistoryId",
                table: "TrainingHistories",
                column: "PreTrainingHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistories_PreprocessId",
                table: "TrainingHistories",
                column: "PreprocessId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistories_TenantId",
                table: "TrainingHistories",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistoryAttachedFiles_TenantId",
                table: "TrainingHistoryAttachedFiles",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHistoryAttachedFiles_TrainingHistoryId",
                table: "TrainingHistoryAttachedFiles",
                column: "TrainingHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TensorBoardContainers_PortId",
                table: "TensorBoardContainers",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_TensorBoardContainers_TenantId",
                table: "TensorBoardContainers",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TensorBoardContainers_TrainingHistoryId",
                table: "TensorBoardContainers",
                column: "TrainingHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMappings_RoleId",
                table: "UserMappings",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMappings_TenantId",
                table: "UserMappings",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMappings_UserId",
                table: "UserMappings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClusterTokens");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "SystemMessages");

            migrationBuilder.DropTable(
                name: "AccessibleMenus");

            migrationBuilder.DropTable(
                name: "AttachFiles");

            migrationBuilder.DropTable(
                name: "DataSetEntries");

            migrationBuilder.DropTable(
                name: "EvaluationHistories");

            migrationBuilder.DropTable(
                name: "InputPersonalSettings");

            migrationBuilder.DropTable(
                name: "InputSettingDetails");

            migrationBuilder.DropTable(
                name: "ItemDefs");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "LookUps");

            migrationBuilder.DropTable(
                name: "PreprocessedImages");

            migrationBuilder.DropTable(
                name: "SearchConditionDetails");

            migrationBuilder.DropTable(
                name: "SearchPersonalSettings");

            migrationBuilder.DropTable(
                name: "SearchResultDetails");

            migrationBuilder.DropTable(
                name: "TagMaps");

            migrationBuilder.DropTable(
                name: "TrainingHistoryAttachedFiles");

            migrationBuilder.DropTable(
                name: "TensorBoardContainers");

            migrationBuilder.DropTable(
                name: "UserMappings");

            migrationBuilder.DropTable(
                name: "DataTypes");

            migrationBuilder.DropTable(
                name: "InputSettings");

            migrationBuilder.DropTable(
                name: "PreprocessHistories");

            migrationBuilder.DropTable(
                name: "SearchSettings");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Ports");

            migrationBuilder.DropTable(
                name: "TrainingHistories");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Data");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "DataSets");

            migrationBuilder.DropTable(
                name: "Preprocesses");

            migrationBuilder.DropTable(
                name: "Annotations");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropTable(
                name: "Gits");

            migrationBuilder.DropTable(
                name: "Registries");

            migrationBuilder.DropSequence(
                name: "PortNoSeq");
        }
    }
}
