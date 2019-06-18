using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Nssol.Platypus.DataAccess;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFMigrationTool.Migrations
{
    [DbContext(typeof(CommonDbContext))]
    [Migration("20171031064102_AddInputSettingDefaultSortOrder")]
    partial class AddInputSettingDefaultSortOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("Relational:Sequence:.PortNoSeq", "'PortNoSeq', '', '50001', '1', '50001', '59999', 'Int64', 'True'");

            modelBuilder.Entity("Nssol.Platypus.Models.ClusterToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("KubeToken")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.HasIndex("UserId");

                    b.ToTable("ClusterTokens");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.Git", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApiUrl")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("GitType")
                        .IsRequired();

                    b.Property<string>("Host")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<int>("PortNo");

                    b.Property<string>("PrivateKey")
                        .IsRequired();

                    b.Property<string>("RepositoryUrl")
                        .IsRequired();

                    b.Property<string>("Token");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Gits");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.Menu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<string>("Controller");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<string>("Locale")
                        .IsRequired();

                    b.Property<string>("MenuCode")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ParentMenuCode")
                        .IsRequired();

                    b.Property<string>("ShowTopFlag");

                    b.HasKey("Id");

                    b.HasIndex("MenuCode", "Locale")
                        .IsUnique();

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.Port", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Host");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("No")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("nextval('\"PortNoSeq\"')");

                    b.HasKey("Id");

                    b.ToTable("Ports");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.Registry", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApiUrl");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Host")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<int>("PortNo");

                    b.Property<string>("RegistryPath")
                        .IsRequired();

                    b.Property<string>("RegistryType")
                        .IsRequired();

                    b.Property<string>("RegistryUrl")
                        .IsRequired();

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Registries");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.SystemMessage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Locale")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<DateTime>("NotifiedAt");

                    b.Property<string>("SeqNum")
                        .IsRequired();

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SeqNum", "Locale")
                        .IsUnique();

                    b.ToTable("SystemMessages");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.Tenant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<long?>("GitId");

                    b.Property<decimal?>("LimitCpu");

                    b.Property<decimal?>("LimitGpu");

                    b.Property<decimal?>("LimitMemory");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<long?>("RegistryId");

                    b.Property<string>("StorageAccessKey");

                    b.Property<string>("StorageBucket");

                    b.Property<string>("StorageSecretKey");

                    b.Property<string>("StorageServer");

                    b.HasKey("Id");

                    b.HasIndex("GitId");

                    b.HasIndex("RegistryId");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.AccessibleMenu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("MenuCode")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("RoleName")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "MenuCode", "RoleName")
                        .IsUnique();

                    b.ToTable("AccessibleMenus");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Annotation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("StoredPath")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Annotations");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.AttachFile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<byte[]>("Data");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("AttachFiles");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Data", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AnnotationId");

                    b.Property<string>("Attribute");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("StoredPath")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AnnotationId");

                    b.HasIndex("TenantId");

                    b.ToTable("Data");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.DataSet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<uint>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Npgsql:ColumnName", "xmin")
                        .HasAnnotation("Npgsql:ColumnType", "xid");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("DataSets");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.DataSetEntry", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<long>("DataId");

                    b.Property<long>("DataSetId");

                    b.Property<long>("DataTypeId");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("DataId");

                    b.HasIndex("DataSetId");

                    b.HasIndex("DataTypeId");

                    b.HasIndex("TenantId");

                    b.ToTable("DataSetEntries");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.DataType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("DataTypes");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.EvaluationHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Argument")
                        .IsRequired();

                    b.Property<DateTime?>("CompletedAt");

                    b.Property<uint>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Npgsql:ColumnName", "xmin")
                        .HasAnnotation("Npgsql:ColumnType", "xid");

                    b.Property<string>("Container")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<long?>("DataSetId");

                    b.Property<string>("EvalLogFileName");

                    b.Property<string>("EvalLogStoredPath");

                    b.Property<string>("EvalResultFileName");

                    b.Property<string>("EvalResultStoredPath");

                    b.Property<string>("GpuDriver");

                    b.Property<string>("LogSummary");

                    b.Property<string>("Memo");

                    b.Property<string>("ModelCommitId")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.Property<long>("TrainingHistoryId");

                    b.HasKey("Id");

                    b.HasIndex("DataSetId");

                    b.HasIndex("TenantId");

                    b.HasIndex("TrainingHistoryId");

                    b.ToTable("EvaluationHistories");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.InputPersonalSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<long>("InputSettingId");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("PrimaryFlag");

                    b.Property<int?>("SortOrder");

                    b.Property<long>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("InputSettingId");

                    b.HasIndex("TenantId", "InputSettingId", "UserId")
                        .IsUnique();

                    b.ToTable("InputPersonalSettings");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.InputSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<int?>("DefaultSortOrder");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long?>("RoleId");

                    b.Property<string>("ShareType")
                        .IsRequired();

                    b.Property<string>("TargetType")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.Property<string>("UseType")
                        .IsRequired();

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("InputSettings");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.InputSettingDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<long>("InputSettingId");

                    b.Property<string>("ItemCode");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<int>("SeqNum");

                    b.Property<long>("TenantId");

                    b.Property<string>("Value1");

                    b.Property<string>("Value2");

                    b.Property<string>("Value3");

                    b.Property<string>("Value4");

                    b.Property<string>("Value5");

                    b.HasKey("Id");

                    b.HasIndex("InputSettingId");

                    b.HasIndex("TenantId", "InputSettingId", "SeqNum")
                        .IsUnique();

                    b.ToTable("InputSettingDetails");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.ItemDef", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("DataType");

                    b.Property<string>("DefaultValue1");

                    b.Property<string>("DefaultValue2");

                    b.Property<string>("DefaultValue3");

                    b.Property<string>("DefaultValue4");

                    b.Property<string>("DefaultValue5");

                    b.Property<int?>("Digit");

                    b.Property<int?>("DisplayWidth");

                    b.Property<string>("GroupId");

                    b.Property<string>("ItemCode")
                        .IsRequired();

                    b.Property<string>("ItemName");

                    b.Property<string>("Locale")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Required");

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "ItemCode", "Locale")
                        .IsUnique();

                    b.ToTable("ItemDefs");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Job", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AllArgument1");

                    b.Property<string>("AllArgument2");

                    b.Property<string>("AllArgument3");

                    b.Property<string>("AllArgument4");

                    b.Property<string>("AllArgument5");

                    b.Property<string>("Argument1");

                    b.Property<string>("Argument2");

                    b.Property<string>("Argument3");

                    b.Property<string>("Argument4");

                    b.Property<string>("Argument5");

                    b.Property<string>("AssignedPort1");

                    b.Property<string>("AssignedPort2");

                    b.Property<string>("AssignedPort3");

                    b.Property<string>("AssignedPort4");

                    b.Property<string>("AssignedPort5");

                    b.Property<DateTime?>("CompletedAt");

                    b.Property<uint>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Npgsql:ColumnName", "xmin")
                        .HasAnnotation("Npgsql:ColumnType", "xid");

                    b.Property<string>("Configuration");

                    b.Property<string>("Container")
                        .IsRequired();

                    b.Property<string>("ContainerStdErrStoredPath");

                    b.Property<string>("ContainerStdOutStoredPath");

                    b.Property<int>("Cpu");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("EntryPoint1");

                    b.Property<string>("EntryPoint2");

                    b.Property<string>("EntryPoint3");

                    b.Property<string>("EntryPoint4");

                    b.Property<string>("EntryPoint5");

                    b.Property<long>("ExecUserId");

                    b.Property<string>("ExecUserName")
                        .IsRequired();

                    b.Property<int>("Gpu");

                    b.Property<string>("GpuDriver");

                    b.Property<string>("Group");

                    b.Property<string>("InParam1");

                    b.Property<string>("InParam2");

                    b.Property<string>("InParam3");

                    b.Property<string>("InParam4");

                    b.Property<string>("InParam5");

                    b.Property<string>("InputDataType")
                        .IsRequired();

                    b.Property<string>("JobType")
                        .IsRequired();

                    b.Property<string>("LogSummary");

                    b.Property<string>("Memo");

                    b.Property<int>("Memory");

                    b.Property<string>("ModelCommitId");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NodeName");

                    b.Property<string>("OutParam1");

                    b.Property<string>("OutParam10");

                    b.Property<string>("OutParam2");

                    b.Property<string>("OutParam3");

                    b.Property<string>("OutParam4");

                    b.Property<string>("OutParam5");

                    b.Property<string>("OutParam6");

                    b.Property<string>("OutParam7");

                    b.Property<string>("OutParam8");

                    b.Property<string>("OutParam9");

                    b.Property<long?>("PortId1");

                    b.Property<long?>("PortId2");

                    b.Property<long?>("PortId3");

                    b.Property<long?>("PortId4");

                    b.Property<long?>("PortId5");

                    b.Property<long?>("PrevJobId");

                    b.Property<string>("Repository");

                    b.Property<DateTime?>("StartAt");

                    b.Property<string>("StartUpType")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.LookUp", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("GroupId")
                        .IsRequired();

                    b.Property<string>("Locale")
                        .IsRequired();

                    b.Property<string>("LookUpId")
                        .IsRequired();

                    b.Property<string>("LookUpName");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("SortOrder");

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "GroupId", "LookUpId", "Locale")
                        .IsUnique();

                    b.ToTable("LookUps");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Preprocess", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommitId")
                        .IsRequired();

                    b.Property<string>("Container")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("EntryPoint")
                        .IsRequired();

                    b.Property<string>("Memo");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("RepositoryName")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Preprocesses");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.PreprocessedImage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnnotationFileName")
                        .IsRequired();

                    b.Property<string>("AnnotationStoredPath")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("ImageFileName")
                        .IsRequired();

                    b.Property<string>("ImageStoredPath")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("PreprocessHistoryId");

                    b.Property<int>("Sequence");

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("PreprocessHistoryId");

                    b.HasIndex("TenantId");

                    b.ToTable("PreprocessedImages");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.PreprocessHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<long>("DataId");

                    b.Property<DateTime>("ExecutedAt");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("PreprocessId");

                    b.Property<long>("StatusId");

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("DataId");

                    b.HasIndex("PreprocessId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TenantId");

                    b.ToTable("PreprocessHistories");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.SearchConditionDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("ItemCode");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("SearchSettingId");

                    b.Property<string>("SearchType");

                    b.Property<int>("SeqNum");

                    b.Property<long>("TenantId");

                    b.Property<string>("Value1");

                    b.Property<string>("Value2");

                    b.Property<string>("Value3");

                    b.Property<string>("Value4");

                    b.Property<string>("Value5");

                    b.HasKey("Id");

                    b.HasIndex("SearchSettingId");

                    b.HasIndex("TenantId", "SearchSettingId", "SeqNum")
                        .IsUnique();

                    b.ToTable("SearchConditionDetails");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.SearchPersonalSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("PrimaryFlag");

                    b.Property<long>("SearchSettingId");

                    b.Property<int?>("SortOrder");

                    b.Property<long>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SearchSettingId");

                    b.HasIndex("TenantId", "SearchSettingId", "UserId")
                        .IsUnique();

                    b.ToTable("SearchPersonalSettings");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.SearchResultDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("DisplayFlag");

                    b.Property<string>("ItemCode");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("SearchSettingId");

                    b.Property<int>("SeqNum");

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("SearchSettingId");

                    b.HasIndex("TenantId", "SearchSettingId", "SeqNum")
                        .IsUnique();

                    b.ToTable("SearchResultDetails");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.SearchSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("FirstSortItem");

                    b.Property<string>("FirstSortType");

                    b.Property<int>("LineNumber");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long?>("RoleId");

                    b.Property<string>("SecondSortItem");

                    b.Property<string>("SecondSortType");

                    b.Property<string>("ShareType")
                        .IsRequired();

                    b.Property<string>("TargetType")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.Property<string>("UseType")
                        .IsRequired();

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("SearchSettings");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Status", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.TagMap", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<long>("DataId");

                    b.Property<string>("DataType")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("TagId");

                    b.Property<long>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("TenantId");

                    b.ToTable("TagMaps");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.TrainingHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Argument")
                        .IsRequired();

                    b.Property<DateTime?>("CompletedAt");

                    b.Property<uint>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Npgsql:ColumnName", "xmin")
                        .HasAnnotation("Npgsql:ColumnType", "xid");

                    b.Property<string>("Configuration");

                    b.Property<string>("Container")
                        .IsRequired();

                    b.Property<string>("ContainerStdErrStoredPath");

                    b.Property<string>("ContainerStdOutStoredPath");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<long>("DataSetId");

                    b.Property<string>("EntryPoint");

                    b.Property<string>("GpuDriver");

                    b.Property<string>("LogSummary");

                    b.Property<string>("Memo");

                    b.Property<string>("ModelCommitId")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<long?>("PreTrainingHistoryId");

                    b.Property<long>("PreprocessId");

                    b.Property<string>("Repository");

                    b.Property<string>("Status");

                    b.Property<long>("TenantId");

                    b.Property<string>("TestLogFileName");

                    b.Property<string>("TestLogStoredPath");

                    b.Property<string>("TrainLogFileName");

                    b.Property<string>("TrainLogStoredPath");

                    b.Property<string>("TrainedParameterFileName");

                    b.Property<string>("TrainedParameterStoredPath");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.HasIndex("DataSetId");

                    b.HasIndex("PreTrainingHistoryId");

                    b.HasIndex("PreprocessId");

                    b.HasIndex("TenantId");

                    b.ToTable("TrainingHistories");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.TrainingHistoryAttachedFile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("StoredPath")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.Property<long>("TrainingHistoryId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.HasIndex("TrainingHistoryId");

                    b.ToTable("TrainingHistoryAttachedFiles");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TensorBoardContainer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("PortId");

                    b.Property<DateTime>("StartedAt");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<long>("TenantId");

                    b.Property<long>("TrainingHistoryId");

                    b.HasKey("Id");

                    b.HasIndex("PortId");

                    b.HasIndex("TenantId");

                    b.HasIndex("TrainingHistoryId");

                    b.ToTable("TensorBoardContainers");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.UserMapping", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<long>("RoleId");

                    b.Property<long>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("TenantId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMappings");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.ClusterToken", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.Tenant", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Git", "Git")
                        .WithMany()
                        .HasForeignKey("GitId");

                    b.HasOne("Nssol.Platypus.Models.Registry", "Registry")
                        .WithMany()
                        .HasForeignKey("RegistryId");
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.AccessibleMenu", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Annotation", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.AttachFile", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Data", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.Annotation", "Annotation")
                        .WithMany()
                        .HasForeignKey("AnnotationId");

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.DataSet", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.DataSetEntry", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.Data", "Data")
                        .WithMany()
                        .HasForeignKey("DataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.TenantModels.DataSet", "DataSet")
                        .WithMany("DataSetEntry")
                        .HasForeignKey("DataSetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.TenantModels.DataType", "DataType")
                        .WithMany()
                        .HasForeignKey("DataTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.DataType", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.EvaluationHistory", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.DataSet", "DataSet")
                        .WithMany()
                        .HasForeignKey("DataSetId");

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.TenantModels.TrainingHistory", "TrainingHistory")
                        .WithMany()
                        .HasForeignKey("TrainingHistoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.InputPersonalSetting", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.InputSetting", "InputSetting")
                        .WithMany()
                        .HasForeignKey("InputSettingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.InputSetting", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.InputSettingDetail", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.InputSetting", "InputSetting")
                        .WithMany()
                        .HasForeignKey("InputSettingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.ItemDef", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Job", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.LookUp", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Preprocess", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.PreprocessedImage", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.PreprocessHistory", "PreprocessHistory")
                        .WithMany()
                        .HasForeignKey("PreprocessHistoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.PreprocessHistory", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.Data", "Data")
                        .WithMany()
                        .HasForeignKey("DataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.TenantModels.Preprocess", "Preprocess")
                        .WithMany()
                        .HasForeignKey("PreprocessId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.TenantModels.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.SearchConditionDetail", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.SearchSetting", "SearchSetting")
                        .WithMany()
                        .HasForeignKey("SearchSettingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.SearchPersonalSetting", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.SearchSetting", "SearchSetting")
                        .WithMany()
                        .HasForeignKey("SearchSettingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.SearchResultDetail", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.SearchSetting", "SearchSetting")
                        .WithMany()
                        .HasForeignKey("SearchSettingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.SearchSetting", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Status", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.Tag", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.TagMap", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.TrainingHistory", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.TenantModels.DataSet", "DataSet")
                        .WithMany()
                        .HasForeignKey("DataSetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.TenantModels.TrainingHistory", "PreTrainingHistory")
                        .WithMany()
                        .HasForeignKey("PreTrainingHistoryId");

                    b.HasOne("Nssol.Platypus.Models.TenantModels.Preprocess", "Preprocess")
                        .WithMany()
                        .HasForeignKey("PreprocessId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TenantModels.TrainingHistoryAttachedFile", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.TenantModels.TrainingHistory", "TrainingHistory")
                        .WithMany("TrainingHistoryAttachedFile")
                        .HasForeignKey("TrainingHistoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.TensorBoardContainer", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Port", "Port")
                        .WithMany()
                        .HasForeignKey("PortId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.TenantModels.TrainingHistory", "TrainingHistory")
                        .WithMany()
                        .HasForeignKey("TrainingHistoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nssol.Platypus.Models.UserMapping", b =>
                {
                    b.HasOne("Nssol.Platypus.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nssol.Platypus.Models.User", "User")
                        .WithMany("UserMappings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
