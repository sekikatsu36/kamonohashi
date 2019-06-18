using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationTool.Migrations
{
    public partial class UpdateUkInLookup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SearchResultDetails_TenantId",
                table: "SearchResultDetails");

            migrationBuilder.DropIndex(
                name: "IX_SearchResultDetails_SearchSettingId_SeqNum",
                table: "SearchResultDetails");

            migrationBuilder.DropIndex(
                name: "IX_SearchPersonalSettings_TenantId",
                table: "SearchPersonalSettings");

            migrationBuilder.DropIndex(
                name: "IX_SearchPersonalSettings_SearchSettingId_UserId",
                table: "SearchPersonalSettings");

            migrationBuilder.DropIndex(
                name: "IX_SearchConditionDetails_TenantId",
                table: "SearchConditionDetails");

            migrationBuilder.DropIndex(
                name: "IX_SearchConditionDetails_SearchSettingId_SeqNum",
                table: "SearchConditionDetails");

            migrationBuilder.DropIndex(
                name: "IX_LookUps_TenantId",
                table: "LookUps");

            migrationBuilder.DropIndex(
                name: "IX_LookUps_GroupId_LookUpId_Locale",
                table: "LookUps");

            migrationBuilder.DropIndex(
                name: "IX_ItemDefs_TenantId",
                table: "ItemDefs");

            migrationBuilder.DropIndex(
                name: "IX_ItemDefs_ItemCode_Locale",
                table: "ItemDefs");

            migrationBuilder.DropIndex(
                name: "IX_InputSettingDetails_TenantId",
                table: "InputSettingDetails");

            migrationBuilder.DropIndex(
                name: "IX_InputSettingDetails_InputSettingId_SeqNum",
                table: "InputSettingDetails");

            migrationBuilder.DropIndex(
                name: "IX_InputPersonalSettings_TenantId",
                table: "InputPersonalSettings");

            migrationBuilder.DropIndex(
                name: "IX_InputPersonalSettings_InputSettingId_UserId",
                table: "InputPersonalSettings");

            migrationBuilder.DropIndex(
                name: "IX_AccessibleMenus_TenantId",
                table: "AccessibleMenus");

            migrationBuilder.DropIndex(
                name: "IX_AccessibleMenus_MenuCode_RoleName",
                table: "AccessibleMenus");

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
                name: "IX_SearchPersonalSettings_SearchSettingId",
                table: "SearchPersonalSettings",
                column: "SearchSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchPersonalSettings_TenantId_SearchSettingId_UserId",
                table: "SearchPersonalSettings",
                columns: new[] { "TenantId", "SearchSettingId", "UserId" },
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
                name: "IX_LookUps_TenantId_GroupId_LookUpId_Locale",
                table: "LookUps",
                columns: new[] { "TenantId", "GroupId", "LookUpId", "Locale" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemDefs_TenantId_ItemCode_Locale",
                table: "ItemDefs",
                columns: new[] { "TenantId", "ItemCode", "Locale" },
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
                name: "IX_InputPersonalSettings_InputSettingId",
                table: "InputPersonalSettings",
                column: "InputSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_InputPersonalSettings_TenantId_InputSettingId_UserId",
                table: "InputPersonalSettings",
                columns: new[] { "TenantId", "InputSettingId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccessibleMenus_TenantId_MenuCode_RoleName",
                table: "AccessibleMenus",
                columns: new[] { "TenantId", "MenuCode", "RoleName" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SearchResultDetails_SearchSettingId",
                table: "SearchResultDetails");

            migrationBuilder.DropIndex(
                name: "IX_SearchResultDetails_TenantId_SearchSettingId_SeqNum",
                table: "SearchResultDetails");

            migrationBuilder.DropIndex(
                name: "IX_SearchPersonalSettings_SearchSettingId",
                table: "SearchPersonalSettings");

            migrationBuilder.DropIndex(
                name: "IX_SearchPersonalSettings_TenantId_SearchSettingId_UserId",
                table: "SearchPersonalSettings");

            migrationBuilder.DropIndex(
                name: "IX_SearchConditionDetails_SearchSettingId",
                table: "SearchConditionDetails");

            migrationBuilder.DropIndex(
                name: "IX_SearchConditionDetails_TenantId_SearchSettingId_SeqNum",
                table: "SearchConditionDetails");

            migrationBuilder.DropIndex(
                name: "IX_LookUps_TenantId_GroupId_LookUpId_Locale",
                table: "LookUps");

            migrationBuilder.DropIndex(
                name: "IX_ItemDefs_TenantId_ItemCode_Locale",
                table: "ItemDefs");

            migrationBuilder.DropIndex(
                name: "IX_InputSettingDetails_InputSettingId",
                table: "InputSettingDetails");

            migrationBuilder.DropIndex(
                name: "IX_InputSettingDetails_TenantId_InputSettingId_SeqNum",
                table: "InputSettingDetails");

            migrationBuilder.DropIndex(
                name: "IX_InputPersonalSettings_InputSettingId",
                table: "InputPersonalSettings");

            migrationBuilder.DropIndex(
                name: "IX_InputPersonalSettings_TenantId_InputSettingId_UserId",
                table: "InputPersonalSettings");

            migrationBuilder.DropIndex(
                name: "IX_AccessibleMenus_TenantId_MenuCode_RoleName",
                table: "AccessibleMenus");

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
                name: "IX_SearchPersonalSettings_TenantId",
                table: "SearchPersonalSettings",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchPersonalSettings_SearchSettingId_UserId",
                table: "SearchPersonalSettings",
                columns: new[] { "SearchSettingId", "UserId" },
                unique: true);

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
                name: "IX_LookUps_TenantId",
                table: "LookUps",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_LookUps_GroupId_LookUpId_Locale",
                table: "LookUps",
                columns: new[] { "GroupId", "LookUpId", "Locale" },
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
                name: "IX_InputSettingDetails_TenantId",
                table: "InputSettingDetails",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_InputSettingDetails_InputSettingId_SeqNum",
                table: "InputSettingDetails",
                columns: new[] { "InputSettingId", "SeqNum" },
                unique: true);

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
                name: "IX_AccessibleMenus_TenantId",
                table: "AccessibleMenus",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessibleMenus_MenuCode_RoleName",
                table: "AccessibleMenus",
                columns: new[] { "MenuCode", "RoleName" },
                unique: true);
        }
    }
}
