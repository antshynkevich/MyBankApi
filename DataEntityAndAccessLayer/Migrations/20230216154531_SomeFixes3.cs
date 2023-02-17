using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SomeFixes3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtmDays_AtmBreaks_AtmBreakId",
                table: "AtmDays");

            migrationBuilder.DropTable(
                name: "AtmBreaks");

            migrationBuilder.DropIndex(
                name: "IX_AtmDays_AtmBreakId",
                table: "AtmDays");

            migrationBuilder.DropColumn(
                name: "AtmBreakId",
                table: "AtmDays");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "AtmBreak_BreakFromTime",
                table: "AtmDays",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "AtmBreak_BreakToTime",
                table: "AtmDays",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtmBreak_BreakFromTime",
                table: "AtmDays");

            migrationBuilder.DropColumn(
                name: "AtmBreak_BreakToTime",
                table: "AtmDays");

            migrationBuilder.AddColumn<int>(
                name: "AtmBreakId",
                table: "AtmDays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AtmBreaks",
                columns: table => new
                {
                    AtmBreakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreakFromTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    BreakToTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmBreaks", x => x.AtmBreakId);
                });

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
