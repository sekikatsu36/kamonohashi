ALTER TABLE "InferenceHistory" DROP CONSTRAINT "FK_InferenceHistory_Registries_ContainerRegistryId";

ALTER TABLE "InferenceHistory" DROP CONSTRAINT "FK_InferenceHistory_DataSets_DataSetId";

ALTER TABLE "InferenceHistory" DROP CONSTRAINT "FK_InferenceHistory_TrainingHistories_ParentId";

ALTER TABLE "InferenceHistory" DROP CONSTRAINT "FK_InferenceHistory_Tenants_TenantId";

ALTER TABLE "InferenceHistoryAttachedFile" DROP CONSTRAINT "FK_InferenceHistoryAttachedFile_InferenceHistory_InferenceHist~";

ALTER TABLE "InferenceHistoryAttachedFile" DROP CONSTRAINT "FK_InferenceHistoryAttachedFile_Tenants_TenantId";

ALTER TABLE "Tenants" DROP CONSTRAINT "FK_Tenants_Gits_DefaultGitId";

ALTER TABLE "Tenants" DROP CONSTRAINT "FK_Tenants_Registries_RegistryId";

ALTER TABLE "TrainingHistories" DROP CONSTRAINT "FK_TrainingHistories_Registries_ContainerRegistryId";

DROP INDEX "IX_UserTenantRegistryMaps_UserId";

DROP INDEX "IX_UserRoleMaps_UserId";

DROP INDEX "IX_Tenants_RegistryId";

DROP INDEX "IX_TenantRegistryMaps_TenantId";

DROP INDEX "IX_TenantGitMaps_TenantId";

DROP INDEX "IX_NodeTenantMaps_NodeId";

ALTER TABLE "InferenceHistoryAttachedFile" DROP CONSTRAINT "PK_InferenceHistoryAttachedFile";

ALTER TABLE "InferenceHistory" DROP CONSTRAINT "PK_InferenceHistory";

ALTER TABLE "Tenants" ALTER COLUMN "RegistryId" TYPE bigint;
ALTER TABLE "Tenants" ALTER COLUMN "RegistryId" SET NOT NULL;
ALTER TABLE "Tenants" ALTER COLUMN "RegistryId" DROP DEFAULT;

ALTER TABLE "Tenants" RENAME COLUMN "RegistryId" TO "DefaultRegistryId";

ALTER TABLE "InferenceHistoryAttachedFile" RENAME TO "InferenceHistoryAttachedFiles";

ALTER TABLE "InferenceHistory" RENAME TO "InferenceHistories";

ALTER INDEX "IX_InferenceHistoryAttachedFile_TenantId" RENAME TO "IX_InferenceHistoryAttachedFiles_TenantId";

ALTER INDEX "IX_InferenceHistoryAttachedFile_InferenceHistoryId" RENAME TO "IX_InferenceHistoryAttachedFiles_InferenceHistoryId";

ALTER INDEX "IX_InferenceHistory_TenantId" RENAME TO "IX_InferenceHistories_TenantId";

ALTER INDEX "IX_InferenceHistory_ParentId" RENAME TO "IX_InferenceHistories_ParentId";

ALTER INDEX "IX_InferenceHistory_DataSetId" RENAME TO "IX_InferenceHistories_DataSetId";

ALTER INDEX "IX_InferenceHistory_ContainerRegistryId" RENAME TO "IX_InferenceHistories_ContainerRegistryId";

ALTER TABLE "TrainingHistories" ALTER COLUMN "ContainerRegistryId" TYPE bigint;
ALTER TABLE "TrainingHistories" ALTER COLUMN "ContainerRegistryId" SET NOT NULL;
ALTER TABLE "TrainingHistories" ALTER COLUMN "ContainerRegistryId" DROP DEFAULT;

ALTER TABLE "Tenants" ALTER COLUMN "DefaultGitId" TYPE bigint;
ALTER TABLE "Tenants" ALTER COLUMN "DefaultGitId" SET NOT NULL;
ALTER TABLE "Tenants" ALTER COLUMN "DefaultGitId" DROP DEFAULT;

ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelRepositoryOwner" TYPE text;
ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelRepositoryOwner" SET NOT NULL;
ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelRepositoryOwner" DROP DEFAULT;

ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelRepository" TYPE text;
ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelRepository" SET NOT NULL;
ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelRepository" DROP DEFAULT;

ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelGitId" TYPE bigint;
ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelGitId" SET NOT NULL;
ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelGitId" DROP DEFAULT;

ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelCommitId" TYPE text;
ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelCommitId" SET NOT NULL;
ALTER TABLE "InferenceHistories" ALTER COLUMN "ModelCommitId" DROP DEFAULT;

