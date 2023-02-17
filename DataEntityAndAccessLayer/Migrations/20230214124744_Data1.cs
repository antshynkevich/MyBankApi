using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Data1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 6,
                column: "CardSchemeName",
                value: "Visa");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 7,
                column: "CardSchemeName",
                value: "МИР");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 9,
                column: "CardSchemeName",
                value: "БЕЛКАРТ");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 12,
                column: "CardSchemeName",
                value: "UPI");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 6,
                column: "CardSchemeName",
                value: "VISA");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 7,
                column: "CardSchemeName",
                value: "MIR");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 9,
                column: "CardSchemeName",
                value: "BELKART");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 12,
                column: "CardSchemeName",
                value: "UnionPay");
        }
    }
}
