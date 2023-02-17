using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Naming1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtmAtmService_AtmService_AtmServicesAtmServiceId",
                table: "AtmAtmService");

            migrationBuilder.DropForeignKey(
                name: "FK_AtmCardScheme_CardScheme_AtmCardSchemesCardSchemeId",
                table: "AtmCardScheme");

            migrationBuilder.DropForeignKey(
                name: "FK_AtmDay_AtmBreak_AtmBreakId",
                table: "AtmDay");

            migrationBuilder.DropForeignKey(
                name: "FK_AtmDay_AtmStandardAvailability_AtmStandardAvailabilityId",
                table: "AtmDay");

            migrationBuilder.DropForeignKey(
                name: "FK_Atms_AtmType_AtmTypeId",
                table: "Atms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardScheme",
                table: "CardScheme");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtmType",
                table: "AtmType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtmService",
                table: "AtmService");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtmDay",
                table: "AtmDay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtmBreak",
                table: "AtmBreak");

            migrationBuilder.RenameTable(
                name: "CardScheme",
                newName: "CardSchemes");

            migrationBuilder.RenameTable(
                name: "AtmType",
                newName: "AtmTypes");

            migrationBuilder.RenameTable(
                name: "AtmService",
                newName: "AtmServices");

            migrationBuilder.RenameTable(
                name: "AtmDay",
                newName: "AtmDays");

            migrationBuilder.RenameTable(
                name: "AtmBreak",
                newName: "AtmBreaks");

            migrationBuilder.RenameIndex(
                name: "IX_AtmDay_AtmStandardAvailabilityId",
                table: "AtmDays",
                newName: "IX_AtmDays_AtmStandardAvailabilityId");

            migrationBuilder.RenameIndex(
                name: "IX_AtmDay_AtmBreakId",
                table: "AtmDays",
                newName: "IX_AtmDays_AtmBreakId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardSchemes",
                table: "CardSchemes",
                column: "CardSchemeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtmTypes",
                table: "AtmTypes",
                column: "AtmTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtmServices",
                table: "AtmServices",
                column: "AtmServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtmDays",
                table: "AtmDays",
                column: "AtmDayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtmBreaks",
                table: "AtmBreaks",
                column: "AtmBreakId");

            migrationBuilder.AddForeignKey(
                name: "FK_AtmAtmService_AtmServices_AtmServicesAtmServiceId",
                table: "AtmAtmService",
                column: "AtmServicesAtmServiceId",
                principalTable: "AtmServices",
                principalColumn: "AtmServiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtmCardScheme_CardSchemes_AtmCardSchemesCardSchemeId",
                table: "AtmCardScheme",
                column: "AtmCardSchemesCardSchemeId",
                principalTable: "CardSchemes",
                principalColumn: "CardSchemeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtmDays_AtmBreaks_AtmBreakId",
                table: "AtmDays",
                column: "AtmBreakId",
                principalTable: "AtmBreaks",
                principalColumn: "AtmBreakId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtmDays_AtmStandardAvailability_AtmStandardAvailabilityId",
                table: "AtmDays",
                column: "AtmStandardAvailabilityId",
                principalTable: "AtmStandardAvailability",
                principalColumn: "AtmStandardAvailabilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atms_AtmTypes_AtmTypeId",
                table: "Atms",
                column: "AtmTypeId",
                principalTable: "AtmTypes",
                principalColumn: "AtmTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtmAtmService_AtmServices_AtmServicesAtmServiceId",
                table: "AtmAtmService");

            migrationBuilder.DropForeignKey(
                name: "FK_AtmCardScheme_CardSchemes_AtmCardSchemesCardSchemeId",
                table: "AtmCardScheme");

            migrationBuilder.DropForeignKey(
                name: "FK_AtmDays_AtmBreaks_AtmBreakId",
                table: "AtmDays");

            migrationBuilder.DropForeignKey(
                name: "FK_AtmDays_AtmStandardAvailability_AtmStandardAvailabilityId",
                table: "AtmDays");

            migrationBuilder.DropForeignKey(
                name: "FK_Atms_AtmTypes_AtmTypeId",
                table: "Atms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardSchemes",
                table: "CardSchemes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtmTypes",
                table: "AtmTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtmServices",
                table: "AtmServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtmDays",
                table: "AtmDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtmBreaks",
                table: "AtmBreaks");

            migrationBuilder.RenameTable(
                name: "CardSchemes",
                newName: "CardScheme");

            migrationBuilder.RenameTable(
                name: "AtmTypes",
                newName: "AtmType");

            migrationBuilder.RenameTable(
                name: "AtmServices",
                newName: "AtmService");

            migrationBuilder.RenameTable(
                name: "AtmDays",
                newName: "AtmDay");

            migrationBuilder.RenameTable(
                name: "AtmBreaks",
                newName: "AtmBreak");

            migrationBuilder.RenameIndex(
                name: "IX_AtmDays_AtmStandardAvailabilityId",
                table: "AtmDay",
                newName: "IX_AtmDay_AtmStandardAvailabilityId");

            migrationBuilder.RenameIndex(
                name: "IX_AtmDays_AtmBreakId",
                table: "AtmDay",
                newName: "IX_AtmDay_AtmBreakId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardScheme",
                table: "CardScheme",
                column: "CardSchemeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtmType",
                table: "AtmType",
                column: "AtmTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtmService",
                table: "AtmService",
                column: "AtmServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtmDay",
                table: "AtmDay",
                column: "AtmDayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtmBreak",
                table: "AtmBreak",
                column: "AtmBreakId");

            migrationBuilder.AddForeignKey(
                name: "FK_AtmAtmService_AtmService_AtmServicesAtmServiceId",
                table: "AtmAtmService",
                column: "AtmServicesAtmServiceId",
                principalTable: "AtmService",
                principalColumn: "AtmServiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtmCardScheme_CardScheme_AtmCardSchemesCardSchemeId",
                table: "AtmCardScheme",
                column: "AtmCardSchemesCardSchemeId",
                principalTable: "CardScheme",
                principalColumn: "CardSchemeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtmDay_AtmBreak_AtmBreakId",
                table: "AtmDay",
                column: "AtmBreakId",
                principalTable: "AtmBreak",
                principalColumn: "AtmBreakId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtmDay_AtmStandardAvailability_AtmStandardAvailabilityId",
                table: "AtmDay",
                column: "AtmStandardAvailabilityId",
                principalTable: "AtmStandardAvailability",
                principalColumn: "AtmStandardAvailabilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atms_AtmType_AtmTypeId",
                table: "Atms",
                column: "AtmTypeId",
                principalTable: "AtmType",
                principalColumn: "AtmTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
