using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataEntityAndAccessLayer.Configurations;

internal class AtmServiceConfig : IEntityTypeConfiguration<AtmService>
{
    public void Configure(EntityTypeBuilder<AtmService> builder)
    {
        builder.HasData(
            new
            {
                AtmServiceId = 1,
                ServiceName = "PaymentMobileServices",
                Description = "Оплата услуг мобильных операторов",
                DescriptionEng = "Payment for the services of mobile operators",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 2,
                ServiceName = "CashWithdrawal",
                Description = "Выдача наличных",
                DescriptionEng = "Cash withdrawal",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 3,
                ServiceName = "PINChange",
                Description = "Изменение PIN-кода",
                DescriptionEng = "Change PIN",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 4,
                ServiceName = "PINUnblock",
                Description = "Разблокировка ПИН",
                DescriptionEng = "Unlock PIN",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 5,
                ServiceName = "PINActivation",
                Description = "Активация  ПИН",
                DescriptionEng = "PIN activation",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 6,
                ServiceName = "Transfer",
                Description = "Перевод с карты на карту",
                DescriptionEng = "Transfer from card to card",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 7,
                ServiceName = "CashByCode",
                Description = "Получение наличных по коду без использования карты",
                DescriptionEng = "Getting cash by code without using a card",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 8,
                ServiceName = "Balance",
                Description = "Просмотр баланса",
                DescriptionEng = "Balance view",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 9,
                ServiceName = "MiniStatement",
                Description = "Выписка",
                DescriptionEng = "Statement",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 10,
                ServiceName = "BillPayments",
                Description = "Платежи",
                DescriptionEng = "Payments",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 11,
                ServiceName = "MobileBankingRegistration",
                Description = "Регистрация мобильного банка",
                DescriptionEng = "Mobile bank registration",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 12,
                ServiceName = "CurrencyExhange",
                Description = "Обмен валют",
                DescriptionEng = "Currency exchange",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 13,
                ServiceName = "CashIn",
                Description = "Пополнение наличными",
                DescriptionEng = "Cash replenishment",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 14,
                ServiceName = "CashlessPayments",
                Description = "Безналичные платежи",
                DescriptionEng = "Cashless payments",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 15,
                ServiceName = "CashPayments",
                Description = "Платежи наличными",
                DescriptionEng = "Cash payments",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 16,
                ServiceName = "CashAcceptance",
                Description = "Прием наличных",
                DescriptionEng = "Cash acceptance",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 17,
                ServiceName = "CurrencyExchange",
                Description = "Обмен валюты",
                DescriptionEng = "Currency exchange",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 18,
                ServiceName = "AcceptanceProceeds",
                Description = "Прием выручки",
                DescriptionEng = "Acceptance of proceeds",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 19,
                ServiceName = "ContactlessWithdrawal",
                Description = "Бесконтактное cнятие наличных",
                DescriptionEng = "Contactless cash withdrawal",
                Atms = new List<Atm>()
            },
            new
            {
                AtmServiceId = 20,
                ServiceName = "Other",
                Description = "Другие",
                DescriptionEng = "Others",
                Atms = new List<Atm>()
            }
        );
    }
}
