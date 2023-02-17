using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SomeFixes1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtmDays_AtmBreaks_AtmBreakId",
                table: "AtmDays");

            migrationBuilder.DropIndex(
                name: "IX_AtmDays_AtmBreakId",
                table: "AtmDays");

            migrationBuilder.DropColumn(
                name: "AtmBreakId",
                table: "AtmDays");

            migrationBuilder.RenameColumn(
                name: "DayId",
                table: "AtmBreaks",
                newName: "AtmDayId");

            migrationBuilder.CreateIndex(
                name: "IX_AtmBreaks_AtmDayId",
                table: "AtmBreaks",
                column: "AtmDayId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AtmBreaks_AtmDays_AtmDayId",
                table: "AtmBreaks",
                column: "AtmDayId",
                principalTable: "AtmDays",
                principalColumn: "AtmDayId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtmBreaks_AtmDays_AtmDayId",
                table: "AtmBreaks");

            migrationBuilder.DropIndex(
                name: "IX_AtmBreaks_AtmDayId",
                table: "AtmBreaks");

            migrationBuilder.RenameColumn(
                name: "AtmDayId",
                table: "AtmBreaks",
                newName: "DayId");

            migrationBuilder.AddColumn<int>(
                name: "AtmBreakId",
                table: "AtmDays",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
