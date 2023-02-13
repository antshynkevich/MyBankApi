using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataEntityAndAccessLayer.Configurations;

internal class CardSchemeConfig : IEntityTypeConfiguration<CardScheme>
{
    public void Configure(EntityTypeBuilder<CardScheme> builder)
    {
        builder.HasData(
            new { CardSchemeId = 1, CardSchemeName = "AmericanExpress", Description = "Международная платежная система" },
            new { CardSchemeId = 2, CardSchemeName = "Diners", Description = "Международная платежная система" },
            new { CardSchemeId = 3, CardSchemeName = "Discover", Description = "Международная платежная система" },
            new { CardSchemeId = 4, CardSchemeName = "MasterCard", Description = "Международная платежная система" },
            // 5
            new { CardSchemeId = 6, CardSchemeName = "VISA", Description = "Международная платежная система" },
            new { CardSchemeId = 7, CardSchemeName = "MIR", Description = "Российская национальная платежная система" },
            new { CardSchemeId = 8, CardSchemeName = "ArCa", Description = "Армянская национальная платежная система" },
            new { CardSchemeId = 9, CardSchemeName = "BELKART", Description = "Белорусская национальная платежная система" },
            new { CardSchemeId = 10, CardSchemeName = "ELCART", Description = "Киргизская национальная платежная система" },
            new { CardSchemeId = 11, CardSchemeName = "JCB", Description = "Крупнейшая платежная система Японии и одна из пяти ведущих платежных систем мира" },
            new { CardSchemeId = 12, CardSchemeName = "UnionPay", Description = "Национальная платежная система Китая" }
        );
    }
}
