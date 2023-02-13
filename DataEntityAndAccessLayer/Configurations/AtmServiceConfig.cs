using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataEntityAndAccessLayer.Configurations;

internal class AtmServiceConfig : IEntityTypeConfiguration<AtmService>
{
    public void Configure(EntityTypeBuilder<AtmService> builder)
    {
        builder.HasData(
            new { AtmServiceId = 1, ServiceName = "CashWithdrawal", Description = "Снятие наличных" },
            new { AtmServiceId = 2, ServiceName = "PINChange", Description = "Смена ПИН" },
            new { AtmServiceId = 3, ServiceName = "PINUnblock", Description = "Разблокировка ПИН" },
            new { AtmServiceId = 4, ServiceName = "PINActivation", Description = "Активация  ПИН" },
            new { AtmServiceId = 5, ServiceName = "Balance", Description = "Просмотр баланса" },
            new { AtmServiceId = 6, ServiceName = "MiniStatement", Description = "Выписка" },
            new { AtmServiceId = 7, ServiceName = "BillPayments", Description = "Платежи" },
            new { AtmServiceId = 8, ServiceName = "MobileBankingRegistration", Description = "Регистрация мобильного банка" },
            new { AtmServiceId = 9, ServiceName = "CurrencyExhange", Description = "Обмен валют" },
            new { AtmServiceId = 10, ServiceName = "CashIn", Description = "Пополнение наличными" },
            new { AtmServiceId = 11, ServiceName = "Other", Description = "Другие" }
        );
    }
}
