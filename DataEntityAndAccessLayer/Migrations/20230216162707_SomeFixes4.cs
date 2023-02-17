using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SomeFixes4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 1,
                column: "DescriptionEng",
                value: "Payment for the services of mobile operators");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 1,
                column: "DescriptionEng",
                value: "");
        }
    }
}
