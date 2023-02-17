using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataEntityAndAccessLayer.Configurations;

internal class CardSchemeConfig : IEntityTypeConfiguration<CardScheme>
{
    public void Configure(EntityTypeBuilder<CardScheme> builder)
    {
        builder.HasData(
            new
            {
                CardSchemeId = 1, CardSchemeName = "AmericanExpress", Description = "Международная платежная система",
                DescriptionEng = "International payment system", Atms = new List<Atm>()
            },
            new
            {
                CardSchemeId = 2, CardSchemeName = "Diners", Description = "Международная платежная система",
                DescriptionEng = "International payment system", Atms = new List<Atm>()
            },
            new
            {
                CardSchemeId = 3, CardSchemeName = "Discover", Description = "Международная платежная система",
                DescriptionEng = "International payment system", Atms = new List<Atm>()
            },
            new
            {
                CardSchemeId = 4, CardSchemeName = "MasterCard", Description = "Международная платежная система",
                DescriptionEng = "International payment system", Atms = new List<Atm>()
            },
            // 5
            new
            {
                CardSchemeId = 6, CardSchemeName = "Visa", Description = "Международная платежная система",
                DescriptionEng = "International payment system", Atms = new List<Atm>()
            },
            new
            {
                CardSchemeId = 7, CardSchemeName = "МИР", Description = "Российская национальная платежная система",
                DescriptionEng = "Russian National Payment System"
            },
            new
            {
                CardSchemeId = 8, CardSchemeName = "ArCa", Description = "Армянская национальная платежная система",
                DescriptionEng = "Armenian National Payment System", Atms = new List<Atm>()
            },
            new
            {
                CardSchemeId = 9, CardSchemeName = "БЕЛКАРТ",
                Description = "Белорусская национальная платежная система",
                DescriptionEng = "Belarusian National Payment System", Atms = new List<Atm>()
            },
            new
            {
                CardSchemeId = 10, CardSchemeName = "ELCART", Description = "Киргизская национальная платежная система",
                DescriptionEng = "Kyrgyz National Payment System", Atms = new List<Atm>()
            },
            new
            {
                CardSchemeId = 11, CardSchemeName = "JCB", Description = "Крупнейшая платежная система " +
                                                                         "Японии и одна из пяти ведущих платежных систем мира",
                DescriptionEng = "Japan National Payment System", Atms = new List<Atm>()
            },
            new
            {
                CardSchemeId = 12, CardSchemeName = "UPI", Description = "Национальная платежная система Китая",
                DescriptionEng = "China National Payment System", Atms = new List<Atm>()
            }
        );
    }
}