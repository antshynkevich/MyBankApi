using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SomeFixes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtmAvailability_AtmStandardAvailability_AtmStandardAvailabilityId",
                table: "AtmAvailability");

            migrationBuilder.DropForeignKey(
                name: "FK_AtmBreaks_AtmDays_AtmDayId",
                table: "AtmBreaks");

            migrationBuilder.DropForeignKey(
                name: "FK_AtmDays_AtmStandardAvailability_AtmStandardAvailabilityId",
                table: "AtmDays");

            migrationBuilder.DropTable(
                name: "AtmCardScheme");

            migrationBuilder.DropIndex(
                name: "IX_AtmBreaks_AtmDayId",
                table: "AtmBreaks");

            migrationBuilder.DropIndex(
                name: "IX_AtmAvailability_AtmStandardAvailabilityId",
                table: "AtmAvailability");

            migrationBuilder.DropColumn(
                name: "AtmDayId",
                table: "AtmBreaks");

            migrationBuilder.DropColumn(
                name: "AtmStandardAvailabilityId",
                table: "AtmAvailability");

            migrationBuilder.RenameColumn(
                name: "AvailabilityId",
                table: "AtmStandardAvailability",
                newName: "AtmAvailabilityId");

            migrationBuilder.AddColumn<int>(
                name: "CardSchemeId",
                table: "Atms",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AtmStandardAvailabilityId",
                table: "AtmDays",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AtmBreakId",
                table: "AtmDays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AtmStandardAvailability_AtmAvailabilityId",
                table: "AtmStandardAvailability",
                column: "AtmAvailabilityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Atms_CardSchemeId",
                table: "Atms",
                column: "CardSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_AtmDays_AtmBreakId",
                table: "AtmDays",
                column: "AtmBreakId");

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
                principalColumn: "AtmStandardAvailabilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atms_CardSchemes_CardSchemeId",
                table: "Atms",
                column: "CardSchemeId",
                principalTable: "CardSchemes",
                principalColumn: "CardSchemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AtmStandardAvailability_AtmAvailability_AtmAvailabilityId",
                table: "AtmStandardAvailability",
                column: "AtmAvailabilityId",
                principalTable: "AtmAvailability",
                principalColumn: "AtmAvailabilityId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtmDays_AtmBreaks_AtmBreakId",
                table: "AtmDays");

            migrationBuilder.DropForeignKey(
                name: "FK_AtmDays_AtmStandardAvailability_AtmStandardAvailabilityId",
                table: "AtmDays");

            migrationBuilder.DropForeignKey(
                name: "FK_Atms_CardSchemes_CardSchemeId",
                table: "Atms");

            migrationBuilder.DropForeignKey(
                name: "FK_AtmStandardAvailability_AtmAvailability_AtmAvailabilityId",
                table: "AtmStandardAvailability");

            migrationBuilder.DropIndex(
                name: "IX_AtmStandardAvailability_AtmAvailabilityId",
                table: "AtmStandardAvailability");

            migrationBuilder.DropIndex(
                name: "IX_Atms_CardSchemeId",
                table: "Atms");

            migrationBuilder.DropIndex(
                name: "IX_AtmDays_AtmBreakId",
                table: "AtmDays");

            migrationBuilder.DropColumn(
                name: "CardSchemeId",
                table: "Atms");

            migrationBuilder.DropColumn(
                name: "AtmBreakId",
                table: "AtmDays");

            migrationBuilder.RenameColumn(
                name: "AtmAvailabilityId",
                table: "AtmStandardAvailability",
                newName: "AvailabilityId");

            migrationBuilder.AlterColumn<int>(
                name: "AtmStandardAvailabilityId",
                table: "AtmDays",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AtmDayId",
                table: "AtmBreaks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AtmStandardAvailabilityId",
                table: "AtmAvailability",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AtmCardScheme",
                columns: table => new
                {
                    AtmCardSchemesCardSchemeId = table.Column<int>(type: "int", nullable: false),
                    AtmsAtmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmCardScheme", x => new { x.AtmCardSchemesCardSchemeId, x.AtmsAtmId });
                    table.ForeignKey(
                        name: "FK_AtmCardScheme_Atms_AtmsAtmId",
                        column: x => x.AtmsAtmId,
                        principalTable: "Atms",
                        principalColumn: "AtmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtmCardScheme_CardSchemes_AtmCardSchemesCardSchemeId",
                        column: x => x.AtmCardSchemesCardSchemeId,
                        principalTable: "CardSchemes",
                        principalColumn: "CardSchemeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtmBreaks_AtmDayId",
                table: "AtmBreaks",
                column: "AtmDayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AtmAvailability_AtmStandardAvailabilityId",
                table: "AtmAvailability",
                column: "AtmStandardAvailabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_AtmCardScheme_AtmsAtmId",
                table: "AtmCardScheme",
                column: "AtmsAtmId");

            migrationBuilder.AddForeignKey(
                name: "FK_AtmAvailability_AtmStandardAvailability_AtmStandardAvailabilityId",
                table: "AtmAvailability",
                column: "AtmStandardAvailabilityId",
                principalTable: "AtmStandardAvailability",
                principalColumn: "AtmStandardAvailabilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtmBreaks_AtmDays_AtmDayId",
                table: "AtmBreaks",
                column: "AtmDayId",
                principalTable: "AtmDays",
                principalColumn: "AtmDayId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtmDays_AtmStandardAvailability_AtmStandardAvailabilityId",
                table: "AtmDays",
                column: "AtmStandardAvailabilityId",
                principalTable: "AtmStandardAvailability",
                principalColumn: "AtmStandardAvailabilityId");
        }
    }
}
