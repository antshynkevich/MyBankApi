using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SomeFixes5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atms_CardSchemes_CardSchemeId",
                table: "Atms");

            migrationBuilder.DropIndex(
                name: "IX_Atms_CardSchemeId",
                table: "Atms");

            migrationBuilder.DropColumn(
                name: "CardSchemeId",
                table: "Atms");

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
                name: "IX_AtmCardScheme_AtmsAtmId",
                table: "AtmCardScheme",
                column: "AtmsAtmId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtmCardScheme");

            migrationBuilder.AddColumn<int>(
                name: "CardSchemeId",
                table: "Atms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Atms_CardSchemeId",
                table: "Atms",
                column: "CardSchemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atms_CardSchemes_CardSchemeId",
                table: "Atms",
                column: "CardSchemeId",
                principalTable: "CardSchemes",
                principalColumn: "CardSchemeId");
        }
    }
}
