using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Data3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 14,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Безналичные платежи", "Cashless payments", "CashlessPayments" });

            migrationBuilder.InsertData(
                table: "AtmServices",
                columns: new[] { "AtmServiceId", "Description", "DescriptionEng", "ServiceName" },
                values: new object[,]
                {
                    { 15, "Платежи наличными", "Cash payments", "CashPayments" },
                    { 16, "Прием наличных", "Cash acceptance", "CashAcceptance" },
                    { 17, "Обмен валюты", "Currency exchange", "CurrencyExchange" },
                    { 18, "Прием выручки", "Acceptance of proceeds", "AcceptanceProceeds" },
                    { 19, "Бесконтактное cнятие наличных", "Contactless cash withdrawal", "ContactlessWithdrawal" },
                    { 20, "Другие", "Others", "Other" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 14,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Другие", "Others", "Other" });
        }
    }
}
