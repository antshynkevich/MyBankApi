using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Data2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionEng",
                table: "CardSchemes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEng",
                table: "AtmServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 1,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Оплата услуг мобильных операторов", "", "PaymentMobileServices" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 2,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Выдача наличных", "Cash withdrawal", "CashWithdrawal" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 3,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Изменение PIN-кода", "Change PIN", "PINChange" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 4,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Разблокировка ПИН", "Unlock PIN", "PINUnblock" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 5,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Активация  ПИН", "PIN activation", "PINActivation" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 6,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Перевод с карты на карту", "Transfer from card to card", "Transfer" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 7,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Получение наличных по коду без использования карты", "Getting cash by code without using a card", "CashByCode" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 8,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Просмотр баланса", "Balance view", "Balance" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 9,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Выписка", "Statement", "MiniStatement" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 10,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Платежи", "Payments", "BillPayments" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 11,
                columns: new[] { "Description", "DescriptionEng", "ServiceName" },
                values: new object[] { "Регистрация мобильного банка", "Mobile bank registration", "MobileBankingRegistration" });

            migrationBuilder.InsertData(
                table: "AtmServices",
                columns: new[] { "AtmServiceId", "Description", "DescriptionEng", "ServiceName" },
                values: new object[,]
                {
                    { 12, "Обмен валют", "Currency exchange", "CurrencyExhange" },
                    { 13, "Пополнение наличными", "Cash replenishment", "CashIn" },
                    { 14, "Другие", "Others", "Other" }
                });

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 1,
                column: "DescriptionEng",
                value: "International payment system");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 2,
                column: "DescriptionEng",
                value: "International payment system");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 3,
                column: "DescriptionEng",
                value: "International payment system");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 4,
                column: "DescriptionEng",
                value: "International payment system");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 6,
                column: "DescriptionEng",
                value: "International payment system");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 7,
                column: "DescriptionEng",
                value: "Russian National Payment System");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 8,
                column: "DescriptionEng",
                value: "Armenian National Payment System");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 9,
                column: "DescriptionEng",
                value: "Belarusian National Payment System");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 10,
                column: "DescriptionEng",
                value: "Kyrgyz National Payment System");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 11,
                column: "DescriptionEng",
                value: "Japan National Payment System");

            migrationBuilder.UpdateData(
                table: "CardSchemes",
                keyColumn: "CardSchemeId",
                keyValue: 12,
                column: "DescriptionEng",
                value: "China National Payment System");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 14);

            migrationBuilder.DropColumn(
                name: "DescriptionEng",
                table: "CardSchemes");

            migrationBuilder.DropColumn(
                name: "DescriptionEng",
                table: "AtmServices");

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 1,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Снятие наличных", "CashWithdrawal" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 2,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Смена ПИН", "PINChange" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 3,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Разблокировка ПИН", "PINUnblock" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 4,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Активация  ПИН", "PINActivation" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 5,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Просмотр баланса", "Balance" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 6,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Выписка", "MiniStatement" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 7,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Платежи", "BillPayments" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 8,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Регистрация мобильного банка", "MobileBankingRegistration" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 9,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Обмен валют", "CurrencyExhange" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 10,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Пополнение наличными", "CashIn" });

            migrationBuilder.UpdateData(
                table: "AtmServices",
                keyColumn: "AtmServiceId",
                keyValue: 11,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "Другие", "Other" });
        }
    }
}