ALTER TABLE "InferenceHistories" ALTER COLUMN "ContainerRegistryId" TYPE bigint;
ALTER TABLE "InferenceHistories" ALTER COLUMN "ContainerRegistryId" SET NOT NULL;
ALTER TABLE "InferenceHistories" ALTER COLUMN "ContainerRegistryId" DROP DEFAULT;

ALTER TABLE "InferenceHistoryAttachedFiles" ADD CONSTRAINT "PK_InferenceHistoryAttachedFiles" PRIMARY KEY ("Id");

ALTER TABLE "InferenceHistories" ADD CONSTRAINT "PK_InferenceHistories" PRIMARY KEY ("Id");

CREATE TABLE "Settings" (
    "Id" bigserial NOT NULL,
    "CreatedBy" text NOT NULL,
    "CreatedAt" timestamp without time zone NOT NULL,
    "ModifiedBy" text NOT NULL,
    "ModifiedAt" timestamp without time zone NOT NULL,
    "EnsureSingleRow" integer NOT NULL,
    "ApiSecurityTokenPass" text NOT NULL,
    CONSTRAINT "PK_Settings" PRIMARY KEY ("Id")
);

CREATE UNIQUE INDEX "IX_UserTenantRegistryMaps_UserId_TenantRegistryMapId" ON "UserTenantRegistryMaps" ("UserId", "TenantRegistryMapId");

CREATE UNIQUE INDEX "IX_UserRoleMaps_UserId_RoleId_TenantMapId" ON "UserRoleMaps" ("UserId", "RoleId", "TenantMapId");

CREATE INDEX "IX_Tenants_DefaultRegistryId" ON "Tenants" ("DefaultRegistryId");

CREATE UNIQUE INDEX "IX_TenantRegistryMaps_TenantId_RegistryId" ON "TenantRegistryMaps" ("TenantId", "RegistryId");

CREATE UNIQUE INDEX "IX_TenantGitMaps_TenantId_GitId" ON "TenantGitMaps" ("TenantId", "GitId");

CREATE UNIQUE INDEX "IX_NodeTenantMaps_NodeId_TenantId" ON "NodeTenantMaps" ("NodeId", "TenantId");

CREATE UNIQUE INDEX "IX_MenuRoleMaps_MenuCode_RoleId" ON "MenuRoleMaps" ("MenuCode", "RoleId");

CREATE UNIQUE INDEX "IX_Settings_ApiSecurityTokenPass" ON "Settings" ("ApiSecurityTokenPass");

ALTER TABLE "InferenceHistories" ADD CONSTRAINT "FK_InferenceHistories_Registries_ContainerRegistryId" FOREIGN KEY ("ContainerRegistryId") REFERENCES "Registries" ("Id") ON DELETE CASCADE;

ALTER TABLE "InferenceHistories" ADD CONSTRAINT "FK_InferenceHistories_DataSets_DataSetId" FOREIGN KEY ("DataSetId") REFERENCES "DataSets" ("Id") ON DELETE CASCADE;

ALTER TABLE "InferenceHistories" ADD CONSTRAINT "FK_InferenceHistories_TrainingHistories_ParentId" FOREIGN KEY ("ParentId") REFERENCES "TrainingHistories" ("Id") ON DELETE RESTRICT;

ALTER TABLE "InferenceHistories" ADD CONSTRAINT "FK_InferenceHistories_Tenants_TenantId" FOREIGN KEY ("TenantId") REFERENCES "Tenants" ("Id") ON DELETE CASCADE;

ALTER TABLE "InferenceHistoryAttachedFiles" ADD CONSTRAINT "FK_InferenceHistoryAttachedFiles_InferenceHistories_InferenceH~" FOREIGN KEY ("InferenceHistoryId") REFERENCES "InferenceHistories" ("Id") ON DELETE CASCADE;

ALTER TABLE "InferenceHistoryAttachedFiles" ADD CONSTRAINT "FK_InferenceHistoryAttachedFiles_Tenants_TenantId" FOREIGN KEY ("TenantId") REFERENCES "Tenants" ("Id") ON DELETE CASCADE;

ALTER TABLE "Tenants" ADD CONSTRAINT "FK_Tenants_Gits_DefaultGitId" FOREIGN KEY ("DefaultGitId") REFERENCES "Gits" ("Id") ON DELETE CASCADE;

ALTER TABLE "Tenants" ADD CONSTRAINT "FK_Tenants_Registries_DefaultRegistryId" FOREIGN KEY ("DefaultRegistryId") REFERENCES "Registries" ("Id") ON DELETE CASCADE;

ALTER TABLE "TrainingHistories" ADD CONSTRAINT "FK_TrainingHistories_Registries_ContainerRegistryId" FOREIGN KEY ("ContainerRegistryId") REFERENCES "Registries" ("Id") ON DELETE CASCADE;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20190618031602_UpdateForPrivateVer', '2.1.4-rtm-31024');

