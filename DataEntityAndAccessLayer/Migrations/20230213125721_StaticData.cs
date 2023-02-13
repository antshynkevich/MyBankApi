using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class StaticData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtmId",
                table: "AtmGeolocations");

            migrationBuilder.InsertData(
                table: "AtmService",
                columns: new[] { "AtmServiceId", "Description", "ServiceName" },
                values: new object[,]
                {
                    { 1, "Снятие наличных", "CashWithdrawal" },
                    { 2, "Смена ПИН", "PINChange" },
                    { 3, "Разблокировка ПИН", "PINUnblock" },
                    { 4, "Активация  ПИН", "PINActivation" },
                    { 5, "Просмотр баланса", "Balance" },
                    { 6, "Выписка", "MiniStatement" },
                    { 7, "Платежи", "BillPayments" },
                    { 8, "Регистрация мобильного банка", "MobileBankingRegistration" },
                    { 9, "Обмен валют", "CurrencyExhange" },
                    { 10, "Пополнение наличными", "CashIn" },
                    { 11, "Другие", "Other" }
                });

            migrationBuilder.InsertData(
                table: "AtmType",
                columns: new[] { "AtmTypeId", "AtmTypeName", "Description" },
                values: new object[,]
                {
                    { 1, "ATM", "Банкомат" },
                    { 2, "PST", "Платежно-справочный терминал" },
                    { 3, "CASHIN", "Платёжно-справочный терминал с функцией приёма денег" }
                });

            migrationBuilder.InsertData(
                table: "CardScheme",
                columns: new[] { "CardSchemeId", "CardSchemeName", "Description" },
                values: new object[,]
                {
                    { 1, "AmericanExpress", "Международная платежная система" },
                    { 2, "Diners", "Международная платежная система" },
                    { 3, "Discover", "Международная платежная система" },
                    { 4, "MasterCard", "Международная платежная система" },
                    { 6, "VISA", "Международная платежная система" },
                    { 7, "MIR", "Российская национальная платежная система" },
                    { 8, "ArCa", "Армянская национальная платежная система" },
                    { 9, "BELKART", "Белорусская национальная платежная система" },
                    { 10, "ELCART", "Киргизская национальная платежная система" },
                    { 11, "JCB", "Крупнейшая платежная система Японии и одна из пяти ведущих платежных систем мира" },
                    { 12, "UnionPay", "Национальная платежная система Китая" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AtmService",
                keyColumn: "AtmServiceId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AtmType",
                keyColumn: "AtmTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AtmType",
                keyColumn: "AtmTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AtmType",
                keyColumn: "AtmTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CardScheme",
                keyColumn: "CardSchemeId",
                keyValue: 12);

            migrationBuilder.AddColumn<int>(
                name: "AtmId",
                table: "AtmGeolocations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
